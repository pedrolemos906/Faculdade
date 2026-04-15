// Dados simulados
const featuredPosts = [
  { title: "Comecei um novo Livro!", content: "comecei essa semana a ler o livro 'Nada pode me ferir' escrito por David Goggins. o livro conta a história de superação do único homem a completar o treinamento das forças de elite e se tornar Navy SEAL, Army Ranger e TACP... " },
 
];

const recentPosts = [
  { title: "Comecei um curso novo.", content: "Comecei essa semana o curso de introdução a Computção Quântica..." },
  { title: "Platinei um jogo novo.", content: "Depois de 428 horas de gameplay, finalmente completei o jogo Dark Souls 2..." },
  { title: "Planejando a proxima viajem.", content: "Comecei essa semana o planejamento de uma nova viajem que pretendo fazer esse ano." }
];

// Função para renderizar posts
function renderPosts(posts, containerId) {
  const container = document.getElementById(containerId);
  posts.forEach(post => {
    const card = document.createElement("div");
    card.classList.add("post-card");
    card.innerHTML = `<h3>${post.title}</h3><p>${post.content}</p>`;
    container.appendChild(card);
  });
}

// Renderização
renderPosts(featuredPosts, "featured-posts");
renderPosts(recentPosts, "recent-posts");
