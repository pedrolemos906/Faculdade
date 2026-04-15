// Dados simulados
const featuredPosts = [
  { title: "Primeiro Nível", content: "Minha primeira conquista nessa jornada..." },
  { title: "Desafio da Semana", content: "Como enfrentei obstáculos e o que aprendi..." }
];

const recentPosts = [
  { title: "Sonhos em construção", content: "Meus objetivos para o próximo nível..." },
  { title: "Conquistas recentes", content: "Vitórias que marcaram minha jornada..." },
  { title: "Desafios enfrentados", content: "Como superei obstáculos e aprendi..." }
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
