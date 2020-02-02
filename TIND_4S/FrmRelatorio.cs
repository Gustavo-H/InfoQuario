using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Diagnostics;

namespace TIND_4S
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
            btnLimparCampos_Click(null, null);            
        }

        ClsRelatorio Relatorio = new ClsRelatorio();
        FrmBuscarDados frmBuscarDados;
        ClsLog log = new ClsLog();



        private void gerarPDF()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 0f, 0f, 30f, 30f);
            doc.SetMargins(1f, 1f, 30f, 30f);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files (*.pdf)|*.pdf";
            sfd.Title = "Escolha o Local Para Salvar";
            sfd.ShowDialog();

            if (sfd.FileName != string.Empty)
            {
                BaseFont bf2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf2, 10, iTextSharp.text.Font.NORMAL);

                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontSubHeader = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL);

                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();
                    PdfPTable table = new PdfPTable(8);

                    PdfPCell header = new PdfPCell(new Phrase("IFSP - CAMPUS CAPIVARI\nControle de Saídas de Equipamentos Eletrônicos - CAE - Ano Corrente: " + DateTime.Now.Year.ToString(), fontHeader));
                    header.Colspan = 8;
                    header.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right                    
                    table.AddCell(header);

                    PdfPCell subHeader1 = new PdfPCell(new Phrase("SAÍDA", fontSubHeader));
                    subHeader1.Colspan = 4;
                    subHeader1.HorizontalAlignment = 1;
                    subHeader1.VerticalAlignment = 1;
                    table.AddCell(subHeader1);

                    PdfPCell subHeader2 = new PdfPCell(new Phrase("DEVOLUÇÃO", fontSubHeader));
                    subHeader2.Colspan = 4;
                    subHeader2.HorizontalAlignment = 1;
                    subHeader2.VerticalAlignment = 1;
                    table.AddCell(subHeader2);

                    PdfPCell cellTitle;

                    cellTitle = new PdfPCell(new Phrase("EQUIPAMENTO", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 2;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("DATA-HORA RETIRADA", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("SOLICITANTE", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("VISTO SAIDA", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("DATA-HORA\nPREVISTA\nDEVOLUÇÃO", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("DATA-HORA\nEFETIVA\nDEVOLUÇÃO", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("DEVOLVIDO POR", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("VISTO RECEBIMENTO", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    PdfPCell cellConteudo;

                    foreach (DataRow row in Relatorio.Dt.Rows)
                    {
                        cellConteudo = new PdfPCell(new Phrase(row[0].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[1].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[2].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[3].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[4].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[5].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[6].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);

                        cellConteudo = new PdfPCell(new Phrase(row[7].ToString(), font));
                        cellConteudo.HorizontalAlignment = 1;
                        table.AddCell(cellConteudo);
                    }
                    doc.Add(table);


                    doc.NewPage();               
                    

                    table = new PdfPTable(2);

                    header = new PdfPCell(new Phrase("IFSP - InfoQuario\nDetalhes dos Filtros Utilizados", fontHeader));
                    header.Colspan = 2;
                    header.HorizontalAlignment = 1;
                    table.AddCell(header);

                    subHeader1 = new PdfPCell(new Phrase("Filtro", fontSubHeader));
                    subHeader1.Colspan = 1;
                    subHeader1.HorizontalAlignment = 1;
                    subHeader1.VerticalAlignment = 1;
                    table.AddCell(subHeader1);

                    subHeader1 = new PdfPCell(new Phrase("Descrição", fontSubHeader));
                    subHeader1.Colspan = 1;
                    subHeader1.HorizontalAlignment = 1;
                    subHeader1.VerticalAlignment = 1;                    
                    table.AddCell(subHeader1);

                    cellTitle = new PdfPCell(new Phrase("Estado", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if(Relatorio.Ds_Status == 1)
                        cellTitle = new PdfPCell(new Phrase("Empréstimos Abertos", fontTitle));
                    else if(Relatorio.Ds_Status == 0)
                        cellTitle = new PdfPCell(new Phrase("Empréstimos Fechados", fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Empréstimos Abertos e Fechados", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    cellTitle = new PdfPCell(new Phrase("Data Saida", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if (Relatorio.Dt_SaidaInicio != "")                        
                        cellTitle = new PdfPCell(new Phrase("De : " + Relatorio.Dt_SaidaInicio + " Até : " + Relatorio.Dt_SaidaFim, fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Não Informado Nenhum Valor", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    cellTitle = new PdfPCell(new Phrase("Data Devolução", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if (Relatorio.Dt_DevolucaoInicio != "")
                        cellTitle = new PdfPCell(new Phrase("De : " + Relatorio.Dt_DevolucaoInicio + " Até : " + Relatorio.Dt_DevolucaoFim, fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Não Informado Nenhum Valor", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    cellTitle = new PdfPCell(new Phrase("Nome do Equipamento", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if (Relatorio.Nm_Equipamento != "")
                        cellTitle = new PdfPCell(new Phrase(Relatorio.Nm_Equipamento, fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Não Informado Nenhum Valor", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    cellTitle = new PdfPCell(new Phrase("Visto de Saida", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if (Relatorio.Nm_LocadorSaida != "")
                        cellTitle = new PdfPCell(new Phrase(Relatorio.Nm_LocadorSaida, fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Não Informado Nenhum Valor", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    cellTitle = new PdfPCell(new Phrase("Visto de Devolução", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if (Relatorio.Nm_LocadorDevolucao != "")
                        cellTitle = new PdfPCell(new Phrase(Relatorio.Nm_LocadorDevolucao, fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Não Informado Nenhum Valor", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    cellTitle = new PdfPCell(new Phrase("Retirado Por", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);

                    if (Relatorio.Nm_Locatario != "")
                        cellTitle = new PdfPCell(new Phrase(Relatorio.Nm_Locatario, fontTitle));
                    else
                        cellTitle = new PdfPCell(new Phrase("Não Informado Nenhum Valor", fontTitle));
                    subHeader1.HorizontalAlignment = 0;
                    table.AddCell(cellTitle);


                    doc.Add(table);

                    doc.Add(new Paragraph("\n\n\n"));

                    table = new PdfPTable(2);

                    header = new PdfPCell(new Phrase("IFSP - InfoQuario\nDetalhes do Relatorio Emitido", fontHeader));
                    header.Colspan = 2;
                    header.HorizontalAlignment = 1;
                    table.AddCell(header);

                    cellTitle = new PdfPCell(new Phrase("Data de Emissão", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase(DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToShortTimeString(), fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase("Emitido Por", fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    cellTitle = new PdfPCell(new Phrase(ClsLogin.UserLogado.Nm_Usuario + ", " + ClsLogin.UserLogado.Ds_Prontuario, fontTitle));
                    cellTitle.HorizontalAlignment = 1;
                    cellTitle.VerticalAlignment = 1;
                    table.AddCell(cellTitle);

                    doc.Add(table);                    
                    
                    doc.Close();
                    if (MessageBox.Show("Seu Relatorio Está Pronto!\n\nO Arquivo Está Salvo no Caminho :\n" + sfd.FileName + "\n\nDeseja Abrir o Arquivo Agora? ", "Pronto !", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString().ToUpper() == "YES")
                        Process.Start(sfd.FileName);

                    log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                    log.Ds_Log = "Gerou relatorio e exportou o arquivo como pdf";
                    log.Dt_Log = DateTime.Now;
                    log.Inserir();

                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("used by another process"))
                        MessageBox.Show("O Arquivo Selecionado Está Aberto\nEm Outro Local Feche-o e Tente Novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (MessageBox.Show("Falha ao Salvar Arquivo\n--Verifique se o Arquivo Está Aberto.\n--Verifique se o Caminho é Acessivel.\n\nPara ver a Descrição Completa do Erro Clique Sim.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                        MessageBox.Show(ex.ToString(), "Mensagem Completa do Erro");
                }
                finally
                {
                    doc.Close();
                }
            }
        }

        private void FrmRelatorio2_Load(object sender, EventArgs e)
        {
            dtpSaidaInicio.CustomFormat = dtpSaidaFim.CustomFormat = dtpDevolucaoInicio.CustomFormat = dtpDevolucaoFim.CustomFormat = "dd/MM/yyyy";

            
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnInfo, "Clique Abrir a Ajuda e Dicas");
        }

        private void CheckedRbts(object sender, EventArgs e)
        {
            if (rbtAbertos.Checked == true)
            {
                panelDataDevolucao.Visible = false;
                chkDataDevolucao.Checked = false;
                Relatorio.Ds_Status = 1;
            }
            else
            {
                panelDataDevolucao.Visible = true;
                if (rbtAmbos.Checked == true)
                    Relatorio.Ds_Status = 2;
                else
                    Relatorio.Ds_Status = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {            
            if (chkDataSaida.Checked == true)
            {
                Relatorio.Dt_SaidaInicio = dtpSaidaInicio.Value.ToString();
                Relatorio.Dt_SaidaFim = dtpSaidaFim.Value.ToString();
            }
            else
                Relatorio.Dt_SaidaFim = Relatorio.Dt_SaidaInicio = "";

            if (chkDataDevolucao.Checked == true)
            {
                Relatorio.Dt_DevolucaoInicio = dtpDevolucaoInicio.Value.ToString();
                Relatorio.Dt_DevolucaoFim = dtpDevolucaoFim.Value.ToString();
            }
            else
                Relatorio.Dt_DevolucaoFim = Relatorio.Dt_DevolucaoInicio = "";

            if (Relatorio.Nm_Equipamento == string.Empty)
                Relatorio.Nm_Equipamento = txtNomeEquipamento.Text;
            if (Relatorio.Nm_LocadorDevolucao == string.Empty)
                Relatorio.Nm_LocadorDevolucao = txtLocadorDevolucao.Text;
            if (Relatorio.Nm_LocadorSaida == string.Empty)
                Relatorio.Nm_LocadorSaida = txtNomeLocadorSaida.Text;
            if (Relatorio.Nm_Locatario == string.Empty)
                Relatorio.Nm_Locatario = txtLocatarioSaida.Text;
            
            string r = Relatorio.Grid();

            if (r == "OK")
            {
                gridReport.DataSource = Relatorio.Dt;
                gridReport.ReadOnly = true;
                gridReport.Columns[0].HeaderText = "Equipamento";
                gridReport.Columns[1].HeaderText = "Data-Hora Retirada";
                gridReport.Columns[2].HeaderText = "Soicitante";
                gridReport.Columns[3].HeaderText = "Visto de Saida";
                gridReport.Columns[4].HeaderText = "Data-Hora Prevista Devolução";
                gridReport.Columns[5].HeaderText = "Data-Hora Efetiva Devolução";
                gridReport.Columns[6].HeaderText = "Devolvido Por";
                gridReport.Columns[7].HeaderText = "Visto de Recebimento";
               

               // gridReport.Columns[0].Visible = false;
               // gridReport.Columns[0].Width = 0;

                gridReport.AutoResizeColumns();

                gridReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Enabled = true;

                if (gridReport.RowCount > 0)
                    btnSalvarFile.Visible = lblSalvarFile.Visible = true;
                else
                    btnSalvarFile.Visible = lblSalvarFile.Visible = false;
            }
            else if (MessageBox.Show("Ocorreu um erro ao tentar buscar dados\nClique Sim para ver a descrição completa do erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                MessageBox.Show(r, "Descrição Completa do Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNomeEquipamento.Text = txtNomeLocadorSaida.Text = txtLocadorDevolucao.Text = txtLocatarioSaida.Text = string.Empty;
            dtpDevolucaoFim.Value = dtpDevolucaoInicio.Value = dtpSaidaFim.Value = dtpSaidaInicio.Value = DateTime.Now;
            Relatorio = new ClsRelatorio();
            rbtAbertos.Checked = true;
            Relatorio.Ds_Status = 1;
            txtNomeEquipamento_TextChanged(null, null);
        }

        private void btnBuscarEquipamento_Click(object sender, EventArgs e)
        {
            ClsRelatorio.NomeResult = txtNomeEquipamento.Text;

            frmBuscarDados = new FrmBuscarDados("Buscando Nome Equipamento");
            
            frmBuscarDados.ShowDialog();
            Relatorio.Nm_Equipamento = txtNomeEquipamento.Text = ClsRelatorio.NomeResult;
            Relatorio.ID_Equipamento = ClsRelatorio.IdResult;
            ClsRelatorio.NomeResult = ClsRelatorio.ProntuarioResult = string.Empty; 
        }

        private void btnBuscarUsuarioSaida_Click(object sender, EventArgs e)
        {
            ClsRelatorio.NomeResult = txtNomeLocadorSaida.Text;

            frmBuscarDados = new FrmBuscarDados("Buscando Visto de Saida");
            frmBuscarDados.ShowDialog();
            Relatorio.ID_Locador_Saida = ClsRelatorio.IdResult;
            Relatorio.Nm_LocadorDevolucao = txtLocadorDevolucao.Text = ClsRelatorio.NomeResult;
            ClsRelatorio.NomeResult = ClsRelatorio.ProntuarioResult = string.Empty; 
        }

        private void btnBuscarLocatario_Click(object sender, EventArgs e)
        {
            ClsRelatorio.NomeResult = txtLocatarioSaida.Text;

            frmBuscarDados = new FrmBuscarDados("Buscando Solicitante");
            frmBuscarDados.ShowDialog();
            Relatorio.ID_Locatario_Saida = ClsRelatorio.IdResult;
            Relatorio.Nm_Locatario = txtLocatarioSaida.Text = ClsRelatorio.NomeResult;
            ClsRelatorio.NomeResult = ClsRelatorio.ProntuarioResult = string.Empty; 
        }

        private void btnBuscarUsuarioDevolucao_Click(object sender, EventArgs e)
        {
            ClsRelatorio.NomeResult = txtLocadorDevolucao.Text;

            frmBuscarDados = new FrmBuscarDados("Buscando Visto de Devolução");
            frmBuscarDados.ShowDialog();
            Relatorio.ID_Locador_Devolucao = ClsRelatorio.IdResult;
            Relatorio.Nm_LocadorDevolucao = txtLocadorDevolucao.Text = ClsRelatorio.NomeResult;
            ClsRelatorio.NomeResult = ClsRelatorio.ProntuarioResult = string.Empty;            
        }

        private void btnSalvarFile_Click(object sender, EventArgs e)
        {
            gerarPDF(); 
        }

        private void txtNomeEquipamento_TextChanged(object sender, EventArgs e)
        {
            if (txtLocatarioSaida.Text == string.Empty)
            {
                Relatorio.ID_Locatario_Saida = 0;
                Relatorio.Nm_Locatario = string.Empty;
            }

            if (txtNomeEquipamento.Text == string.Empty)
            {
                Relatorio.Nm_Equipamento = string.Empty;
                Relatorio.ID_Equipamento = 0;
            }

            if (txtNomeLocadorSaida.Text == string.Empty)
            {
                Relatorio.ID_Locador_Saida = 0;
                Relatorio.Nm_LocadorSaida = string.Empty;
            }

            if (txtLocadorDevolucao.Text == string.Empty)
            {
                Relatorio.ID_Locador_Devolucao = 0;
                Relatorio.Nm_LocadorDevolucao = string.Empty;
            }

        }

        private void panelDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string msg = "Nesta tela você pode visualizar e gerar relatorio sobre\n" +
                " todos os emprestimos registrados ate.\n" +
                "Você pode escolher o filtro que desejar, não são obrigatorios\n" +
                "--No Estado do emprestimo é escolhido qual estado deseja listar\n" +
                "--No campo data de saida é listado todos os emprestimos que tenham a data de saida\n" +
                "entre os valores informados.\n" +
                "--No campo data de devolução é listado todos os emprestimos fechados que tenham\n" +
                 "a data de devolução entre os valores informados ";
                 
            FrmInfo info = new FrmInfo(msg);
            info.ShowDialog();
        }    


       
    }
}
