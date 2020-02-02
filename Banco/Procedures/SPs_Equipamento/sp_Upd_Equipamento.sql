DROP PROCEDURE IF EXISTS sp_Upd_Equipamento;

GO

CREATE PROCEDURE sp_Upd_Equipamento(@pNm_Equipamento varchar(30), @pDs_Tipo varchar(10), @pNr_Equipamento int, @pID_Equipamento int) AS 
BEGIN
	UPDATE TB_Equipamento
	SET Ds_Tipo=@pDs_Tipo, Nm_Equipamento=@pNm_Equipamento, Nr_Equipamento=@pNr_Equipamento
	WHERE ID_Equipamento=@pID_Equipamento
END;

