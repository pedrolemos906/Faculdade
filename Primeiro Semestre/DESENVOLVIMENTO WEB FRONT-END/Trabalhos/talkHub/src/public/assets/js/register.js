// ================================================
// register.js
// Controla o formulário de cadastro em 2 passos.
// ================================================


// ── Elementos do HTML ────────────────────────────
const passo1          = document.getElementById('passo-1');
const passo2          = document.getElementById('passo-2');
const indicadorPasso1 = document.getElementById('indicador-passo-1');
const indicadorPasso2 = document.getElementById('indicador-passo-2');
const btnAvancar      = document.getElementById('btn-avancar');
const btnVoltar       = document.getElementById('btn-voltar');


// ════════════════════════════════════════════════
// NAVEGAÇÃO ENTRE PASSOS
// ════════════════════════════════════════════════

btnAvancar.addEventListener('click', function () {

  // Valida se os campos do passo 1 estão preenchidos
  const nome   = document.getElementById('nome').value.trim();
  const email  = document.getElementById('email-cadastro').value.trim();
  const senha  = document.getElementById('senha-cadastro').value;
  const idioma = document.getElementById('idioma-nativo').value;

  if (!nome || !email || !senha || !idioma) {
    alert('Preencha todos os campos antes de continuar.');
    return; // interrompe a função aqui se inválido
  }

  if (senha.length < 8) {
    alert('A senha precisa ter pelo menos 8 caracteres.');
    return;
  }

  irParaPasso(2);
});


btnVoltar.addEventListener('click', function () {
  irParaPasso(1);
});


// Alterna a visibilidade entre os dois passos
function irParaPasso(numero) {
  if (numero === 2) {
    passo1.classList.add('oculto');
    passo2.classList.remove('oculto');
    indicadorPasso1.classList.remove('progresso__passo--ativo');
    indicadorPasso2.classList.add('progresso__passo--ativo');
  } else {
    passo2.classList.add('oculto');
    passo1.classList.remove('oculto');
    indicadorPasso2.classList.remove('progresso__passo--ativo');
    indicadorPasso1.classList.add('progresso__passo--ativo');
  }
  window.scrollTo({ top: 0, behavior: 'smooth' });
}


// ════════════════════════════════════════════════
// COLETA DOS DADOS DO FORMULÁRIO
// Monta um objeto com tudo que o usuário preencheu.
// No futuro esse objeto será enviado ao Supabase.
// ════════════════════════════════════════════════

const formPasso2 = document.querySelector('#passo-2 form');

formPasso2.addEventListener('submit', function (evento) {

  evento.preventDefault(); // impede recarregar a página

  // Dados do passo 1
  const dadosPessoais = {
    nome:         document.getElementById('nome').value.trim(),
    email:        document.getElementById('email-cadastro').value.trim(),
    idiomaNativo: document.getElementById('idioma-nativo').value
  };

  // Idiomas marcados como chips
  // querySelectorAll + Array.from + .map extraem só os values
  const idiomasEscolhidos = Array.from(
    document.querySelectorAll('.chip__input:checked')
  ).map(function (chip) { return chip.value; });

  // Slots marcados na grade de disponibilidade
  const disponibilidade = Array.from(
    document.querySelectorAll('.grade__input:checked')
  ).map(function (slot) { return slot.id; });

  // Objeto final com todos os dados
  const novoUsuario = {
    ...dadosPessoais,
    idiomasPraticar: idiomasEscolhidos,
    disponibilidade: disponibilidade
  };

  // Mostra no console para conferir durante o desenvolvimento
  console.log('Novo usuário cadastrado:', novoUsuario);

  // TODO: enviar novoUsuario ao Supabase
  window.location.href = 'dashboard.html';
});
