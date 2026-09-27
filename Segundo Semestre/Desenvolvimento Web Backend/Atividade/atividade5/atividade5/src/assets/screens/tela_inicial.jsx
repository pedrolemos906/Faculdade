import Header from "../components/header";
import Footer from "../components/footer";

const TelaInicial = () => {

    const[nome, setNome] = useState("Pedro");

    return (
    <>
        <Header titulo = "Tela inicial" versao = "1.0"/>
            <input 
                type="text" 
                value={nome} 
                onChange={(e) => setNome(e.target.value)} 
            />
            <h5> Seja bem-vindo, {nome}!</h5>
        <Footer descricao = "Todos os direitos reservados"/>
    </>

    );
}