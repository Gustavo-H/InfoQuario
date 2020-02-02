Drop Procedure If Exists sp_Grid_Locatario;
Go
Create Procedure sp_Grid_Locatario (@pNm_Locatario Varchar(100), @pRA_Locatario Varchar(12)) As
Begin
	Select L.ID_Locatario As ID, L.Nm_Locatario As Nome, L.RA_Locatario As RA
	From TB_Locatario As L
	Where (L.Nm_Locatario Like '%' + @pNm_Locatario + '%')
	And (L.RA_Locatario Like '%' + @pRA_Locatario + '%')
	Order By L.ID_Locatario;
End;