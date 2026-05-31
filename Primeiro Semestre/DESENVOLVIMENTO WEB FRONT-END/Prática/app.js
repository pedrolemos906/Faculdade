let botao = document.getElementById("btnClique");
let paragrafo = document.getElementById("mensagem");

botao.addEventListener("click",function() {
    paragrafo.textContent = "Você clicou no botão";
});