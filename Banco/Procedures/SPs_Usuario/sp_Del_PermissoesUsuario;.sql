DROP PROCEDURE IF EXISTS sp_Del_PermissoesUsuario;

GO

CREATE PROCEDURE sp_Del_PermissoesUsuario(@pID_Usuario int)
AS 
BEGIN
	Delete From TB_Permissao
	Where ID_Usuario = @pID_Usuario
END;
