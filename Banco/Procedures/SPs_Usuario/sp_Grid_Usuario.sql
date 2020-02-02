Drop Procedure If Exists sp_Grid_Usuario

go

Create Procedure sp_Grid_Usuario (@pNm_Usuario varchar(100), @pDs_Prontuario varchar(30)) AS 
BEGIN
Select U.ID_Usuario as ID, U.Nm_Usuario as Nome, U.Ds_Prontuario as 'Login'
From TB_Usuario as U
Where (U.Nm_Usuario Like '%' + @pNm_Usuario + '%') 
And (U.Ds_Prontuario Like '%' + @pDs_Prontuario + '%')
And (U.Dt_Desativacao = '-')
END;


