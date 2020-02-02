Drop Procedure If Exists sp_Ins_Log;
Go
Create Procedure sp_Ins_Log (@pId_Usuario Int, @pDs_Log Varchar(200)) As
Begin
	Insert Into TB_Log (ID_Usuario, Ds_Log, Dt_Log) Values (@pId_Usuario, @pDs_Log, FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss'));
End;