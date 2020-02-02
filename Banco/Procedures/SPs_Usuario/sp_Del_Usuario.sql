DROP PROCEDURE IF EXISTS sp_Del_Usuario;

GO

CREATE PROCEDURE sp_Del_Usuario(@pID_Usuario int)
AS 
BEGIN
	UPDATE TB_Usuario
	SET Dt_Desativacao = FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss')
	WHERE ID_Usuario = @pID_Usuario
END;
