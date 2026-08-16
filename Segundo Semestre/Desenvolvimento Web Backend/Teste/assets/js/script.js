let peso = 0;
let altura = 0;
let imc = 0;

let bottonCalcular = document.getElementById("calcular");
calcular.addEventListener("click", function() {

        peso = parseFloat(document.getElementById("peso").value);
        altura = parseFloat(document.getElementById("altura").value);

        imc = peso / (altura * altura);

        document.getElementById("resultado").innerText = "Seu IMC é: " + imc;

});