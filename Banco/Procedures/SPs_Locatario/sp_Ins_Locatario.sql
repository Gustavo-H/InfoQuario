Drop Procedure If Exists sp_Ins_Locatario;
Go
Create Procedure sp_Ins_Locatario (@pNm_Locatario Varchar(100), @pRA_Locatario Varchar(12)) As
Begin
	Insert Into TB_Locatario (Nm_Locatario, RA_Locatario) Values (@pNm_Locatario, @pRA_Locatario);
	Select @@IDENTITY As ID
End;
