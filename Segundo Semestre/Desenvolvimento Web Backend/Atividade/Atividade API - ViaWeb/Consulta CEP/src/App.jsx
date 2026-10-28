//Screens
import ConsultaCep from './assets/screens/ConsultaCep';

const App = () => {
  return (
    <div>
      <ConsultaCep/>
    </div>
  );
}

export default App;

export default App;


  const App = () => {

    function consultarCEP() {
      fetch(`https://viacep.com.br/ws/${cep}/json/`)
        .then((response) => response.json())
        .then((data) => {
          setLocalidade(data.localidade);
          setBairro(data.bairro);
          setLogradouro(data.logradouro);
          setEstado(data.estado);
          setRegiao(data.regiao);
    });
  }


  const App = () => {
    return (
      <>
      <header titulo="consumer API" versao="1.0"></header>
      <input 
        type="text" 
        value={cep}
        onChange={(e) => setCep(e.target.value)}
        />
      <input type="button" value="Consultar" onClick={()=> consultarCEP()}/>
      <h3> O endereço é: {logradouro + ", " + bairro + ", " + localidade + ", " + estado}</h3>
      <footer/>
      </>
    );
  };