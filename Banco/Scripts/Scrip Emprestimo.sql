-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE Usuario (
ID_Usuario int PRIMARY KEY
)

CREATE TABLE Servidor (
ID_Servidor int PRIMARY KEY
)

CREATE TABLE Equipamento (
ID_Equipamento int PRIMARY KEY
)

CREATE TABLE Emprestimo (
ID_Emprestimo int PRIMARY KEY,
ID_Equipamento int,
ID_UsuarioEmpresta int,
ID_UsuarioRecebe int,
ID_ServidorRetira int,
ID_ServidorDevolve int,
DataDevolucao varchar(20),
DataRetirada varchar(20),
FOREIGN KEY(ID_Equipamento) REFERENCES Equipamento (ID_Equipamento),
FOREIGN KEY(ID_UsuarioEmpresta) REFERENCES Usuario (ID_Usuario),
FOREIGN KEY(ID_UsuarioRecebe) REFERENCES Usuario (ID_Usuario),
FOREIGN KEY(ID_ServidorRetira) REFERENCES Servidor (ID_Servidor),
FOREIGN KEY(ID_ServidorDevolve) REFERENCES Servidor (ID_Servidor)
)

