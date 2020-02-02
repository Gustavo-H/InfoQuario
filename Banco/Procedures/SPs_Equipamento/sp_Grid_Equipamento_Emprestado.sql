Drop Procedure If Exists sp_Grid_Equipamento_Emprestado;
go
Create Procedure sp_Grid_Equipamento_Emprestado (@pDs_Tipo Varchar(10)) As 
Begin
	Select E.ID_Equipamento As ID, CONCAT(E.Nm_Equipamento,' ', E.Nr_Equipamento) As Nome
	From TB_Emprestimo as M	
	Inner Join TB_Equipamento as E On E.ID_Equipamento = M.ID_Equipamento 	 
	Where E.Ds_Tipo = @pDs_Tipo
	And M.ID_Locador_Devolucao is null
End;

--Exec sp_Grid_Equipamento_Emprestado 'Sala/Lab'

