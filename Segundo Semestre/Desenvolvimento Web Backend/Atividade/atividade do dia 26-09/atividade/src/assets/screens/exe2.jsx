import { useState } from "react";

//Components
import Header from "../components/header";
import Descricao from "../components/descricao";
import Footer from "../components/footer";

const Exe2 = () => {
    
    const [tempo, setTempo] = useState(0);
    const [distancia, setDistancia] = useState(0);
    const [velocidade, setVelocidade] = useState(0);

    function calcularVelocidade() {

        setVelocidade(parseFloat(distancia) / parseFloat(tempo));
    }


return (
    <div>
        <Header titulo = "Exercicio 2"/>
        <Descricao descricao = "O conteudo esta na lista"/>
        <h3>Informe o tempo: </h3>
        <input
            type="text"
            value={tempo}
            onChange={(e) => setTempo(e.target.value)}
        />
        <h3>Informe a distância: </h3>
        <input
            type="text"
            value={distancia}
            onChange={(e) => setDistancia(e.target.value)}
        />
        <button onclick = {() => {calcularVelocidade()}}>
            Calcular velocidade
        </button>

        <h3>Velocidade: {velocidade}</h3>
        <Footer/>
    </div>
)

}


export default Exe2;