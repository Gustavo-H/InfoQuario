Drop Procedure If Exists sp_Sel_Usuario

go

Create Procedure sp_Sel_Usuario (@pId_Usuario int) AS 
BEGIN
Select U.Nm_Usuario as Nome, U.Ds_Prontuario as 'Login', U.Ds_Senha as Senha, U.Dt_Cadastro as DataCadastro,
	U.Dt_UltimoLogin as UltimoLogin
From TB_Usuario as U
Where U.ID_Usuario = @pId_Usuario;
END;

