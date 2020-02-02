Drop Procedure If Exists sp_Ins_NovoEmprestimo;
Go
Create Procedure sp_Ins_NovoEmprestimo (@pID_Equipamento Int, @pDt_Retirada Datetime, @pID_Locatario_Saida Int, @pID_Locador_Saida Int, @pDt_PrevistaDevolucao Datetime) As
Begin
	Insert Into TB_Emprestimo (ID_Equipamento, Dt_Retirada, ID_Locatario_Saida, ID_Locador_Saida, Dt_PrevistaDevolucao, Dt_EfetivaDevolucao) 
		Values(@pID_Equipamento, @pDt_Retirada, @pID_Locatario_Saida, @pID_Locador_Saida, @pDt_PrevistaDevolucao, null);		
End;

