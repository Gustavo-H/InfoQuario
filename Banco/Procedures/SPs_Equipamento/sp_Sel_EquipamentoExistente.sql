Drop Procedure If Exists sp_Sel_EquipamentoExistente
go
Create Procedure sp_Sel_EquipamentoExistente (@pNm_Equipamento Varchar(30), @pNr_Equipamento int) AS 
BEGIN
Select E.ID_Equipamento
From TB_Equipamento as E
Where E.Nm_Equipamento = @pNm_Equipamento
And E.Nr_Equipamento = @pNr_Equipamento
END;
