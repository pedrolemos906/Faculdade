#Banco de Dados

##Aulas
## Semana 1 

- Apresentação da unidade curricular.
	Professora Jeanne
- Ementa 
	Conceito de gerenciamento de banco de dados
	Arquitetura de um Sistema de Gerenciamento de Banco de Dados (SGBD)
	Modelos de dados
	Modelo de banco de dados
	Liguagens de definição, manipulação e controle de dados
	Normalização e projetos físicos de banco de dados
	Aspectos de segurança em bancos de dados
 
   
##Semana 2

	Dado = Fato bruto, isolado sem contexto.
	Informação = É o dado processado, organizado, e com contexto.
	Conhecimento = É a informação associada a experiência, análise e capaciade de tomada de decisão.
	
	Banco de Dados = Um banco de dados é uma coleção de dados relacionados.
		 
	Sistema de Gerenciamento de Banco de Dados (SGBD) = Software que incorpora as funções de definição, recuperação e alteração de dados em um banco de dados
	
	Evolução dos SGBDs:
		Modelos:
			Hierarquico = Estrutura em árvore invertida
			Dados Relacionais = Tabelas e SQL
			Orientado a Objetos = Objetos e herança
			Objeto Relacional = Relacional + Objetos
			Não-Relacional = Flexibilidade e escalabilidade
			
- [Material da Aula](./Conteúdo/Aula 2 - Aprendendo a distinguir dados, informação e conhecimento.pdf)
- [Material da Aula](./Conteúdo/Aula 2 - Evolução dos Sistemas de Gerenciamento de Banco de Dados.pdf)
- [Material da Aula](./Conteúdo/Aula 2 - Fundamentos teóricos de bancos de dados - Parte I.pdf)

			
##Semana 3

	- Abordagem isolada de armazenamento de dados
		Redundância de dados:
			• Os arquivos e programas são criados por diferentes desenvolvedores, fazendo com que a mesma informação esteja duplicada em diversos lugares;
			• Custo maior de armazenamento.
		Inconsistência de dados:
			• Várias cópias do mesmo dado não são coerentes.
		Dificuldade de aproveitamento dos dados existentes em novas aplicações:
			• Os dados estão espalhados em vários arquivos que podem estar em diferentes formatos.
		Dificuldade no acesso aos dados:
			• A principal maneira de obter os dados é por meio de programas, havendo poucas ferramentas amigáveis para elaboração de consulta dos usuários.
		Inexistência de controle centralizado dos dados (Administração de dados):
			• Os dados podem ser acessados por muitos programas diferentes que não foram previamente coordenados, ocasionando problemas de segurança e supervisão.
	
	- Vantagens da abordagem integrada de Banco de Dados
		Controle de redundância e inconsistência de dados
		Restrição de acesso não autorizado
		Armazenamento persistente
		Existência de recursos para backup e recuperação
		Imposição de restrições de integridade e de regras de negócio
		Processamento eficiente de consulta
		Múltiplas interfaces: dados vistos de forma mais adequada por aplicação e usuário
		Favorece controle mais centralizado de dados
		
	- Sistema de Banco de Dados
		Conceito: "Sistemas de banco de dados referem-se ao conjunto de dados relacionados e sua respectiva forma de acesso e organização.
		São compostos por uma coleção de dados organizados, uma estrutura lógica determinando a forma como os dados são armazenados, organizados e manipulados, e um software que provê acesso aos dados a usuários e aplicações."
	
	- Conponentes Técnicos
		Compilador de consultas analisa e valida
		Otimizador de consultas
		Pré-compilador e compiladores
		Transações compiladas
		Processador de banco de dados em tempo de execução
		Gerenciador de dados armazenados
	
	- Componentes Humanos
		
		Administrador de Dados (AD)
			Arquiteto
			Conhece profundamente as regras de negócio da empresa
			Define a estrutura de dados
			Administa a discrição da base de dados
			Define padrões para codificação de objetos da base de dados
		
		Administrador de Banco de Dados (DBA)
			Engenheiro
			Administra o SGBD
			Fornecer e controlar as autorizações de acesso ao SGBD
			Gerenciar a base de dados
			Modifica a estrutura de armazenamento e a organização física
		
		Outros Úsuarios	
			Analista de Sistemas / Engenheiro de Software / Desenvolvedor
			Coleta os requisitos e necessidades de informação dos usuários finais
			Desenvolve os sistemas que acessam bancos de dados
			Trabalha conjuntamente com o AD na modelagem do BD
			Trabalha conjuntamente com o DBA na implementação do BD
			
		Úsuario Final
			Acessa o banco de dados para consultas, atualizações, geração de relatórios
			Usuário nível operacional e nível gerencial
			
- Exercícios de fixação 1
- [Lista de Exercício 1](./Atividade/Exercícios de fixação 1.pdf)
- [Respostas da Lista 1](./Atividade/Respostas da lista 1.pdf)


- [Material da Aula](./Conteúdo/Aula 2 - Aprendendo a distinguir dados, informação e conhecimento.pdf)
- [Material da Aula](./Conteúdo/Aula 2 - Evolução dos Sistemas de Gerenciamento de Banco de Dados.pdf)
- [Material da Aula](./Conteúdo/Aula 2 - Fundamentos teóricos de bancos de dados - Parte I.pdf)
			
			
##Semana 4

	- Arquitetura de 3 Camadas
	
		Abstração: refere-se ao grau de detalhamento dos objetos dou conceitos que são descritos no modelo
		
		Níveis de Abstração
			Alto nível = pouco detalhes técnicos
			Baixo nível = Muitos detalhes técnicos
		
		Nível externo
			Compreende vários esquemas externos ou visões dos úsuarios. Cada visão descreve uma parte do banco de dados que seja de interesse para um grupo partilar de usuarios.
			
		Nível conceitual ou lógico
			Descreve a estrutura do banco de dados (Esquema Conceitual) para toda a comunidade de úsuarios, quais dados serão armazenados e os relacionamento entre eles
			
		Nível Físico
			Descreve a Estrutura de armazenamento físico do banco de dados, ou, como os dados serão armazenados
			
	- Etapas de um Projeto de Banco de Dados
				
					
			Etapa 1 = Requisitos 
				Modelo Descritivo
					Primeiro nível de abstração
					Requisitos do negócio
					Descrição em linguagem natural
			
			Etapa 2 Projeto Conceitual
				Modelo conceitual
					Representação gráfica
					Entidades, atributos, relacionamentos
					Modelo Entidade e Relacionamento (MER)
					
			Etapa 3 Projeto Lógico
				Modelo lógico
					Representação formal
					Tabelas, Relacionamentos, Tuplas
					Modelo Relacional, Orientado a objetos...
			
			Etapa 4 Projeto Físico
				Modelo físico
					Scripts de descrição completa das estruturas incluindo índices, chaves, restrições de integridade, etc.
	
	- Propriedades do SGBD: Conclusões
		
		O SGBD facilita o desenvolvimento de novas aplicações
		O principal objetivo de um SGBD é proporcionar um ambiente conveniente e eficiente para armazenar dados e recuperar informações no BD
		
		
		




## Avaliações

| Data | Avaliação | Conteúdo |
| --- | --- | --- |
| 21/09 | Prova 1 | Conteúdo da Unidade 1 e 2 |
| 26/10 | Prova 2 | Conteúdo da Unidade 3 e 4 |
| 07/12 | Prova 3 | Conteúdo da Unidade 5 e 6 |

## Materiais de apoio

- [Pasta de conteúdos](./Conteúdo/)
- [Pasta de atividades](./Atividades/)


### Bibliografia

	- ELMASRI, Ramez; NAVATHE, Shamkant B. Sistemas de banco de dados.
	- SILBERSCHATZ, Abraham; KORTH, Henry F.; SUDARSHAN, S. Sistema de banco de dados. 
	- TEOREY, Toby J. et al. Projeto e modelagem de banco de dados.
	- ADM TRANSACTIONS ON DATABASE SYSTEMS. New York: Association for Computing Machinery. 

### Extra
	
	- Certificações 
   		AWS, Azure, postgreSQL.