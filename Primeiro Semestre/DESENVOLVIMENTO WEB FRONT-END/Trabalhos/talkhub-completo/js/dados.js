// ================================================
// dados.js
// Dados mockados do TalkHub.
// Em um projeto real, esses dados viriam de um
// banco de dados via API. Por enquanto, definimos
// aqui como variáveis JavaScript para simular.
// ================================================


// ── Usuário logado ───────────────────────────────
// Simula os dados de quem está na sessão atual.
// No futuro virá do Supabase após o login.

const usuarioLogado = {
  id: 0,
  nome: "Ana Beatriz",
  iniciais: "AB",
  corAvatar: "avatar--roxo",
  idiomaNativo: ["pt-BR"],
  idiomasPraticar: ["en", "es"],
  disponibilidade: [
    "seg-manha", "seg-noite",
    "ter-tarde", "ter-noite",
    "qua-manha",
    "qui-tarde", "qui-noite",
    "sex-noite"
  ]
};


// ── Parceiros disponíveis ────────────────────────
// Lista de usuários que o sistema encontrou
// como compatíveis com o usuário logado.
// Cada objeto representa um parceiro em potencial.

const parceiros = [
  {
    id: 1,
    nome: "James Carter",
    iniciais: "JC",
    corAvatar: "avatar--verde",
    idiomaNativo: ["en"],
    idiomasPraticar: ["pt-BR"],
    disponibilidade: ["seg-noite", "qua-noite", "qui-noite", "sex-noite"],
    coincidencias: 4  // quantos slots batem com o usuário logado
  },
  {
    id: 2,
    nome: "Sofia Kraus",
    iniciais: "SK",
    corAvatar: "avatar--laranja",
    idiomaNativo: ["en", "de"],
    idiomasPraticar: ["pt-BR", "es"],
    disponibilidade: ["ter-tarde", "ter-noite", "qui-tarde", "qui-noite"],
    coincidencias: 2
  },
  {
    id: 3,
    nome: "Marco Levi",
    iniciais: "ML",
    corAvatar: "avatar--roxo",
    idiomaNativo: ["es", "it"],
    idiomasPraticar: ["pt-BR", "en"],
    disponibilidade: ["sex-noite"],
    coincidencias: 1
  },
  {
    id: 4,
    nome: "Claire Laurent",
    iniciais: "CL",
    corAvatar: "avatar--azul",
    idiomaNativo: ["fr"],
    idiomasPraticar: ["pt-BR", "en"],
    disponibilidade: ["qua-manha", "sex-manha", "sex-tarde"],
    coincidencias: 3
  }
];


// ── Nomes legíveis dos idiomas ───────────────────
// Usamos esse objeto para converter o código
// do idioma (ex: "en") para o nome exibido
// na tela (ex: "🇺🇸 Inglês").

const nomesIdiomas = {
  "en":    "🇺🇸 Inglês",
  "es":    "🇪🇸 Espanhol",
  "fr":    "🇫🇷 Francês",
  "de":    "🇩🇪 Alemão",
  "it":    "🇮🇹 Italiano",
  "ja":    "🇯🇵 Japonês",
  "ko":    "🇰🇷 Coreano",
  "pt-BR": "🇧🇷 Português"
};


// ── Horários disponíveis para o modal ───────────
// Lista de slots que aparecem no modal de
// agendamento quando o usuário clica em "Agendar".

const slotsDisponiveis = [
  { valor: "seg-19h", rotulo: "Seg 19h", destaque: true  },
  { valor: "qua-19h", rotulo: "Qua 19h", destaque: false },
  { valor: "qua-20h", rotulo: "Qua 20h", destaque: false },
  { valor: "qui-19h", rotulo: "Qui 19h", destaque: false },
  { valor: "qui-20h", rotulo: "Qui 20h", destaque: false },
  { valor: "sex-19h", rotulo: "Sex 19h", destaque: false }
];
