DROP PROCEDURE IF EXISTS sp_Sel_PermissoesUsuario;

GO

CREATE PROCEDURE sp_Sel_PermissoesUsuario(@pID_Usuario int)
AS 
BEGIN
	Select ID_Funcionalidade as ID
	From TB_Permissao
	Where ID_Usuario = @pID_Usuario
END;

