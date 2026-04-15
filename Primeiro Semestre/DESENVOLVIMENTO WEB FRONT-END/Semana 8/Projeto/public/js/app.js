// =====================
// 🎮 DADOS DO PROJETO
// =====================

// 🏆 Conquistas
const achievements = [
    { nome: "Ler 5 livros", concluido: true },
    { nome: "Treinar 30 dias", concluido: false },
    { nome: "Criar projeto web", concluido: true },
    { nome: "Estudar JS", concluido: false },
    { nome: "Fazer portfólio", concluido: true }
];

// 📊 Progresso
const progressList = [
    { nome: "Shape", valor: 70 },
    { nome: "Estudos", valor: 60 },
    { nome: "Projeto", valor: 80 }
];

// 📝 Posts
const posts = [
    {
        titulo: "Review: Livro Hábitos Atômicos",
        descricao: "Aprendi muito sobre consistência e disciplina.",
        tipo: "📚"
    },
    {
        titulo: "Review: Elden Ring",
        descricao: "Um dos jogos mais desafiadores que já joguei.",
        tipo: "🎮"
    },
    {
        titulo: "Minha evolução nos estudos",
        descricao: "Como estou melhorando minha rotina.",
        tipo: "🧠"
    }
];


// =====================
// 🏆 RENDER CONQUISTAS
// =====================

const badgeContainer = document.querySelector(".badges");

achievements.forEach(a => {
    const div = document.createElement("div");
    div.classList.add("badge");

    if (a.concluido) {
        div.style.background = "#FBD000";
        div.title = a.nome;
    } else {
        div.style.background = "#ccc";
        div.title = "Em progresso: " + a.nome;
    }

    badgeContainer.appendChild(div);
});


// =====================
// 📊 RENDER PROGRESSO
// =====================

const progressContainer = document.querySelector(".progress-container");

progressList.forEach(p => {
    const box = document.createElement("div");

    const label = document.createElement("p");
    label.textContent = p.nome + " - " + p.valor + "%";

    const bar = document.createElement("div");
    bar.classList.add("progress");

    const span = document.createElement("span");
    span.style.width = p.valor + "%";

    bar.appendChild(span);

    box.appendChild(label);
    box.appendChild(bar);

    progressContainer.appendChild(box);
});


// =====================
// 📝 RENDER POSTS
// =====================

const postContainer = document.querySelector(".posts-container");

posts.forEach(p => {
    const post = document.createElement("div");
    post.classList.add("post");

    const thumb = document.createElement("div");
    thumb.classList.add("thumb");
    thumb.textContent = p.tipo;

    const content = document.createElement("div");

    const title = document.createElement("h3");
    title.textContent = p.titulo;

    const desc = document.createElement("p");
    desc.textContent = p.descricao;

    content.appendChild(title);
    content.appendChild(desc);

    post.appendChild(thumb);
    post.appendChild(content);

    postContainer.appendChild(post);
});