function criarCard(usuario){

    return `
        <div class="card">

            <h3>${usuario.nome}</h3>

            <p>
                <strong>Idioma:</strong>
                ${usuario.idioma}
            </p>

            <p>
                <strong>Nível:</strong>
                ${usuario.nivel}
            </p>

            <p>
                <strong>Disponibilidade:</strong>
                ${usuario.disponibilidade}
            </p>

            <p>
                <strong>Contato:</strong>
                ${usuario.contato}
            </p>

            <p>
                <strong>Interesses:</strong>
                ${usuario.interesses || "-"}
            </p>

        </div>
    `;
}