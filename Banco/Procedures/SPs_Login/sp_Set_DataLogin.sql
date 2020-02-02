DROP PROCEDURE IF EXISTS sp_Set_DataLogin;

GO

CREATE PROCEDURE sp_Set_DataLogin(@pId_Usuario int) AS 
BEGIN

Update tb_Usuario
Set Dt_UltimoLogin = FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss')
Where ID_Usuario = @pId_Usuario;
END;

