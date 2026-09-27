import { useState } from "react";

//Components
import Header from "../components/header";
import Descricao from "../components/descricao";
import Footer from "../components/footer";

const Exe1 = () => {
    
    const [nome, setNome] = useState("");


return (
    <div>
        <Header titulo = "Exercicio 1"/>
        <Descricao descricao = "O conteudo esta na lista"/>
        <input
            type="text"
            value={nome}
            onChange={(e) => setNome(e.target.value)}
        />
        <h3>Seja bem vindo, {nome}!</h3>
        <Footer/>
    </div>
)

}


export default Exe1;