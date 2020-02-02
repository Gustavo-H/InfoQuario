Drop Procedure If Exists sp_Grid_Log;
Go
Create Procedure sp_Grid_Log  As
Begin
	Select Concat(U.Nm_Usuario, ', ', U.Ds_Prontuario), L.Ds_Log, L.Dt_Log 
	From TB_Log As L
	Inner join TB_Usuario As U on U.ID_Usuario = L.ID_Usuario
	Order by L.Dt_Log
End;