Drop Procedure If Exists sp_Upd_Emprestimo;
go
Create Procedure sp_Upd_Emprestimo (@pID_Locador_Devolucao Int, @pID_Locatario_Devolucao Int, @pDt_EfetivaDevolucao Datetime, @pID_Emprestimo Int) As 
Begin
	Update TB_Emprestimo Set Dt_EfetivaDevolucao = @pDt_EfetivaDevolucao, ID_Locador_Devolucao = @pID_Locador_Devolucao, ID_Locatario_Devolucao = @pID_Locatario_Devolucao
	Where ID_Emprestimo = @pID_Emprestimo
End;

