Drop Procedure If Exists sp_Sel_Funcionalidades

go

Create Procedure sp_Sel_Funcionalidades AS 
BEGIN
Select F.ID_Funcionalidade as 'ID', F.Ds_Funcionalidade as 'Descricao'
From TB_Funcionalidade as F
END;


