Drop Procedure If Exists sp_Grid_EquipamentoRelatorio
go
Create Procedure sp_Grid_EquipamentoRelatorio (@pNm_Equipamento varchar(30)) AS 
BEGIN	
	Select  E.ID_Equipamento As ID, CONCAT(E.Nm_Equipamento, ' ', E.Nr_Equipamento) As Nome
	From TB_Equipamento as E
	Inner Join TB_Emprestimo as M On M.ID_Equipamento = E.ID_Equipamento
	Where (E.Nm_Equipamento Like '%' + @pNm_Equipamento + '%')	
END;

