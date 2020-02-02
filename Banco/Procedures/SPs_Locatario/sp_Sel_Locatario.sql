Drop Procedure If Exists sp_Sel_Locatario;
Go
Create Procedure sp_Sel_Locatario (@pNm_Locatario Varchar(100), @pRA_Locatario Varchar(12)) As
Begin	
	Select L.ID_Locatario
	From TB_Locatario As L
	Where l.Nm_Locatario = @pNm_Locatario
	and l.RA_Locatario = @pRA_Locatario;
End;
