const formulario =
document.getElementById("formulario");

formulario.addEventListener("submit", function(event){

    event.preventDefault();

    const nome =
    document.getElementById("nome").value;

    const idioma =
    document.getElementById("idioma").value;

    const nivel =
    document.getElementById("nivel").value;

    const disponibilidade =
    document.getElementById("disponibilidade").value;

    const contato =
    document.getElementById("contato").value;

    const interesses =
    document.getElementById("interesses").value;

    const url =
    `index.html?nome=${encodeURIComponent(nome)}
    &idioma=${encodeURIComponent(idioma)}
    &nivel=${encodeURIComponent(nivel)}
    &disponibilidade=${encodeURIComponent(disponibilidade)}
    &contato=${encodeURIComponent(contato)}
    &interesses=${encodeURIComponent(interesses)}`;

    window.location.href =
    url.replace(/\s+/g,"");
});