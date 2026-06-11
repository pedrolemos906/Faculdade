// ===== CARREGAR DADOS =====

fetch('assets/data/placar.json')
    .then(function(response) {
        return response.json();
    })
    .then(function(dados) {

        // salva no LocalStorage na primeira carga
        if (!localStorage.getItem('placar')) {
            localStorage.setItem('placar', JSON.stringify(dados));
        }

        // preenche o nome do grupo
        document.getElementById('nome-grupo').textContent = dados.grupo.nome;

        // ordena os usuários do maior para o menor pontuação
        const usuariosOrdenados = dados.usuarios.sort(function(a, b) {
            if (b.pontos.total > a.pontos.total) return 1;
            if (b.pontos.total < a.pontos.total) return -1;
            return 0;
        });

        // renderiza o pódio e a lista
        renderizarPodio(usuariosOrdenados);
        renderizarLista(usuariosOrdenados);
    });


// ===== PÓDIO =====

function renderizarPodio(usuarios) {

    // pódio só mostra os 3 primeiros
    const top3 = usuarios.slice(0, 3);

    // posições no pódio: index 0 = 1º, index 1 = 2º, index 2 = 3º
    const posicoes = [1, 2, 3];

    posicoes.forEach(function(posicao) {
        const usuario = top3[posicao - 1];

        if (usuario) {
            document.getElementById(`foto-${posicao}`).src = usuario.foto;
            document.getElementById(`foto-${posicao}`).alt = usuario.nome;
            document.getElementById(`nome-${posicao}`).textContent = usuario.nome;
            document.getElementById(`pts-${posicao}`).textContent = usuario.pontos.total + ' pts';
        }
    });
}


// ===== LISTA COMPLETA =====

function renderizarLista(usuarios) {
    const lista = document.getElementById('lista-placar');
    lista.innerHTML = '';

    usuarios.forEach(function(usuario, index) {
        const posicao = index + 1; // index começa em 0, posição em 1

        lista.innerHTML += `
            <div class="lista-row">
                <div class="lista-rank">${posicao}</div>
                <img class="lista-foto" src="${usuario.foto}" alt="${usuario.nome}">
                <div class="lista-nome">${usuario.nome}</div>
                <div class="lista-pts">${usuario.pontos.total} pts</div>
            </div>
        `;
    });
}

// ===== GERENCIAR GRUPO =====

function toggleGerenciar() {
    const painel = document.getElementById('painel-gerenciar');

    // alterna entre mostrar e esconder o painel
    if (painel.style.display === 'none') {
        painel.style.display = 'block';
        renderizarGerenciar();
    } else {
        painel.style.display = 'none';
    }
}


function renderizarGerenciar() {
    const dados = JSON.parse(localStorage.getItem('placar'));
    const lista = document.getElementById('lista-gerenciar');
    lista.innerHTML = '';

    dados.usuarios.forEach(function(usuario) {
        lista.innerHTML += `
            <div class="gerenciar-row">
                <span>${usuario.nome}</span>
                <button class="btn-remover" onclick="removerUsuario('${usuario.id}')">✕</button>
            </div>
        `;
    });
}


function adicionarUsuario() {
    const input = document.getElementById('input-nome');
    const nome = input.value.trim();

    // impede adicionar com campo vazio
    if (!nome) return;

    const dados = JSON.parse(localStorage.getItem('placar'));

    // gera um id único baseado no timestamp
    const novoUsuario = {
        id: Date.now().toString(),
        nome: nome,
        foto: 'assets/images/default.jpg',
        pontos: {
            tempo: 0,
            tarefas: 0,
            total: 0
        }
    };

    dados.usuarios.push(novoUsuario);
    localStorage.setItem('placar', JSON.stringify(dados));

    input.value = '';
    renderizarGerenciar();
    atualizarPlacar(dados.usuarios);
}


function removerUsuario(id) {
    const dados = JSON.parse(localStorage.getItem('placar'));

    // filter cria um novo array sem o usuário com o id informado
    dados.usuarios = dados.usuarios.filter(function(usuario) {
        return usuario.id !== id;
    });

    localStorage.setItem('placar', JSON.stringify(dados));
    renderizarGerenciar();
    atualizarPlacar(dados.usuarios);
}


function atualizarPlacar(usuarios) {
    const ordenados = usuarios.sort(function(a, b) {
        if (b.pontos.total > a.pontos.total) return 1;
        if (b.pontos.total < a.pontos.total) return -1;
        return 0;
    });

    renderizarPodio(ordenados);
    renderizarLista(ordenados);
}