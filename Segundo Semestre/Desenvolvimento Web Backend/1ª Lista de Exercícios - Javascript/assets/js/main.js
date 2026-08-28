// questão 1

let btn1 = document.getElementById("btn1");

btn1.addEventListener("click", function () {

    let nome_usuario = document.getElementById("nome_usuario").value;
    document.getElementById("res1").innerText = "Seja bem-vindo, " + nome_usuario + "!";

});


// questão 2

let btn2 = document.getElementById("btn2");

btn2.addEventListener("click", function () {

    let valora = parseFloat(document.getElementById("valora").value);
    let valorb = parseFloat(document.getElementById("valorb").value);
    let operacao = document.getElementById("operacao").value;
    
        switch (operacao) {
            case "+":
                document.getElementById("res2").innerText = "Resultado: " + (valora + valorb);
                break;
            case "-":
                document.getElementById("res2").innerText = "Resultado: " + (valora - valorb);
                break;
            case "*":
                document.getElementById("res2").innerText = "Resultado: " + (valora * valorb);
                break;
            case "/":
                if (valorb !== 0) {
                    document.getElementById("res2").innerText = "Resultado: " + (valora / valorb);
                } else {
                    document.getElementById("res2").innerText = "Erro: Divisão por zero não é permitida.";
                }
                break;
            default:
                document.getElementById("res2").innerText = "Operação inválida.";
        }
    
});



// questão 3

let btn3 = document.getElementById("btn3");

btn3.addEventListener("click", function () {

    let distancia = parseFloat(document.getElementById("distancia_percorrida").value);
    let tempo = parseFloat(document.getElementById("tempo_gasto").value);

        if (tempo > 0) {
            let velocidade = distancia / tempo;
            document.getElementById("res3").innerText = velocidade + " Km/s";
        }

        else {
            document.getElementById("res3").innerText = "Erro: O tempo deve ser maior que zero.";
        }

});



// questão 4
let btn4 = document.getElementById("btn4");

btn4.addEventListener("click", function () {
    let fahrenheit = parseFloat(document.getElementById("fahrenheit").value);
    let ceusius = (fahrenheit - 32) * 5/9;
    document.getElementById("res4").innerText = ceusius + " °C";

});



// Questão 5

let btn5 = document.getElementById("btn5");

btn5.addEventListener("click", function () {
    let litros = parseFloat(document.getElementById("litros").value);
    let receita = litros * 0.50;
    let lucro = receita * 0.70;
    document.getElementById("res5").innerText = "Lucro: R$ " + lucro.toFixed(2);
});



// questao 6

let btn6 = document.getElementById("btn6");

btn6.addEventListener("click", function () {
    let resultado = 7;
    for (let i = 14; i <= 1000; i += 7) {

        resultado += ", " + i;

    }
    document.getElementById("res6").innerText = "Múltiplos de 7 entre 0 e 1000: " + resultado;
});



// questao 7

let btn7 = document.getElementById("btn7");

btn7.addEventListener("click", function () {

    let primeiro_valor = parseFloat(document.getElementById("primeiro_valor").value);
    let segundo_valor = parseFloat(document.getElementById("segundo_valor").value);
        let maior = primeiro_valor
        let menor = segundo_valor

        if (primeiro_valor < segundo_valor) {
            maior = segundo_valor;
            menor = primeiro_valor;
        }

        document.getElementById("res7").innerText = "Maior: " + maior + ", Menor: " + menor;
});



// questao 8

let btn8 = document.getElementById("btn8");

btn8.addEventListener("click", function () {
    let numeros_aleatorios = [];
    for (let i = 1; i <= 5; i++) {
        let numero_aleatorio = Math.floor(Math.random() * 11);
        numeros_aleatorios.push(numero_aleatorio);
    }
    document.getElementById("res8").innerText = "Números aleatórios: " + numeros_aleatorios.join(", ");
});



// questao 9

let btn9 = document.getElementById("btn9");

btn9.addEventListener("click", function () {
    let raio = parseFloat(document.getElementById("raio").value);
    let circunferencia = 2 * 3.14 * raio;
    document.getElementById("res9").innerText = "Circunferência: " + circunferencia.toFixed(2);
});


// qustao 10

let btn10 = document.getElementById("btn10");

btn10.addEventListener("click", function () {
    let dataAtual = new Date();
    let data = dataAtual.toLocaleDateString("pt-BR");
    let hora = dataAtual.toLocaleTimeString("pt-BR");
    document.getElementById("res10").innerText = "Data: " + data + " | Hora: " + hora;
});