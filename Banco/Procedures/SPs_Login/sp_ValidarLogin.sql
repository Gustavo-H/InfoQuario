Drop Procedure If Exists sp_ValidarLogin
Go
Create Procedure sp_ValidarLogin (@pLogin Varchar(30), @pSenha varchar(30))
As
Begin 
Select U.Id_Usuario As ID, U.Nm_Usuario As Nome, U.Dt_Cadastro As DataCadastro, U.Dt_UltimoLogin As UltimoLogin  --FORMAT(GETDATE(), 'dd.MM.yyyy hh:mm:ss')
From tb_Usuario as U
Where U.Ds_Prontuario = @pLogin 
And U.Ds_Senha = @pSenha
And U.Dt_Desativacao = '-'
End;



