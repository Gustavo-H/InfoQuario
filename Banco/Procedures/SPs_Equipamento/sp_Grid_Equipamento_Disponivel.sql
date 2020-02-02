Drop Procedure If Exists sp_Grid_Equipamento_Disponivel;
go
Create Procedure sp_Grid_Equipamento_Disponivel (@pDs_Tipo Varchar(10)) As 
Begin
	Select E.ID_Equipamento As ID, CONCAT(E.Nm_Equipamento,' ', E.Nr_Equipamento) As Nome
	From TB_Equipamento as E
	Where E.ID_Equipamento Not In(Select M.ID_Equipamento
								  From TB_Emprestimo As M
								  Where M.ID_Locador_Devolucao is null)	
	And E.Ds_Tipo = @pDs_Tipo
End;



