DROP PROCEDURE IF EXISTS sp_Upd_Usuario;

GO

CREATE PROCEDURE sp_Upd_Usuario(@pNm_Usuario varchar(100), @pDs_Prontuario varchar(30), @pDs_Senha varchar(30), @pID_Usuario int) AS 
BEGIN
	UPDATE TB_Usuario
	SET Nm_Usuario = @pNm_Usuario, Ds_Prontuario = @pDs_Prontuario, Ds_Senha = @pDs_Senha
	WHERE ID_Usuario = @pID_Usuario
END;


