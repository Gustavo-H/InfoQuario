Drop Procedure If Exists sp_Grid_Relatorio;
go
Create Procedure sp_Grid_Relatorio (@pDt_SaidaInicio DateTime, @pDt_SaidaFim DateTime, @pDt_DevolucaoInicio DateTime, @pDt_DevolucaoFim DateTime,
	@pNm_Equipamento varchar(33), @pNm_Locatario varchar(50), @pNm_LocadorSaida varchar(50), @pNm_LocadorDevolucao varchar(50), @pDs_Status Int, 
	@pID_Equipamento int, @pID_Locador_Devolucao int, @pID_Locador_Saida int, @pID_Locatario_Saida int)  As 
Begin
	
	if(@pID_Equipamento > 0) Set @pNm_Equipamento = null;
	if(@pID_Locador_Devolucao > 0) Set @pNm_LocadorDevolucao = null;
	if(@pID_Locador_Saida > 0) Set @pNm_LocadorSaida = null;
	if(@pID_Locatario_Saida > 0) Set @pNm_Locatario = null;	   
	
	If @pDs_Status = 1 --Abertos 
	Begin
		Select Concat(Equip.Nm_Equipamento, ' ', Equip.Nr_Equipamento) As NomeEquipamento, Empre.Dt_Retirada, CONCAT(LocatSaida.Nm_Locatario , ' ', LocatSaida.RA_Locatario) As NomeLocatarioSaida,
		CONCAT(UsuarioSaida.Nm_Usuario, ' ', UsuarioSaida.Ds_Prontuario) As NomeLocadorSaida,  --Dados Da Coluna Saida

		Empre.Dt_PrevistaDevolucao, '-' As Dt_EfetivaDevolucao, '-' As NomeLocatarioDevolucao, 
		'-' As NomeLocadorDevolucao --Dados Das Coluna Devolucao
	
		From TB_Emprestimo As Empre
	
		Inner Join TB_Equipamento as Equip On Empre.ID_Equipamento = Equip.ID_Equipamento
	
		Inner Join TB_Locatario As LocatSaida on LocatSaida.ID_Locatario = Empre.ID_Locatario_Saida	
	
		Inner Join TB_Usuario As UsuarioSaida on UsuarioSaida.ID_Usuario = Empre.ID_Locador_Saida
		
		Where ((Equip.Nm_Equipamento like '%' + @pNm_Equipamento + '%') or (Empre.ID_Equipamento = @pID_Equipamento))		
		
		And ((LocatSaida.Nm_Locatario like '%' + @pNm_Locatario + '%') or (Empre.ID_Locatario_Saida = @pID_Locatario_Saida))
		
		And ((UsuarioSaida.Nm_Usuario like '%' + @pNm_LocadorSaida + '%') or (Empre.ID_Locador_Saida = @pID_Locador_Saida))
		And ((Empre.Dt_Retirada >= @pDt_SaidaInicio OR @pDt_SaidaInicio = '') AND (Empre.Dt_Retirada <= @pDt_SaidaFim OR @pDt_SaidaFim = ''))
		And (Empre.ID_Locador_Devolucao is null)
		--And (Empre.Dt_Retirada between @pDt_SaidaInicio and @pDt_SaidaFim)
	End;

	else if @pDs_Status = 0  --Fechados
	Begin
	Select Concat(Equip.Nm_Equipamento, ' ', Equip.Nr_Equipamento) As NomeEquipamento, Empre.Dt_Retirada, CONCAT(LocatSaida.Nm_Locatario , ' ', LocatSaida.RA_Locatario) As NomeLocatarioSaida,
		CONCAT(UsuarioSaida.Nm_Usuario, ' ', UsuarioSaida.Ds_Prontuario) As NomeLocadorSaida,  --Dados Da Coluna Saida

		Empre.Dt_PrevistaDevolucao, Empre.Dt_EfetivaDevolucao, CONCAT(LocatDevol.Nm_Locatario, ' ', LocatDevol.RA_Locatario) As NomeLocatarioDevolucao, 
		CONCAT(UsuarioDevol.Nm_Usuario, ' ', UsuarioDevol.Ds_Prontuario) As NomeLocadorDevolucao --Dados Das Coluna Devolucao
	
		From TB_Emprestimo As Empre
	
		Inner Join TB_Equipamento as Equip On Empre.ID_Equipamento = Equip.ID_Equipamento
	
		Inner Join TB_Locatario As LocatSaida on LocatSaida.ID_Locatario = Empre.ID_Locatario_Saida
		Inner Join TB_Locatario As LocatDevol on LocatDevol.ID_Locatario = Empre.ID_Locatario_Devolucao
	
		Inner Join TB_Usuario As UsuarioSaida on UsuarioSaida.ID_Usuario = Empre.ID_Locador_Saida
		Inner Join TB_Usuario As UsuarioDevol on UsuarioDevol.ID_Usuario = Empre.ID_Locador_Devolucao 
		
		Where ((Equip.Nm_Equipamento like '%' + @pNm_Equipamento + '%') or (Empre.ID_Equipamento = @pID_Equipamento))		
		
		And ((LocatSaida.Nm_Locatario like '%' + @pNm_Locatario + '%') or (Empre.ID_Locatario_Saida = @pID_Locatario_Saida))
		
		And ((UsuarioSaida.Nm_Usuario like '%' + @pNm_LocadorSaida + '%') or (Empre.ID_Locador_Saida = @pID_Locador_Saida))
		And ((UsuarioDevol.Nm_Usuario like '%' + @pNm_LocadorDevolucao + '%') or (Empre.ID_Locador_Devolucao = @pID_Locador_Devolucao))
		And ((Empre.Dt_Retirada >= @pDt_SaidaInicio OR @pDt_SaidaInicio = '') AND (Empre.Dt_Retirada <= @pDt_SaidaFim OR @pDt_SaidaFim = ''))
		
		/*Empre.Dt_Retirada between 
		(case @pDt_SaidaInicio IS NULL) 
		when '' then Empre.Dt_Retirada
		Else @pDt_SaidaInicio End)		
		And 
		(case Isnull(@pDt_SaidaFim, '') 
		when '' then Empre.Dt_Retirada  
		Else @pDt_SaidaFim End) */



	End;

	else Begin  --Ambos
	Select Concat(Equip.Nm_Equipamento, ' ', Equip.Nr_Equipamento) As NomeEquipamento, Empre.Dt_Retirada, CONCAT(LocatSaida.Nm_Locatario , ' ', LocatSaida.RA_Locatario) As NomeLocatarioSaida,
		CONCAT(UsuarioSaida.Nm_Usuario, ' ', UsuarioSaida.Ds_Prontuario) As NomeLocadorSaida,  --Dados Da Coluna Saida

		Empre.Dt_PrevistaDevolucao, Empre.Dt_EfetivaDevolucao, CONCAT(LocatDevol.Nm_Locatario, ' ', LocatDevol.RA_Locatario) As NomeLocatarioDevolucao, 
		CONCAT(UsuarioDevol.Nm_Usuario, ' ', UsuarioDevol.Ds_Prontuario) As NomeLocadorDevolucao --Dados Das Coluna Devolucao
	
		From TB_Emprestimo As Empre
	
		Inner Join TB_Equipamento as Equip On Empre.ID_Equipamento = Equip.ID_Equipamento
	
		Inner Join TB_Locatario As LocatSaida on LocatSaida.ID_Locatario = Empre.ID_Locatario_Saida
		Inner Join TB_Locatario As LocatDevol on LocatDevol.ID_Locatario = Empre.ID_Locatario_Devolucao
	
		Inner Join TB_Usuario As UsuarioSaida on UsuarioSaida.ID_Usuario = Empre.ID_Locador_Saida
		Inner Join TB_Usuario As UsuarioDevol on UsuarioDevol.ID_Usuario = Empre.ID_Locador_Devolucao 
		Where ((Equip.Nm_Equipamento like '%' + @pNm_Equipamento + '%') or (Empre.ID_Equipamento = @pID_Equipamento))		
		
		And ((LocatSaida.Nm_Locatario like '%' + @pNm_Locatario + '%') or (Empre.ID_Locatario_Saida = @pID_Locatario_Saida))
		
		And ((UsuarioSaida.Nm_Usuario like '%' + @pNm_LocadorSaida + '%') or (Empre.ID_Locador_Saida = @pID_Locador_Saida))
		And ((UsuarioDevol.Nm_Usuario like '%' + @pNm_LocadorDevolucao + '%') or (Empre.ID_Locador_Devolucao = @pID_Locador_Devolucao))
		And ((Empre.Dt_Retirada >= @pDt_SaidaInicio OR @pDt_SaidaInicio = '') AND (Empre.Dt_Retirada <= @pDt_SaidaFim OR @pDt_SaidaFim = ''))
	End;  	
	
End;

