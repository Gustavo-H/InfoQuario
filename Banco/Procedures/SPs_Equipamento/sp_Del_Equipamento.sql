DROP PROCEDURE IF EXISTS sp_Del_Equipamento;

GO

CREATE PROCEDURE sp_Del_Equipamento(@pID_Equipamento int) AS 
BEGIN
	Delete From TB_Equipamento
	WHERE ID_Equipamento=@pID_Equipamento
END;

