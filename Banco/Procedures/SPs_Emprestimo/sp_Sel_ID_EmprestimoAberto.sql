Drop Procedure If Exists sp_Sel_ID_EmprestimoAberto;
go
Create Procedure sp_Sel_ID_EmprestimoAberto (@pID_Equipamento Int) As 
Begin
	Select E.ID_Emprestimo as ID
	From TB_Emprestimo as E 
	Where E.ID_Equipamento = @pID_Equipamento
	And E.ID_Locador_Devolucao  is null;
End;

--Exec sp_Sel_ID_EmprestimoAberto '12'