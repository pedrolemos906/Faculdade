#Lista de Atividade - 1
##Respostas:
		
		1)
		Caça Palavras
		Vertical:
			A) *Banco de Dados*: Trata-se de uma col~ção de dados relacionados usados pelos sistemas de aplicação de determinada empresa para atender objetivos de usuários.
			B) Os SGBDs possuem os componentes *Humanos*, representados pelos profissionais que constituem a arquitetura destes sistemas.
			C) O *Usuário* final acessa o banco de dados para consultas, inseção/alteração/exclusão de dados e também para geração de relatórios.
			D) No projeto *Lógico* do banco de dados há o detalhamentos do modelo de dados da fase anterior (projeto conceitual) para uma determinada classe de SGBD: relaional, orientada a objetos, rede, etc.
			
		Horizontal
			A) Os sistemas gerenciadors de banco de dados (SGBD) são *software* que incorporam as funções de definição, recuperação e alteração ede dados em um banco de dados.
			B) Os bancos de dados têm foco no *conteúdo* já os SGBDs tem foco na *tecnológia*.
			C) No Projeto *físico* do banco de dados ocorre a persistencia dos dados e há a necessidade de utilização de um SGBD tais como Oracle, MySQL ou SQL Server.
			D) A modelagem do diagrama entidade-relacionamento é o artefato principal produzido no projeto conceitual do banco de dados.
			
		2) 
		Dado = Fato bruto, isolado sem contexto.
		Informação = É o dado processado, organizado, e com contexto.
		Conhecimento = É a informação associada a experiência, análise e capaciade de tomada de decisão.
		
		3)
		Banco de Dados = É uma coleção organizada de dados relacionados entre si, armazenados de forma que possam acessados, manipulados e atualizados com facilidade.
		Sistema de Banco de Dados = É o ambiente que permite a um ou mais usuários armazenar, manipular, gerenciar e utilizar os dados.
		Sistema de Gerenciamento de Banco de Dados = Software responsável por criar, manipular, controlar e administrar um banco de dados.
		
		 4) 
	        • Controle de redundância e inconsistência de dados;
	        • Restrição de acesso não autorizado;
	        • Armazenamento persistente;
	        • Existência de recursos para backup e recuperação;
	        • Imposição de restrições de integridade e de regras de negócio;
	        • Processamento eficiente de consulta;
	        • Múltiplas interfaces: dados vistos de forma mais adequada por aplicação e usuário;
	        • Favorece controle mais centralizado de dados
		
		5)
		Porque, na abordagem tradicional baseada em arquivos, os dados ficam geralmente presos a aplicações específicas. Isso dificulta que outros sistemas reutilizem esses mesmos dados.
		
		6)
		Podemos destacar:
        Administrador de Banco de Dados (DBA)
	        Administra o banco.
	        Define usuários e permissões.
	        Cuida de segurança, backup, recuperação e desempenho.
			
		Projetistas/Desenvolvedores de Banco de Dados
	        Projetam a estrutura do banco.
	        Definem tabelas, relacionamentos, restrições etc.
	        Utilizam ferramentas de modelagem e comandos SQL.
			
		Desenvolvedores de Aplicações
	        Criam programas que acessam o banco.
	        A aplicação envia comandos ao SGBD para consultar ou modificar dados.
			
		Usuários Finais
	        Utilizam as aplicações para consultar ou inserir informações.
	        Normalmente não interagem diretamente com o SGBD; a aplicação faz essa comunicação.
			
			
		7)
		MySQL, PostrgreSQL, Oracle Database e Microsoft SQLServer.
		
		8)
			a) 
			DDL = Data Definition Language
			DML = Data Manipulatin Language
			DCL = Data Control Language
			
			b)
			DDL = Liguagem de Definição de Dados
			DML = Liguagem de Manipulção de Dados
			DCL = Liguagem de Controle de Dados
			
			c)
			DDL = Conjunto de instruções usado para criar e modificar as estruturas dos objetos armazenados no bnaco de dados.
			DML = Conjunto de instruções usado nas consultas e modificações de dados armazenados nas tabelas do banco de dados.
			DCL = conjunto de instruçoes usado para controle de acesso e gerenciamento de permissões para usuários no banco de dados.
			
			d) É não-procedural, porque você nao escolhe como o SGBD irá exucutar o comando.
			
		9)
			Processador de Consultas:
				Analisador DDL (DDL Interpreter)
					- Interpreta comandos de definição de dados, como CREATE, ALTER e DROP.
					- Atualiza o catálogo (dicionário de dados) do banco.
				Compilador DML (DML Compiler)
					- Traduz comandos de manipulação de dados (SELECT, INSERT, UPDATE, DELETE) para uma representação interna.
				Otimizador de Consultas (Query Optimizer)
					- Escolhe a forma mais eficiente de executar uma consulta.
					- Decide, por exemplo, quais índices utilizar e a ordem das operações.
				Motor de Execução de Consultas (Query Evaluation Engine)
					- Executa o plano gerado pelo otimizador e retorna os resultados.
					
			Sistema de Armazenamento:
				Gerenciador de Arquivos (File Manager)
					- Controla a organização dos arquivos do banco no armazenamento secundário.
				Gerenciador de Buffer (Buffer Manager)
					- Controla a movimentação de dados entre a memória principal (RAM) e o disco.
					- Mantém páginas frequentemente acessadas em memória para melhorar o desempenho.
				Gerenciador de Transações (Transaction Manager)
					- Garante que as transações sigam as propriedades ACID.
					- Controla commit e rollback.
				Gerenciador de Controle de Concorrência (Concurrency Control Manager)
					- Coordena acessos simultâneos de vários usuários aos mesmos dados.
					- Evita conflitos e inconsistências.
				Gerenciador de Recuperação (Recovery Manager)
					- Recupera o banco em caso de falhas, quedas de energia ou erros.
					- Utiliza logs e backups.
				Gerenciador de Autorização e Integridade
					- Controla permissões de acesso.
					- Garante que restrições e regras de integridade sejam respeitadas. 
					
		10)
			É importante armazenar os dados separados de sua definição (metadados/esquema) porque isso proporciona independência dos dados, facilitando a manutenção e a evolução do sistema.
		