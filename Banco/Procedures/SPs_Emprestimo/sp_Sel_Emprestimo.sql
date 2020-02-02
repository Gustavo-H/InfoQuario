Drop Procedure If Exists sp_Sel_Emprestimo;
go
Create Procedure sp_Sel_Emprestimo (@pID_Emprestimo Int) As 
Begin
	Select Emp.ID_Equipamento As ID, Emp.Dt_EfetivaDevolucao, Emp.Dt_PrevistaDevolucao, Emp.Dt_Retirada, Emp.ID_Locador_Devolucao, 
			Emp.ID_Locador_Saida, Emp.ID_Locatario_Devolucao, Emp.ID_Locatario_Saida, CONCAT(Equip.Nm_Equipamento, ' ', Equip.Nr_Equipamento) As NomeEquipamento,
			Equip.Ds_Tipo, Locat.Nm_Locatario, Locat.RA_Locatario, U.Nm_Usuario As Nm_Locador, U.Ds_Prontuario As RA_Locador
	From TB_Emprestimo as Emp 	
	Inner Join TB_Equipamento As Equip On Equip.ID_Equipamento = Emp.ID_Equipamento
	Inner Join TB_Locatario As Locat On Locat.ID_Locatario = Emp.ID_Locatario_Saida
	Inner join TB_Usuario As U On U.ID_Usuario = Emp.ID_Locador_Saida
	Where Emp.ID_Emprestimo = @pID_Emprestimo;
End;





