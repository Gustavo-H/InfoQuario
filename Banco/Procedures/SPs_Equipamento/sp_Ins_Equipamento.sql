DROP PROCEDURE IF EXISTS sp_Ins_Equipamento;

GO

CREATE PROCEDURE sp_Ins_Equipamento(@pNm_Equipamento Varchar(30), @pNr_Equipamento Int, @pDs_Tipo varchar(10)) AS 
BEGIN
	INSERT INTO TB_Equipamento(Nm_Equipamento, Nr_Equipamento, Ds_Tipo)
		VALUES(@pNm_Equipamento, @pNr_Equipamento, @pDs_Tipo)
END;



