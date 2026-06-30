const parceirosBase = [
    {
        id: 1,
        usuarioId: null,
        nome: "Pedro Henrique",
        idioma: "Ingles",
        nivel: "Intermediario",
        disponibilidade: "Noite",
        contato: "pedro@email.com",
        cidade: "Belo Horizonte",
        destaque: true,
        imagem_principal: "assets/gb.png",
        descricao: "Procuro parceiros para praticar ingles em conversas leves sobre tecnologia, jogos e cultura pop.",
        objetivo: "Ganhar confianca para conversar em viagens e entrevistas.",
        interesses: "Tecnologia, games, filmes e musica",
        formato: "Chamadas de video ou audio duas vezes por semana",
        fotos: [
            { titulo: "Video Games", imagem: "assets/games.jpg" },
            { titulo: "Anime/Desenhos", imagem: "assets/anime.jpg" },
            { titulo: "Noticias", imagem: "assets/news.jpg" }
        ]
    },
    {
        id: 2,
        usuarioId: null,
        nome: "Ana Costa",
        idioma: "Frances",
        nivel: "Basico",
        disponibilidade: "Tarde",
        contato: "ana@email.com",
        cidade: "Contagem",
        destaque: true,
        imagem_principal: "assets/fr.png",
        descricao: "Quero melhorar minha conversacao em frances com pessoas pacientes e interessadas em cultura.",
        objetivo: "Conseguir manter conversas simples sobre rotina, estudos e viagens.",
        interesses: "Viagens, gastronomia, fotografia e literatura",
        formato: "Mensagens durante a semana e chamada curta aos sabados",
        fotos: [
            { titulo: "Noticias", imagem: "assets/news.jpg" },
            { titulo: "Video Games", imagem: "assets/games.jpg" },
            { titulo: "Arte", imagem: "assets/art.jpg" }
        ]
    },
    {
        id: 3,
        usuarioId: null,
        nome: "Lucas Martins",
        idioma: "Espanhol",
        nivel: "Avancado",
        disponibilidade: "Manha",
        contato: "lucas@email.com",
        cidade: "Betim",
        destaque: false,
        imagem_principal: "assets/es.png",
        descricao: "Busco praticar espanhol com foco em conversas rapidas, vocabulario profissional e temas do cotidiano.",
        objetivo: "Manter fluencia e ampliar vocabulario para oportunidades de trabalho.",
        interesses: "Negocios, esportes, noticias e series",
        formato: "Encontros online de 30 minutos",
        fotos: [
            { titulo: "Viagens", imagem: "assets/trip.jpg" },
            { titulo: "Noticias", imagem: "assets/news.jpg" },
            { titulo: "Video Games", imagem: "assets/games.jpg" }
        ]
    },
    {
        id: 4,
        usuarioId: null,
        nome: "Mariana Alves",
        idioma: "Mandarim",
        nivel: "Basico",
        disponibilidade: "Fim de semana",
        contato: "mariana@email.com",
        cidade: "Nova Lima",
        destaque: true,
        imagem_principal: "assets/cn.png",
        descricao: "Estou comecando no mandarim e quero praticar sem pressao, com conversas simples e correcoes gentis.",
        objetivo: "Aprender frases uteis para trabalho, estudos e situacoes do dia a dia.",
        interesses: "Musica, culinaria, series e rotina de estudos",
        formato: "Troca de mensagens e chamadas curtas aos domingos",
        fotos: [
            { titulo: "Viagens", imagem: "assets/trip.jpg" },
            { titulo: "Tecnologia", imagem: "assets/tec.jpg" },
            { titulo: "Cinema", imagem: "assets/cine.jpg" }
        ]
    },
    {
        id: 5,
        usuarioId: null,
        nome: "Rafael Souza",
        idioma: "Alemao",
        nivel: "Intermediario",
        disponibilidade: "Noite",
        contato: "rafael@email.com",
        cidade: "Belo Horizonte",
        destaque: false,
        imagem_principal: "assets/de.png",
        descricao: "Gosto de praticar alemao falando sobre cinema, musica e diferencas culturais entre paises.",
        objetivo: "Melhorar pronuncia e naturalidade na fala.",
        interesses: "Cinema, musica, historia e cultura francesa",
        formato: "Chamada semanal com troca de temas antes da conversa",
        fotos: [
            { titulo: "Cinema", imagem: "assets/cine.jpg" },
            { titulo: "Video Games", imagem: "assets/games.jpg" },
            { titulo: "Tecnologia", imagem: "assets/tec.jpg" }
        ]
    },
    {
        id: 6,
        usuarioId: null,
        nome: "Antonio Nunes",
        idioma: "Italiano",
        nivel: "Basico",
        disponibilidade: "Noite",
        contato: "antonio@email.com",
        cidade: "Belo Horizonte",
        destaque: false,
        imagem_principal: "assets/it.png",
        descricao: "Gosto de praticar italiano falando sobre cinema, musica e diferencas culturais entre paises.",
        objetivo: "Melhorar pronuncia e naturalidade na fala.",
        interesses: "Cinema, musica, historia e cultura francesa",
        formato: "Chamada semanal com troca de temas antes da conversa",
        fotos: [
            { titulo: "Noticias", imagem: "assets/news.jpg" },
            { titulo: "Cinema", imagem: "assets/cine.jpg" },
            { titulo: "Viagens", imagem: "assets/trip.jpg" }
        ]
    },
    {
        id: 7,
        usuarioId: null,
        nome: "Natalia Silva",
        idioma: "Japones",
        nivel: "Basico",
        disponibilidade: "Fim de semana",
        contato: "natalia@email.com",
        cidade: "Rio de Janeiro",
        destaque: true,
        imagem_principal: "assets/jp.png",
        descricao: "Estou comecando no japones e quero praticar sem pressao, com conversas simples e correcoes gentis.",
        objetivo: "Aprender frases uteis para trabalho, estudos e situacoes do dia a dia.",
        interesses: "Musica, culinaria, series e rotina de estudos",
        formato: "Troca de mensagens e chamadas curtas aos domingos",
        fotos: [
            { titulo: "Video Games", imagem: "assets/games.jpg" },
            { titulo: "Anime/Desenhos", imagem: "assets/anime.jpg" },
            { titulo: "Noticias", imagem: "assets/news.jpg" }
        ]
    }
];

const STORAGE_USUARIOS = "talkhubUsuarios";
const STORAGE_PARCEIROS = "talkhubParceiros";
const STORAGE_SESSAO = "talkhubUsuarioLogado";
const STORAGE_FAVORITOS = "talkhubFavoritos";

const imagemPorIdioma = {
    ingles: "assets/gb.png",
    frances: "assets/fr.png",
    espanhol: "assets/es.png",
    mandarim: "assets/cn.png",
    alemao: "assets/de.png",
    italiano: "assets/it.png",
    japones: "assets/jp.png"
};

const opcoesIdiomas = ["Ingles", "Espanhol", "Frances", "Italiano", "Alemao", "Japones", "Mandarim"];
const opcoesNiveis = ["Basico", "Intermediario", "Avancado"];
const opcoesDisponibilidade = ["Manha", "Tarde", "Noite", "Fim de semana", "A combinar"];
const opcoesFormato = ["Presencial", "Video Chamadas"];
const fotosPorInteresse = {
    "Tecnologia": "assets/tec.jpg",
    "Video Games": "assets/games.jpg",
    "Anime/Desenhos": "assets/anime.jpg",
    "Noticias": "assets/news.jpg",
    "Viagens": "assets/trip.jpg",
    "Arte": "assets/art.jpg",
    "Cinema": "assets/cine.jpg"
};
const opcoesInteresses = Object.keys(fotosPorInteresse);

let dados = {
    parceiros: carregarParceiros()
};

let termoPesquisa = "";
let idiomaAtivo = "Todos";

function carregarUsuarios() {
    return JSON.parse(localStorage.getItem(STORAGE_USUARIOS)) || [];
}

function salvarUsuarios(usuarios) {
    localStorage.setItem(STORAGE_USUARIOS, JSON.stringify(usuarios));
}

function carregarParceirosExtras() {
    return JSON.parse(localStorage.getItem(STORAGE_PARCEIROS)) || [];
}

function salvarParceirosExtras(parceiros) {
    localStorage.setItem(STORAGE_PARCEIROS, JSON.stringify(parceiros));
}

function carregarFavoritos() {
    return JSON.parse(localStorage.getItem(STORAGE_FAVORITOS)) || {};
}

function salvarFavoritos(favoritos) {
    localStorage.setItem(STORAGE_FAVORITOS, JSON.stringify(favoritos));
}

function carregarParceiros() {
    return [...parceirosBase, ...carregarParceirosExtras()];
}

function usuarioLogado() {
    const id = localStorage.getItem(STORAGE_SESSAO);

    if (!id) {
        return null;
    }

    return carregarUsuarios().find((usuario) => usuario.id === id) || null;
}

function normalizar(texto) {
    return texto.toLowerCase().normalize("NFD").replace(/[\u0300-\u036f]/g, "");
}

function escapeHtml(valor) {
    return String(valor || "")
        .replaceAll("&", "&amp;")
        .replaceAll("<", "&lt;")
        .replaceAll(">", "&gt;")
        .replaceAll('"', "&quot;")
        .replaceAll("'", "&#039;");
}

function montarOptions(opcoes, selecionado = "") {
    return opcoes.map((opcao) => `
        <option value="${escapeHtml(opcao)}" ${opcao === selecionado ? "selected" : ""}>${escapeHtml(opcao)}</option>
    `).join("");
}

function montarCheckboxInteresses(interesses = "") {
    const selecionados = interesses.split(",").map((item) => item.trim());

    return opcoesInteresses.map((interesse) => `
        <label class="checkbox-option">
            <input type="checkbox" name="interesses" value="${escapeHtml(interesse)}" ${selecionados.includes(interesse) ? "checked" : ""}>
            <span>${escapeHtml(interesse)}</span>
        </label>
    `).join("");
}

function montarFotosPorInteresses(interesses) {
    const listaInteresses = Array.isArray(interesses)
        ? interesses
        : String(interesses || "").split(",").map((item) => item.trim()).filter(Boolean);

    return listaInteresses
        .filter((interesse) => fotosPorInteresse[interesse])
        .map((interesse) => ({
            titulo: interesse,
            imagem: fotosPorInteresse[interesse]
        }));
}

function montarTopoUsuario() {
    const menu = document.querySelector(".navbar-collapse");

    if (!menu || document.getElementById("auth-area")) {
        return;
    }

    menu.insertAdjacentHTML("beforeend", `
        <div class="auth-area" id="auth-area"></div>
    `);

    renderizarTopoUsuario();
}

function renderizarTopoUsuario() {
    const area = document.getElementById("auth-area");
    const usuario = usuarioLogado();

    if (!area) {
        return;
    }

    if (usuario) {
        area.innerHTML = `
            <span class="auth-user">Ola, ${escapeHtml(usuario.nome)}</span>
            <a class="btn btn-outline-talkhub btn-sm" href="favoritos.html">Favoritos</a>
            <button class="btn btn-outline-talkhub btn-sm" type="button" id="btn-logout">Sair</button>
        `;

        document.getElementById("btn-logout").addEventListener("click", () => {
            localStorage.removeItem(STORAGE_SESSAO);
            atualizarTela();
        });
        return;
    }

    area.innerHTML = `
        <button class="btn btn-outline-talkhub btn-sm" type="button" data-auth-view="login">Login</button>
        <button class="btn btn-talkhub btn-sm" type="button" data-auth-view="cadastro">Cadastro</button>
    `;

    area.querySelectorAll("[data-auth-view]").forEach((botao) => {
        botao.addEventListener("click", () => abrirModalAuth(botao.dataset.authView));
    });
}

function abrirModalAuth(viewInicial) {
    const modalExistente = document.getElementById("auth-modal");

    if (modalExistente) {
        modalExistente.remove();
    }

    document.body.insertAdjacentHTML("beforeend", `
        <div class="auth-modal" id="auth-modal">
            <div class="auth-modal-box">
                <button class="auth-close" type="button" aria-label="Fechar" id="auth-close">&times;</button>
                <div class="auth-tabs">
                    <button class="auth-tab" type="button" data-auth-tab="login">Login</button>
                    <button class="auth-tab" type="button" data-auth-tab="cadastro">Cadastro</button>
                </div>

                <form class="auth-form" id="form-login">
                    <h2>Entrar</h2>
                    <label>
                        E-mail
                        <input type="email" name="email" required>
                    </label>
                    <label>
                        Senha
                        <input type="password" name="senha" required>
                    </label>
                    <p class="form-msg" id="login-msg"></p>
                    <button class="btn btn-talkhub w-100" type="submit">Entrar</button>
                </form>

                <form class="auth-form" id="form-cadastro">
                    <h2>Criar conta</h2>
                    <label>
                        Nome
                        <input type="text" name="nome" required>
                    </label>
                    <label>
                        E-mail
                        <input type="email" name="email" required>
                    </label>
                    <label>
                        Senha
                        <input type="password" name="senha" required>
                    </label>
                    <p class="form-msg" id="cadastro-msg"></p>
                    <button class="btn btn-talkhub w-100" type="submit">Cadastrar</button>
                </form>
            </div>
        </div>
    `);

    document.getElementById("auth-close").addEventListener("click", fecharModalAuth);
    document.getElementById("auth-modal").addEventListener("click", (evento) => {
        if (evento.target.id === "auth-modal") {
            fecharModalAuth();
        }
    });

    document.querySelectorAll("[data-auth-tab]").forEach((botao) => {
        botao.addEventListener("click", () => trocarAuthView(botao.dataset.authTab));
    });

    document.getElementById("form-login").addEventListener("submit", fazerLogin);
    document.getElementById("form-cadastro").addEventListener("submit", fazerCadastro);

    trocarAuthView(viewInicial);
}

function trocarAuthView(view) {
    document.querySelectorAll(".auth-tab").forEach((botao) => {
        botao.classList.toggle("ativo", botao.dataset.authTab === view);
    });

    document.getElementById("form-login").classList.toggle("ativo", view === "login");
    document.getElementById("form-cadastro").classList.toggle("ativo", view === "cadastro");
}

function fecharModalAuth() {
    const modal = document.getElementById("auth-modal");

    if (modal) {
        modal.remove();
    }
}

function fazerLogin(evento) {
    evento.preventDefault();

    const form = evento.currentTarget;
    const email = form.email.value.trim();
    const senha = form.senha.value;
    const usuario = carregarUsuarios().find((item) => item.email === email && item.senha === senha);

    if (!usuario) {
        document.getElementById("login-msg").textContent = "E-mail ou senha nao encontrado.";
        return;
    }

    localStorage.setItem(STORAGE_SESSAO, usuario.id);
    fecharModalAuth();
    atualizarTela();
}

function fazerCadastro(evento) {
    evento.preventDefault();

    const form = evento.currentTarget;
    const usuarios = carregarUsuarios();
    const email = form.email.value.trim();

    if (usuarios.some((usuario) => usuario.email === email)) {
        document.getElementById("cadastro-msg").textContent = "Ja existe uma conta com esse e-mail.";
        return;
    }

    const usuario = {
        id: `user-${Date.now()}`,
        nome: form.nome.value.trim(),
        email,
        senha: form.senha.value
    };

    usuarios.push(usuario);
    salvarUsuarios(usuarios);
    localStorage.setItem(STORAGE_SESSAO, usuario.id);
    fecharModalAuth();
    atualizarTela();
}

function proximoIdParceiro() {
    return Math.max(...carregarParceiros().map((parceiro) => parceiro.id)) + 1;
}

function podeEditar(parceiro) {
    const usuario = usuarioLogado();

    return Boolean(usuario && parceiro.usuarioId === usuario.id);
}

function idsFavoritosUsuario() {
    const usuario = usuarioLogado();

    if (!usuario) {
        return [];
    }

    return carregarFavoritos()[usuario.id] || [];
}

function ehFavorito(parceiroId) {
    return idsFavoritosUsuario().includes(Number(parceiroId));
}

function alternarFavorito(parceiroId) {
    const usuario = usuarioLogado();

    if (!usuario) {
        return;
    }

    const favoritos = carregarFavoritos();
    const favoritosUsuario = favoritos[usuario.id] || [];
    const id = Number(parceiroId);

    favoritos[usuario.id] = favoritosUsuario.includes(id)
        ? favoritosUsuario.filter((favoritoId) => favoritoId !== id)
        : [...favoritosUsuario, id];

    salvarFavoritos(favoritos);
    atualizarTela();
}

function botaoFavorito(parceiro) {
    if (!usuarioLogado()) {
        return "";
    }

    const favorito = ehFavorito(parceiro.id);

    return `
        <button class="favorito-btn ${favorito ? "ativo" : ""}" type="button" data-favorito-id="${parceiro.id}" aria-label="${favorito ? "Remover dos favoritos" : "Adicionar aos favoritos"}" title="${favorito ? "Remover dos favoritos" : "Adicionar aos favoritos"}">
            ${favorito ? "★" : "☆"}
        </button>
    `;
}

function configurarBotoesFavoritos(scope = document) {
    scope.querySelectorAll("[data-favorito-id]").forEach((botao) => {
        botao.addEventListener("click", () => alternarFavorito(botao.dataset.favoritoId));
    });
}

function obterMeuCard() {
    const usuario = usuarioLogado();

    if (!usuario) {
        return null;
    }

    return dados.parceiros.find((parceiro) => parceiro.usuarioId === usuario.id) || null;
}

function montarMeuCard() {
    const container = document.getElementById("meu-card-container");

    if (!container) {
        return;
    }

    const usuario = usuarioLogado();

    if (!usuario) {
        container.innerHTML = `
            <div class="meu-card-box">
                <p>Entre ou crie uma conta para cadastrar e gerenciar o seu card.</p>
                <button class="btn btn-talkhub" type="button" data-auth-view="login">Fazer login</button>
                <button class="btn btn-outline-talkhub" type="button" data-auth-view="cadastro">Criar conta</button>
            </div>
        `;

        container.querySelectorAll("[data-auth-view]").forEach((botao) => {
            botao.addEventListener("click", () => abrirModalAuth(botao.dataset.authView));
        });
        return;
    }

    const meuCard = obterMeuCard();

    if (!meuCard) {
        container.innerHTML = `
            <div class="meu-card-box">
                <div>
                    <h3>Voce ainda nao tem um card</h3>
                    <p>Crie um card para aparecer na lista de parceiros cadastrados.</p>
                </div>
                <button class="btn btn-talkhub" type="button" id="btn-criar-meu-card">Criar meu card</button>
            </div>
            <div id="meu-card-form-container"></div>
        `;

        document.getElementById("btn-criar-meu-card").addEventListener("click", () => abrirFormularioMeuCard());
        return;
    }

    container.innerHTML = `
        <div class="meu-card-box meu-card-resumo">
            <img src="${meuCard.imagem_principal}" alt="${escapeHtml(meuCard.nome)}">
            <div>
                <span class="badge badge-idioma">${escapeHtml(meuCard.idioma)}</span>
                <h3>${escapeHtml(meuCard.nome)}</h3>
                <p>${escapeHtml(meuCard.descricao)}</p>
                <ul class="card-list">
                    <li><strong>Nivel:</strong> ${escapeHtml(meuCard.nivel)}</li>
                    <li><strong>Disponibilidade:</strong> ${escapeHtml(meuCard.disponibilidade)}</li>
                    <li><strong>Cidade/Estado/Pais:</strong> ${escapeHtml(meuCard.cidade)}</li>
                </ul>
                <div class="meu-card-actions">
                    <a class="btn btn-talkhub" href="detalhe.html?id=${meuCard.id}">Ver detalhes</a>
                    <button class="btn btn-outline-talkhub" type="button" id="btn-editar-meu-card-home">Editar</button>
                    <button class="btn btn-outline-danger-talkhub" type="button" id="btn-excluir-meu-card">Excluir</button>
                </div>
            </div>
        </div>
        <div id="meu-card-form-container"></div>
    `;

    document.getElementById("btn-editar-meu-card-home").addEventListener("click", () => abrirFormularioMeuCard(meuCard));
    document.getElementById("btn-excluir-meu-card").addEventListener("click", excluirMeuCard);
}

function abrirFormularioMeuCard(parceiro = null) {
    const container = document.getElementById("meu-card-form-container");
    const usuario = usuarioLogado();

    if (!container || !usuario) {
        return;
    }

    const card = parceiro || {
        nome: usuario.nome,
        idioma: opcoesIdiomas[0],
        nivel: opcoesNiveis[0],
        disponibilidade: opcoesDisponibilidade[4],
        cidade: "",
        contato: usuario.email,
        descricao: "",
        objetivo: "",
        interesses: "Tecnologia, Noticias",
        formato: opcoesFormato[1]
    };

    container.innerHTML = montarFormularioCard(card, parceiro ? "Editar meu card" : "Criar meu card", parceiro ? "Salvar alteracoes" : "Cadastrar card");

    const form = document.getElementById("meu-card-crud-form");
    form.addEventListener("submit", (evento) => salvarMeuCard(evento, parceiro?.id || null));
    document.getElementById("cancelar-meu-card").addEventListener("click", montarMeuCard);
    form.scrollIntoView({ behavior: "smooth", block: "start" });
}

function montarFormularioCard(parceiro, titulo, textoBotao, opcoes = {}) {
    const formId = opcoes.formId || "meu-card-crud-form";
    const cancelId = opcoes.cancelId || "cancelar-meu-card";

    return `
        <form class="edit-card-form" id="${formId}">
            <h2>${escapeHtml(titulo)}</h2>
            <div class="edit-form-grid">
                <label>
                    Nome
                    <input type="text" name="nome" value="${escapeHtml(parceiro.nome)}" required>
                </label>
                <label>
                    Idioma
                    <select name="idioma" required>
                        ${montarOptions(opcoesIdiomas, parceiro.idioma)}
                    </select>
                </label>
                <label>
                    Nivel
                    <select name="nivel" required>
                        ${montarOptions(opcoesNiveis, parceiro.nivel)}
                    </select>
                </label>
                <label>
                    Disponibilidade
                    <select name="disponibilidade" required>
                        ${montarOptions(opcoesDisponibilidade, parceiro.disponibilidade)}
                    </select>
                </label>
                <label>
                    Cidade/Estado/Pais
                    <input type="text" name="cidade" value="${escapeHtml(parceiro.cidade)}" required>
                </label>
                <label>
                    Contato
                    <input type="email" name="contato" value="${escapeHtml(parceiro.contato)}" required>
                </label>
                <label class="full">
                    Descricao
                    <textarea name="descricao" required>${escapeHtml(parceiro.descricao)}</textarea>
                </label>
                <label class="full">
                    Objetivo
                    <textarea name="objetivo" required>${escapeHtml(parceiro.objetivo)}</textarea>
                </label>
                <label class="full">
                    Interesses
                    <div class="checkbox-list">
                        ${montarCheckboxInteresses(parceiro.interesses)}
                    </div>
                    <span class="field-help">Os interesses escolhidos definem as fotos em "Momentos e interesses".</span>
                </label>
                <label class="full">
                    Formato
                    <select name="formato" required>
                        ${montarOptions(opcoesFormato, opcoesFormato.includes(parceiro.formato) ? parceiro.formato : opcoesFormato[1])}
                    </select>
                </label>
            </div>
            <div class="edit-actions">
                <button class="btn btn-talkhub" type="submit">${escapeHtml(textoBotao)}</button>
                <button class="btn btn-outline-talkhub" type="button" id="${cancelId}">Cancelar</button>
            </div>
        </form>
    `;
}

function coletarDadosCard(form, existente = {}) {
    const usuario = usuarioLogado();
    const idioma = form.idioma.value.trim();
    const interessesSelecionados = [...form.querySelectorAll('input[name="interesses"]:checked')]
        .map((checkbox) => checkbox.value);

    if (interessesSelecionados.length === 0) {
        const ajuda = form.querySelector(".field-help");
        ajuda.textContent = "Escolha pelo menos um interesse.";
        ajuda.classList.add("erro");
        return null;
    }

    return {
        ...existente,
        usuarioId: usuario.id,
        nome: form.nome.value.trim(),
        idioma,
        nivel: form.nivel.value.trim(),
        disponibilidade: form.disponibilidade.value.trim(),
        contato: form.contato.value.trim(),
        cidade: form.cidade.value.trim(),
        destaque: false,
        imagem_principal: imagemPorIdioma[normalizar(idioma)] || existente.imagem_principal || "assets/fotoPerfil.png",
        descricao: form.descricao.value.trim(),
        objetivo: form.objetivo.value.trim(),
        interesses: interessesSelecionados.join(", "),
        formato: form.formato.value.trim(),
        fotos: montarFotosPorInteresses(interessesSelecionados)
    };
}

function salvarMeuCard(evento, parceiroId) {
    evento.preventDefault();

    const form = evento.currentTarget;
    const parceirosExtras = carregarParceirosExtras();
    const index = parceirosExtras.findIndex((parceiro) => parceiro.id === parceiroId);
    const existente = index >= 0 ? parceirosExtras[index] : {};
    const dadosCard = coletarDadosCard(form, existente);

    if (!dadosCard) {
        return;
    }

    if (index >= 0) {
        parceirosExtras[index] = dadosCard;
    } else {
        parceirosExtras.push({
            ...dadosCard,
            id: proximoIdParceiro()
        });
    }

    salvarParceirosExtras(parceirosExtras);
    atualizarTela();
}

function excluirMeuCard() {
    const meuCard = obterMeuCard();

    if (!meuCard || !window.confirm("Deseja excluir o seu card?")) {
        return;
    }

    salvarParceirosExtras(carregarParceirosExtras().filter((parceiro) => parceiro.id !== meuCard.id));
    atualizarTela();
}

function montarDestaques() {
    const container = document.getElementById("destaques-container");

    if (!container) {
        return;
    }

    const destaques = dados.parceiros.filter((parceiro) => parceiro.destaque);

    container.innerHTML = destaques.map((parceiro, index) => `
        <div class="carousel-item ${index === 0 ? "active" : ""}">
            ${botaoFavorito(parceiro)}
            <img src="${parceiro.imagem_principal}" class="d-block w-100" alt="${escapeHtml(parceiro.nome)}">
            <div class="carousel-caption">
                <span>${escapeHtml(parceiro.idioma)} - ${escapeHtml(parceiro.nivel)}</span>
                <h3>${escapeHtml(parceiro.nome)}</h3>
                <p>${escapeHtml(parceiro.descricao)}</p>
                <a class="btn btn-talkhub" href="detalhe.html?id=${parceiro.id}">Ver perfil</a>
            </div>
        </div>
    `).join("");

    configurarBotoesFavoritos(container);
}

function montarCards() {
    const container = document.getElementById("cards-container");

    if (!container) {
        return;
    }

    aplicarBuscaEFiltros();
}

function renderizarGradeCards(container, lista, vazio) {
    if (lista.length === 0) {
        container.innerHTML = `
            <div class="col-12">
                <div class="resultado-vazio">
                    <h3>${escapeHtml(vazio.titulo)}</h3>
                    <p>${escapeHtml(vazio.texto)}</p>
                    ${vazio.link ? `<a class="btn btn-talkhub mt-3" href="${vazio.link.href}">${escapeHtml(vazio.link.texto)}</a>` : ""}
                </div>
            </div>
        `;
        return;
    }

    container.innerHTML = lista.map(renderizarCardParceiro).join("");
    configurarBotoesFavoritos(container);
}

function renderizarCardParceiro(parceiro) {
    return `
        <div class="col">
            <div class="card h-100 parceiro-card">
                ${botaoFavorito(parceiro)}
                <img src="${parceiro.imagem_principal}" class="card-img-top" alt="${escapeHtml(parceiro.nome)}">
                <div class="card-body">
                    <span class="badge badge-idioma">${escapeHtml(parceiro.idioma)}</span>
                    <h3 class="card-title">${escapeHtml(parceiro.nome)}</h3>
                    <p class="card-text">${escapeHtml(parceiro.descricao)}</p>
                    <ul class="card-list">
                        <li><strong>Nivel:</strong> ${escapeHtml(parceiro.nivel)}</li>
                        <li><strong>Disponibilidade:</strong> ${escapeHtml(parceiro.disponibilidade)}</li>
                        <li><strong>Cidade:</strong> ${escapeHtml(parceiro.cidade)}</li>
                    </ul>
                </div>
                <div class="card-footer">
                    <a class="btn btn-talkhub w-100" href="detalhe.html?id=${parceiro.id}">Acessar detalhes</a>
                </div>
            </div>
        </div>
    `;
}

function renderizarCards(lista) {
    const container = document.getElementById("cards-container");

    if (!container) {
        return;
    }

    renderizarGradeCards(container, lista, {
        titulo: "Nenhum parceiro encontrado",
        texto: "Tente buscar por outro nome, idioma, interesse ou cidade."
    });
}

function montarPesquisa() {
    const input = document.getElementById("pesquisa-parceiros");
    const botaoLimpar = document.getElementById("limpar-pesquisa");

    if (!input || !botaoLimpar || input.dataset.pronto === "true") {
        return;
    }

    input.dataset.pronto = "true";
    input.value = termoPesquisa;

    input.addEventListener("input", () => {
        termoPesquisa = input.value;
        aplicarBuscaEFiltros();
    });

    botaoLimpar.addEventListener("click", () => {
        termoPesquisa = "";
        idiomaAtivo = "Todos";
        input.value = "";
        montarFiltros();
        aplicarBuscaEFiltros();
        input.focus();
    });
}

function textoPesquisavel(parceiro) {
    return [
        parceiro.nome,
        parceiro.idioma,
        parceiro.nivel,
        parceiro.disponibilidade,
        parceiro.cidade,
        parceiro.contato,
        parceiro.descricao,
        parceiro.objetivo,
        parceiro.interesses,
        parceiro.formato,
        ...(parceiro.fotos || []).map((foto) => foto.titulo)
    ].join(" ");
}

function aplicarBuscaEFiltros() {
    const termo = normalizar(termoPesquisa.trim());
    const listaFiltrada = dados.parceiros.filter((parceiro) => {
        const passaIdioma = idiomaAtivo === "Todos" || parceiro.idioma === idiomaAtivo;
        const passaPesquisa = !termo || normalizar(textoPesquisavel(parceiro)).includes(termo);

        return passaIdioma && passaPesquisa;
    });

    renderizarCards(listaFiltrada);
}

function montarFiltros() {
    const filtrosContainer = document.getElementById("filtros-idioma");

    if (!filtrosContainer) {
        return;
    }

    const idiomas = ["Todos", ...new Set(dados.parceiros.map((parceiro) => parceiro.idioma))];

    if (!idiomas.includes(idiomaAtivo)) {
        idiomaAtivo = "Todos";
    }

    filtrosContainer.innerHTML = idiomas.map((idioma, index) => `
        <button class="filtro-idioma-btn ${idioma === idiomaAtivo ? "ativo" : ""}" type="button" data-idioma="${escapeHtml(idioma)}">
            ${escapeHtml(idioma)}
        </button>
    `).join("");

    filtrosContainer.querySelectorAll(".filtro-idioma-btn").forEach((botao) => {
        botao.addEventListener("click", () => {
            filtrosContainer.querySelectorAll(".filtro-idioma-btn").forEach((item) => {
                item.classList.remove("ativo");
            });

            botao.classList.add("ativo");

            idiomaAtivo = botao.dataset.idioma;
            aplicarBuscaEFiltros();
        });
    });
}

function montarPaginaFavoritos() {
    const container = document.getElementById("favoritos-container");

    if (!container) {
        return;
    }

    const usuario = usuarioLogado();

    if (!usuario) {
        container.innerHTML = `
            <div class="meu-card-box">
                <p>Entre na sua conta para visualizar seus cards favoritos.</p>
                <button class="btn btn-talkhub" type="button" data-auth-view="login">Fazer login</button>
                <button class="btn btn-outline-talkhub" type="button" data-auth-view="cadastro">Criar conta</button>
            </div>
        `;

        container.querySelectorAll("[data-auth-view]").forEach((botao) => {
            botao.addEventListener("click", () => abrirModalAuth(botao.dataset.authView));
        });
        return;
    }

    const favoritosIds = idsFavoritosUsuario();
    const favoritos = dados.parceiros.filter((parceiro) => favoritosIds.includes(parceiro.id));

    container.innerHTML = `
        <div class="row row-cols-1 row-cols-md-2 row-cols-xl-3 g-4" id="favoritos-cards"></div>
    `;

    renderizarGradeCards(document.getElementById("favoritos-cards"), favoritos, {
        titulo: "Nenhum favorito ainda",
        texto: "Use o icone de estrela nos cards para montar sua lista.",
        link: {
            href: "index.html#parceiros",
            texto: "Ver parceiros"
        }
    });
}

function montarDetalhe() {
    const detalheContainer = document.getElementById("detalhe-container");
    const fotosContainer = document.getElementById("fotos-container");

    if (!detalheContainer || !fotosContainer) {
        return;
    }

    const params = new URLSearchParams(window.location.search);
    const id = Number(params.get("id"));
    const parceiro = dados.parceiros.find((item) => item.id === id);

    if (!parceiro) {
        detalheContainer.innerHTML = `
            <div class="not-found">
                <h1>Parceiro nao encontrado</h1>
                <p>Volte ao mural para escolher um perfil cadastrado.</p>
                <a class="btn btn-talkhub" href="index.html#parceiros">Voltar ao mural</a>
            </div>
        `;
        fotosContainer.innerHTML = "";
        return;
    }

    detalheContainer.innerHTML = `
        <div class="detalhe-grid">
            <div class="detalhe-img">
                <img src="${parceiro.imagem_principal}" alt="${escapeHtml(parceiro.nome)}">
            </div>
            <div class="detalhe-info">
                <p class="section-label">Perfil de conversacao</p>
                <h1>${escapeHtml(parceiro.nome)}</h1>
                <p class="lead">${escapeHtml(parceiro.descricao)}</p>

                <div class="info-grid">
                    <div>
                        <span>Idioma</span>
                        <strong>${escapeHtml(parceiro.idioma)}</strong>
                    </div>
                    <div>
                        <span>Nivel</span>
                        <strong>${escapeHtml(parceiro.nivel)}</strong>
                    </div>
                    <div>
                        <span>Disponibilidade</span>
                        <strong>${escapeHtml(parceiro.disponibilidade)}</strong>
                    </div>
                    <div>
                        <span>Cidade</span>
                        <strong>${escapeHtml(parceiro.cidade)}</strong>
                    </div>
                    <div>
                        <span>Interesses</span>
                        <strong>${escapeHtml(parceiro.interesses)}</strong>
                    </div>
                    <div>
                        <span>Contato</span>
                        <strong>${escapeHtml(parceiro.contato)}</strong>
                    </div>
                </div>

                <div class="objetivo-box">
                    <h2>Objetivo</h2>
                    <p>${escapeHtml(parceiro.objetivo)}</p>
                    <h2>Formato de pratica</h2>
                    <p>${escapeHtml(parceiro.formato)}</p>
                </div>

                ${usuarioLogado() ? `
                    <div class="detalhe-actions">
                        ${botaoFavorito(parceiro)}
                        ${podeEditar(parceiro) ? `<button class="btn btn-outline-talkhub" type="button" id="btn-editar-card">Editar meu card</button>` : ""}
                    </div>
                ` : ""}
            </div>
        </div>
    `;

    fotosContainer.innerHTML = parceiro.fotos.map((foto) => `
        <div class="col">
            <div class="card h-100 foto-card">
                <img src="${foto.imagem}" class="card-img-top" alt="${escapeHtml(foto.titulo)}">
                <div class="card-body">
                    <h3 class="card-title">${escapeHtml(foto.titulo)}</h3>
                </div>
            </div>
        </div>
    `).join("");

    const botaoEditar = document.getElementById("btn-editar-card");

    if (botaoEditar) {
        botaoEditar.addEventListener("click", () => abrirFormularioEdicao(parceiro));
    }

    configurarBotoesFavoritos(detalheContainer);
}

function abrirFormularioEdicao(parceiro) {
    const detalheContainer = document.getElementById("detalhe-container");

    detalheContainer.insertAdjacentHTML("beforeend", `
        ${montarFormularioCard(parceiro, "Editar meu card", "Salvar alteracoes", {
            formId: "edit-card-form",
            cancelId: "cancelar-edicao"
        })}
    `);

    document.getElementById("btn-editar-card").disabled = true;
    document.getElementById("cancelar-edicao").addEventListener("click", atualizarTela);
    document.getElementById("edit-card-form").addEventListener("submit", (evento) => salvarEdicaoCard(evento, parceiro.id));
    document.getElementById("edit-card-form").scrollIntoView({ behavior: "smooth", block: "start" });
}

function salvarEdicaoCard(evento, parceiroId) {
    evento.preventDefault();

    const form = evento.currentTarget;
    const parceirosExtras = carregarParceirosExtras();
    const index = parceirosExtras.findIndex((parceiro) => parceiro.id === parceiroId);

    if (index === -1) {
        return;
    }

    const dadosCard = coletarDadosCard(form, parceirosExtras[index]);

    if (!dadosCard) {
        return;
    }

    parceirosExtras[index] = dadosCard;
    salvarParceirosExtras(parceirosExtras);
    atualizarTela();
}

function atualizarTela() {
    dados = {
        parceiros: carregarParceiros()
    };

    renderizarTopoUsuario();
    montarDestaques();
    montarPesquisa();
    montarFiltros();
    montarCards();
    montarMeuCard();
    montarPaginaFavoritos();
    montarDetalhe();
}

montarTopoUsuario();
montarDestaques();
montarPesquisa();
montarFiltros();
montarCards();
montarMeuCard();
montarPaginaFavoritos();
montarDetalhe();
