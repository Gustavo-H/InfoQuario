Drop Procedure If Exists sp_Sel_Equipamento
go
Create Procedure sp_Sel_Equipamento (@pId_Equipamento int) AS 
BEGIN
Select E.Nm_Equipamento As Nome, E.Nr_Equipamento As Numero, E.Ds_Tipo As Tipo
From TB_Equipamento as E
Where E.ID_Equipamento = @pId_Equipamento;
END;

