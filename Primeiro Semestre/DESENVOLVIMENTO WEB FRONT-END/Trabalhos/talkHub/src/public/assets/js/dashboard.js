// ================================================
// dashboard.js
// Depende de: dados.js (carregado antes no HTML)
// Controla: sidebar, cards, filtros, modal, confirmação
// ================================================


// ════════════════════════════════════════════════
// 1. SIDEBAR — preenche com dados do usuário logado
// ════════════════════════════════════════════════

// Pega os elementos da sidebar
const sidebarNome   = document.getElementById('sidebar-nome');
const sidebarIdioma = document.getElementById('sidebar-idioma');
const sidebarAvatar = document.getElementById('sidebar-avatar');

// Preenche com os dados do usuarioLogado (de dados.js)
sidebarNome.textContent   = usuarioLogado.nome;
sidebarAvatar.textContent = usuarioLogado.iniciais;
sidebarAvatar.classList.add(usuarioLogado.corAvatar);

// Monta o texto "praticando inglês, espanhol"
const nomesIdiomaPraticar = usuarioLogado.idiomasPraticar
  .map(function (codigo) { return nomesIdiomas[codigo]; })
  .join(', ');
sidebarIdioma.textContent = 'praticando ' + nomesIdiomaPraticar;


// ════════════════════════════════════════════════
// 2. CARDS — gera os cards a partir dos dados
// ════════════════════════════════════════════════

const listaMatches = document.getElementById('lista-matches');

// Percorre o array de parceiros e cria um card para cada um
parceiros.forEach(function (parceiro) {

  // Monta o texto dos idiomas nativos do parceiro
  const idiomasNativos = parceiro.idiomaNativo
    .map(function (codigo) { return nomesIdiomas[codigo]; })
    .join(' e ');

  // Pega o primeiro idioma que o parceiro quer praticar
  // para usar como filtro
  const idiomaPraticar = parceiro.idiomasPraticar[0];

  // Monta o HTML do card usando template literal (crase)
  // Template literal permite escrever HTML com variáveis dentro: ${variavel}
  const cardHTML = `
    <div class="match-card" data-idioma="${idiomaPraticar}">

      <div class="avatar ${parceiro.corAvatar}">${parceiro.iniciais}</div>

      <div class="match-card__info">
        <h2 class="match-card__nome">${parceiro.nome}</h2>
        <div class="match-card__meta">
          <span>nativo em ${idiomasNativos}</span>
          <span>🕐 ${formatarDisponibilidade(parceiro.disponibilidade)}</span>
        </div>
      </div>

      <span class="match-card__slots">coincide ${parceiro.coincidencias} horário(s)</span>

      <button class="btn btn-primary" onclick="abrirModal(${parceiro.id})">
        Agendar
      </button>

    </div>
  `;

  // innerHTML += adiciona o HTML gerado dentro da lista
  listaMatches.innerHTML += cardHTML;
});


// Formata a disponibilidade para exibir no card
// Recebe ex: ["seg-noite", "qua-noite"] → "seg, qua (noite)"
function formatarDisponibilidade(slots) {
  if (slots.length === 0) return 'sem horários';

  // Pega só o primeiro slot para exibir resumido
  const primeiro = slots[0];
  const partes   = primeiro.split('-');  // ["seg", "noite"]
  const dia      = partes[0];
  const periodo  = partes[1];

  const sufixo = slots.length > 1 ? ' +' + (slots.length - 1) : '';
  return dia + ' (' + periodo + ')' + sufixo;
}


// ════════════════════════════════════════════════
// 3. FILTROS — filtra os cards por idioma
// ════════════════════════════════════════════════

const botoesFiltro = document.querySelectorAll('.filtro');

botoesFiltro.forEach(function (botao) {
  botao.addEventListener('click', function () {

    // Atualiza o botão ativo
    botoesFiltro.forEach(function (b) { b.classList.remove('filtro--ativo'); });
    botao.classList.add('filtro--ativo');

    const filtroEscolhido = botao.dataset.filtro;

    // Mostra ou esconde cada card
    document.querySelectorAll('.match-card').forEach(function (card) {
      if (filtroEscolhido === 'todos' || card.dataset.idioma === filtroEscolhido) {
        card.classList.remove('oculto');
      } else {
        card.classList.add('oculto');
      }
    });
  });
});


// ════════════════════════════════════════════════
// 4. MODAL DE AGENDAMENTO
// ════════════════════════════════════════════════

const modalFundo = document.getElementById('modal-fundo');

// Abre o modal para o parceiro com o id informado
function abrirModal(parceiroId) {

  // Encontra o parceiro no array pelo id
  // .find percorre o array e retorna o primeiro que satisfaz a condição
  const parceiro = parceiros.find(function (p) { return p.id === parceiroId; });

  if (!parceiro) return; // segurança: não faz nada se não encontrar

  // Preenche o modal com os dados do parceiro
  document.getElementById('modal-nome').textContent   = parceiro.nome;
  document.getElementById('modal-idioma').textContent =
    'praticando ' + parceiro.idiomasPraticar.map(c => nomesIdiomas[c]).join(', ');

  const avatarEl       = document.getElementById('modal-avatar');
  avatarEl.textContent = parceiro.iniciais;
  avatarEl.className   = 'avatar ' + parceiro.corAvatar;

  // Guarda o id do parceiro no modal para usar ao confirmar
  modalFundo.dataset.parceiroId = parceiroId;

  // Gera os slots de horário
  renderizarSlots();

  // Exibe o modal
  modalFundo.classList.remove('oculto');
}


// Gera os botões de horário dentro do modal
function renderizarSlots() {
  const container = document.getElementById('modal-slots');
  container.innerHTML = ''; // limpa os slots anteriores

  slotsDisponiveis.forEach(function (slot) {
    const btn = document.createElement('button'); // cria um <button>
    btn.textContent = slot.rotulo;
    btn.className   = 'slot' + (slot.destaque ? ' slot--destaque' : '');
    btn.dataset.valor = slot.valor;

    // Ao clicar num slot, marca ele como selecionado
    btn.addEventListener('click', function () {
      document.querySelectorAll('.slot').forEach(function (s) {
        s.classList.remove('slot--selecionado', 'slot--destaque');
      });
      btn.classList.add('slot--selecionado');
    });

    container.appendChild(btn); // insere o botão no HTML
  });
}


// Fecha o modal ao clicar no fundo escuro
modalFundo.addEventListener('click', function (evento) {
  if (evento.target === modalFundo) fecharModal();
});

function fecharModal() {
  modalFundo.classList.add('oculto');
}


// ════════════════════════════════════════════════
// 5. CONFIRMAÇÃO E GERAÇÃO DO LINK
// ════════════════════════════════════════════════

const confirmacaoFundo = document.getElementById('confirmacao-fundo');

function confirmarAgendamento() {

  const nome    = document.getElementById('modal-nome').textContent;
  const idioma  = document.getElementById('modal-idioma').textContent;

  // Pega o slot selecionado (ou o primeiro como padrão)
  const slotSelecionado = document.querySelector('.slot--selecionado') ||
                          document.querySelector('.slot');
  const horario = slotSelecionado ? slotSelecionado.textContent : 'Seg 19h';

  // Texto de resumo da confirmação
  document.getElementById('confirmacao-texto').textContent =
    horario + ' · ' + idioma + ' · 45 minutos com ' + nome;

  // Gera link do Jitsi com base nos dados
  const slugNome    = nome.toLowerCase().replace(/\s+/g, '-');
  const slugHorario = horario.toLowerCase().replace(/\s+/g, '-');
  const link = 'meet.jit.si/talkhub-' + slugNome + '-' + slugHorario;

  document.getElementById('confirmacao-link').textContent = link;

  fecharModal();
  confirmacaoFundo.classList.remove('oculto');
}


function fecharConfirmacao() {
  confirmacaoFundo.classList.add('oculto');
}


function copiarLink() {
  const link = document.getElementById('confirmacao-link').textContent;

  navigator.clipboard.writeText(link).then(function () {
    const btn = document.querySelector('.confirmacao__copiar');
    btn.textContent = 'Copiado ✓';
    setTimeout(function () { btn.textContent = 'Copiar'; }, 2000);
  });
}
