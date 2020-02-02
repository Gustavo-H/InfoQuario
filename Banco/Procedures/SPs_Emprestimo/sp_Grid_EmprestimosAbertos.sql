Drop Procedure If Exists sp_Grid_EmprestimosAbertos;
go
Create Procedure sp_Grid_EmprestimosAbertos As 
Begin
	Select Emp.ID_Emprestimo As ID, CONCAT(Equip.Nm_Equipamento, ' ' , Equip.Nr_Equipamento) As Item, Locat.Nm_Locatario As Locatario, U.Nm_Usuario As Locador, Emp.Dt_Retirada As DataSaida, Emp.Dt_PrevistaDevolucao As DataPrevista  
	From TB_Emprestimo As Emp 
	Inner Join TB_Equipamento As Equip On Equip.ID_Equipamento = Emp.ID_Equipamento
	Inner Join TB_Locatario As Locat On Locat.ID_Locatario = Emp.ID_Locatario_Saida
	Inner join TB_Usuario As U On U.ID_Usuario = Emp.ID_Locador_Saida
	Where Emp.ID_Locador_Devolucao is null;
End;


--Exec sp_Grid_EmprestimosAbertos 