DROP PROCEDURE IF EXISTS sp_ValidarProntuario;

GO

CREATE PROCEDURE sp_ValidarProntuario(@pDs_Prontuario varchar(30))
AS 
BEGIN
	Select ID_Usuario as ID
	From TB_Usuario
	Where Ds_Prontuario = @pDs_Prontuario
END;

