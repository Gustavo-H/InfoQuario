DROP PROCEDURE IF EXISTS sp_Ins_PermissoesUsuario;

GO

CREATE PROCEDURE sp_Ins_PermissoesUsuario( @pID_Usuario int, @pID_Funcionalidade int) AS 
BEGIN
INSERT INTO TB_Permissao(ID_Funcionalidade , ID_Usuario)
VALUES(@pID_Funcionalidade, @pID_Usuario)
END;

GO