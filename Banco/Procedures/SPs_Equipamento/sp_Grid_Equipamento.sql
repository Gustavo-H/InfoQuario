Drop Procedure If Exists sp_Grid_Equipamento

go

Create Procedure sp_Grid_Equipamento (@pNm_Equipamento varchar(30), @pNr_Equipamento Int, @pDs_Tipo varchar(10)) AS 
BEGIN
	If(@pNr_Equipamento <= 0 or @pNr_Equipamento = Null)
	Begin
		Select  E.ID_Equipamento, E.Nm_Equipamento, E.Nr_Equipamento, E.Ds_Tipo
		From TB_Equipamento as E
		Where (E.Ds_Tipo Like '%' + @pDs_Tipo + '%') 
		And (E.Nm_Equipamento Like '%' + @pNm_Equipamento + '%')	
	End
	Else
	Begin
		Select  E.ID_Equipamento, E.Nm_Equipamento, E.Nr_Equipamento, E.Ds_Tipo
		From TB_Equipamento as E
		Where (E.Ds_Tipo Like '%' + @pDs_Tipo + '%') 
		And (E.Nm_Equipamento Like '%' + @pNm_Equipamento + '%')
		And (E.Nr_Equipamento = @pNr_Equipamento)
	End

END;



