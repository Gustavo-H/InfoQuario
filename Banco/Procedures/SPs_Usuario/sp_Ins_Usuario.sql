DROP PROCEDURE IF EXISTS sp_Ins_Usuario;

GO

CREATE PROCEDURE sp_Ins_Usuario(@pNm_Usuario varchar(100), @pDs_Prontuario varchar(30), @pDs_Senha varchar(30)) AS 
BEGIN
Declare @data varchar(20);
Set @data = FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss');

INSERT INTO TB_Usuario(Nm_Usuario, Ds_Prontuario, Ds_Senha, Dt_Cadastro, Dt_UltimoLogin)
VALUES(@pNm_Usuario, @pDs_Prontuario, @pDs_Senha, @data, @data)
Select @@IDENTITY As ID;
END;


