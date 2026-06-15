let usuarios = [];

const params =
new URLSearchParams(window.location.search);

async function carregarUsuarios() {

    const resposta =
        await fetch("data/usuarios.json");

    usuarios =
        await resposta.json();

    renderizarCards(usuarios);
}

carregarUsuarios();

const container =
document.getElementById("cards-container");

function renderizarCards(lista){

    container.innerHTML = "";

    lista.forEach(usuario => {

        container.innerHTML +=
        criarCard(usuario);

    });

}

renderizarCards(usuarios);

const botoesFiltro =
document.querySelectorAll(".filtro-btn");

botoesFiltro.forEach(botao => {

    botao.addEventListener("click", () => {

        botoesFiltro.forEach(btn => {

            btn.classList.remove(
                "filtro-ativo"
            );

        });

        botao.classList.add(
            "filtro-ativo"
        );

        const idioma =
        botao.dataset.idioma;

        if(idioma === "Todos"){

            renderizarCards(
                usuarios
            );

            return;
        }

        const filtrados =
        usuarios.filter(usuario => {

            return (
                usuario.idioma === idioma
            );

        });

        renderizarCards(
            filtrados
        );

    });

});