<?php
$g = $_POST['gasolina'] ?? 0;
$a = $_POST['alcool'] ?? 0;
if ($g <= 0 || $a <= 0) { echo "Valores inválidos. <a href='index.html'>Voltar</a>"; exit; }
$melhor = ($a <= $g * 0.7) ? "Álcool" : "Gasolina";
echo "<h1>Compensa abastecer com: $melhor</h1>";
echo "<p>Álcool: R$ $a | Gasolina: R$ $g</p>";
echo "<a href='index.html'>Calcular novamente</a>";
?>