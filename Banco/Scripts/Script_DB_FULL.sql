Drop Table If Exists TB_Emprestimo;
Drop Table If Exists TB_Locatario; 
DROP TABLE IF EXISTS TB_Permissao;
Drop Table If Exists TB_Log;
DROP TABLE IF EXISTS TB_Usuario;
DROP TABLE IF EXISTS TB_Funcionalidade;
DROP TABLE IF EXISTS TB_Equipamento;


CREATE TABLE TB_Funcionalidade
(
	ID_Funcionalidade int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Ds_Funcionalidade varchar(50) NOT NULL
);

Create Table TB_Equipamento 
(
	ID_Equipamento Int Primary Key Identity(1,1) Not Null,
	Nm_Equipamento Varchar(30) Not Null,
	Nr_Equipamento Int Not Null,
	Ds_Tipo        Varchar(10) Not Null	
);

Create Table TB_Locatario
(
	ID_Locatario Int Primary Key Identity(1,1) Not Null,
	Nm_Locatario varchar(100) Default '-',
	RA_Locatario Varchar(12) Default '-',
);


Create TABLE TB_Usuario
(
	ID_Usuario int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nm_Usuario varchar(100) NOt Null,
	Ds_Prontuario varchar(30) Unique NOT NULL,
	Ds_Senha varchar(30) NOT NULL,
	Dt_Cadastro varchar(22) NOT NULL,
	Dt_UltimoLogin varchar(22) NOT NULL,
	Dt_Desativacao varchar(22) Default '-',	
);


CREATE TABLE TB_Permissao
(
	ID_Funcionalidade int NOT NULL,
	ID_Usuario int NOT NULL,
	Primary Key(ID_Funcionalidade, ID_Usuario)
);

ALTER TABLE TB_Permissao
ADD CONSTRAINT FK_Permissao_Func
FOREIGN KEY (ID_Funcionalidade) REFERENCES TB_Funcionalidade(ID_Funcionalidade);

ALTER TABLE TB_Permissao
ADD CONSTRAINT FK_Id_Func
FOREIGN KEY (ID_Usuario) REFERENCES TB_Usuario(ID_Usuario);

Create Table TB_Emprestimo
(
	ID_Emprestimo          Int Primary Key Identity(1,1) Not Null,
	ID_Equipamento         Int                           Not Null,
	Dt_Retirada            Datetime                      Not Null,
	ID_Locatario_Saida     Int                           Not Null,
	ID_Locador_Saida       Int                           Not Null,
------------------------------------------------------------------
	Dt_PrevistaDevolucao   Datetime                      Default '-',
	Dt_EfetivaDevolucao    Datetime                      Default null,
	ID_Locatario_Devolucao Int                           Null,
	ID_Locador_Devolucao   Int                           Null,	
);

ALTER TABLE TB_Emprestimo
ADD CONSTRAINT Fk_ID_Equipamento_Equipamento
FOREIGN KEY (ID_Equipamento) REFERENCES TB_Equipamento(ID_Equipamento);  --

ALTER TABLE TB_Emprestimo
ADD CONSTRAINT Fk_ID_Locatario_Locatario
FOREIGN KEY (ID_Locatario_Saida) REFERENCES TB_Locatario(ID_Locatario); --

ALTER TABLE TB_Emprestimo
ADD CONSTRAINT Fk_ID_Locador_Saida_Usuario
FOREIGN KEY (ID_Locador_Saida) REFERENCES TB_Usuario(ID_Usuario);  --

ALTER TABLE TB_Emprestimo
ADD CONSTRAINT Fk_ID_Locatario_Devolucao_Locatario
FOREIGN KEY (ID_Locatario_Devolucao) REFERENCES TB_Locatario(ID_Locatario);

ALTER TABLE TB_Emprestimo
ADD CONSTRAINT Fk_ID_Locador_Devolucao_Usuario
FOREIGN KEY (ID_Locador_Devolucao) REFERENCES TB_Usuario(ID_Usuario);


Create TABLE TB_Log
(
	ID_Log int NOT NULL Identity(1,1),
	ID_Usuario int NOT NULL,
	Ds_Log Varchar(200) not null,
	Dt_Log Varchar(20) not Null,
	Primary Key(ID_Log)
);
ALTER TABLE TB_Log
ADD CONSTRAINT Fk_ID_Usuario
FOREIGN KEY (ID_Usuario) REFERENCES TB_Usuario(ID_Usuario);






--Insert Das Tabelas

Insert Into TB_Funcionalidade values('Gerar Relatorios');
Insert Into TB_Funcionalidade values('Gereciar Emprestimos');
Insert Into TB_Funcionalidade values('Criar/Editar Usuarios');
Insert Into TB_Funcionalidade values('Criar/Editar Equipamentos');
Insert Into TB_Funcionalidade values('Excluir Usuarios/Senhas');  
Insert Into TB_Funcionalidade values('Visualizar Registro de Uso'); 



Insert Into TB_Usuario (Nm_Usuario, Ds_Prontuario, Ds_Senha, Dt_Cadastro, Dt_UltimoLogin) Values('Administrador', 'admin', 'admin', FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss'), FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss'));

Insert into TB_Permissao Values(1,1);
Insert into TB_Permissao Values(2,1);
Insert into TB_Permissao Values(3,1);
Insert into TB_Permissao Values(4,1);
Insert into TB_Permissao Values(5,1);
Insert into TB_Permissao Values(6,1);

