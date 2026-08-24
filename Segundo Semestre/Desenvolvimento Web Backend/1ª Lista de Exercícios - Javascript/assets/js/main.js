// questão 1

let btnExe1 = document.getElementById("btnExe1");

btnExe1.addEventListener("click", function () {

    let nome_usuario = document.getElementById("nome_usuario").value;
    document.getElementById("res1").innerText = "Seja bem-vindo, " + nome_usuario + "!";

});


// questão 2

let btnExe2 = document.getElementById("btnExe2");

btnExe2.addEventListener("click", function () {

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
