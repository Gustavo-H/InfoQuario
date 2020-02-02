using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TIND_4S
{
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
            telaInicial();
        }

        ClsEmprestimoAberto EmprestimoAberto = new ClsEmprestimoAberto();
        ClsNovoEmprestimo NovoEmprestimo = new ClsNovoEmprestimo();
        ClsDevolucao Devolucao = new ClsDevolucao();
        ClsLog log = new ClsLog();
        string result;

        int IdLocatario = 0;

        string formatData = "dd/MM/yyyy HH:mm:ss";

        private void telaInicial()
        {
            //carregarEmprestimosAbertos();
            btnAbertos_Click(null, null);
        }

        private void alterarPosicaoLblTitulo()
        {/*
            int sobra = gridReport.Size.Width - lblTitulo.Size.Width;
            if (sobra % 2 == 0)
            {
                lblTitulo.Left = (sobra / 2) - 20;
            }
            else
            {
                sobra--;
                lblTitulo.Left = (sobra / 2) - 19;
            }*/
        }

        private void carregarListBox(ListBox lst)
        {
            if (lst.Name == "lstEquipamentoNovoEmprestimo")
            {
                result = NovoEmprestimo.Grid(lstTipoNovoEmprestimo.Text);

                if (result == "OK")
                {
                    lst.DataSource = NovoEmprestimo.Dt;
                    lst.DisplayMember = "Nome";
                    lst.ValueMember = "ID";
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            else
            {
                result = Devolucao.Grid(lstTipoDevolucao.Text);

                if (result == "OK")
                {
                    lst.DataSource = Devolucao.Dt;
                    lst.DisplayMember = "Nome";
                    lst.ValueMember = "ID";
                }
                else
                    falhaNoBanco(result, "Carregar Equipamentos"); 
            }
        }
        
        private void btnAbertos_Click(object sender, EventArgs e)
        {
            panelEmprestimosAbertos.Visible = true;
            panelEmprestimosAbertos.Dock = DockStyle.Fill;
            panelDevolucao.Visible = false;
            pnlNovoEmprestimo.Visible = false;
            carregarEmprestimosAbertos();
            btnNovoEmprestimo.ForeColor = btnDevolucao.ForeColor = Color.SeaGreen;
            btnAbertos.ForeColor = Color.Blue;
            
        }

        private void abrirDevolucao(object sender, DataGridViewCellMouseEventArgs e)
        {//2 cliquesna grid abertos leva para a devolução;
            btnDevolucao_Click(null, null);

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                lstTipoDevolucao.Select();// = EmprestimoAberto.Ds_TipoItem;
               // EmprestimoAberto.id;
                //MessageBox.Show(ClsLogin.UserLogado.Nm_Usuario);
            }
        }
                
        private void limparCampos()
        {
            txtDataPrevista.Text = string.Empty;
            txtDataRetirada.Text = string.Empty;
            txtNomeEquipamento.Text = string.Empty;
            txtNomeLocador.Text = string.Empty;
            txtNomeLocatario.Text = string.Empty;
            txtRALocador.Text = string.Empty;
            txtRALocatario.Text = string.Empty;
            txtTipoEquipamento.Text = string.Empty;

            txtNomeLocatarioDevolucao.Text = string.Empty;
            txtNomeLocatarioNovoEmprestimo.Text = string.Empty;
            txtProntuarioDevolucao.Text = string.Empty;
            txtProntuarioLocatarioNovoEmprestimo.Text = string.Empty;

            lstEquipamentoDevolucao.DataSource = null;
            lstEquipamentoNovoEmprestimo.DataSource = null;

            
            
            EmprestimoAberto = new ClsEmprestimoAberto();
            NovoEmprestimo = new ClsNovoEmprestimo();
            Devolucao = new ClsDevolucao();
        }

        private void falhaNoBanco(string falha, string onde)
        {
            if (MessageBox.Show("Erro Ao Tentar " + onde + " No Banco de Dados\n\nClique Sim Para Ver a \nDescrição Completa do Erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                MessageBox.Show(falha, "Descrição Completa do Erro", MessageBoxButtons.OK);
        }

        private void menssagem(string messagem)
        {
            /*lblMenssagem.Text = messagem;
            lblMenssagem.Visible = true;
            await Task.Delay(2000);
            lblMenssagem.Visible = false;*/
            MessageBox.Show(messagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        
        private int pegarID_Locatario(string nome, string prontuario)
        {
            int resultado = 0;
            if (IdLocatario > 0)
                return IdLocatario;
            else
            {                
                string result = NovoEmprestimo.InserirNovoLocador(nome, prontuario);
                try
                {
                    resultado = int.Parse(result);
                }
                catch
                {
                    falhaNoBanco(result, "Inserir Locatario");
                }                
            }                        
            return resultado;
        }
        
        private void carregarEmprestimosAbertos()
        {
            result = EmprestimoAberto.Grid();

            if (result == "OK")
            {
                gridAbertos.DataSource = EmprestimoAberto.Ds.Tables[0];
                gridAbertos.ReadOnly = true;
                gridAbertos.Columns[0].HeaderText = "ID";
                gridAbertos.Columns[1].HeaderText = "Item";
                gridAbertos.Columns[2].HeaderText = "Locatario";
                gridAbertos.Columns[3].HeaderText = "Locador";
                gridAbertos.Columns[4].HeaderText = "Data Saida";
                gridAbertos.Columns[5].HeaderText = "Devolução Prevista";

                gridAbertos.Columns[0].Visible = false;
                gridAbertos.Columns[0].Width = 0;

                gridAbertos.AutoResizeColumns();

                gridAbertos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                gridAbertos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridAbertos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridAbertos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //btnAbertos.BackColor = Color.LightGray;
                panelEmprestimosAbertos.Visible = true;

            }
            else
                MessageBox.Show(result, "Erro");
        }


        private void visualizarEmprestimo(object sender, DataGridViewCellMouseEventArgs e)
        {
            limparCampos();
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                EmprestimoAberto.ID_Emprestimo = int.Parse((gridAbertos.CurrentRow.Cells[0].Value).ToString());
                result = EmprestimoAberto.Consultar();

                if (result == "OK")
                {

                    txtDataPrevista.Text = EmprestimoAberto.Dt_PrevistaDevolucao;
                    txtDataRetirada.Text = EmprestimoAberto.Dt_Retirada;
                    txtNomeEquipamento.Text = EmprestimoAberto.Nm_Equipamento;
                    txtNomeLocador.Text = EmprestimoAberto.Nm_Locador;
                    txtNomeLocatario.Text = EmprestimoAberto.Nm_Locatario;
                    txtRALocador.Text = EmprestimoAberto.RA_Locador;
                    txtRALocatario.Text = EmprestimoAberto.RA_Locatario;
                    txtTipoEquipamento.Text = EmprestimoAberto.Ds_TipoItem;
                }
                else
                    MessageBox.Show(result, "Falha");
            }
        }
        
        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            lstTipoNovoEmprestimo.Items.Add("Selecione");
            lstTipoNovoEmprestimo.Items.Add("Sala/Lab");
            lstTipoNovoEmprestimo.Items.Add("Objeto");

            lstTipoDevolucao.Items.Add("Selecione");
            lstTipoDevolucao.Items.Add("Sala/Lab");
            lstTipoDevolucao.Items.Add("Objeto");

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.gridAbertos, "1 Clique Visualiza Detalhes");//\n2 Cliques Prossegue para Devolução");
            toolTip1.SetToolTip(this.btnAbertos, "Clique Para Visualizar\nOs Emprestimos Abertos");
            toolTip1.SetToolTip(this.btnBuscarDevolucao, "Clique Aqui Para Buscar\nUm Nome no Banco de Dados");
            toolTip1.SetToolTip(this.btnBuscarLocatarioNovoEmprestimo, "Clique Aqui Para Buscar\nUm Nome no Banco de Dados");
            toolTip1.SetToolTip(this.btnCancelarDevolucao, "Clique Aqui Cancelar\nA Operação Atual");
            toolTip1.SetToolTip(this.btnCancelarNovoEmprestimo, "Clique Aqui Cancelar\nA Operação Atual");
            toolTip1.SetToolTip(this.btnDevolucao, "Clique Aqui Para Abrir a Tela de Devolução de Item");
            toolTip1.SetToolTip(this.btnInfo, "Clique Abrir a Ajuda e Dicas");
            toolTip1.SetToolTip(this.btnNovoEmprestimo, "Clique Aqui a Tela de Novo Empréstimo");
            toolTip1.SetToolTip(this.btnSalvarDevolucao, "Clique Salvar\nA Devolução do Item");
            toolTip1.SetToolTip(this.btnSalvarNovoEmprestimo, "Clique Aqui Salvar o Novo Empréstiumo");

            dtpPrevista.CustomFormat = dtpRetirada.CustomFormat = formatData;
            dtpEfetivaDevolucao.CustomFormat = formatData;
        }

        private void btnNovoEmprestimo_Click_1(object sender, EventArgs e)
        {
            panelEmprestimosAbertos.Visible = false;
            panelDevolucao.Visible = false;
            pnlNovoEmprestimo.Visible = true;
            pnlNovoEmprestimo.Dock = DockStyle.Fill;
            txtVistoSaidaNovoEmprestimo.Text = ClsLogin.UserLogado.Nm_Usuario;
            lstTipoNovoEmprestimo.SelectedIndex = 0;
            btnDevolucao.ForeColor = btnAbertos.ForeColor = Color.SeaGreen;
            btnNovoEmprestimo.ForeColor = Color.Blue;
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            panelDevolucao.Visible = true;
            panelEmprestimosAbertos.Visible = false;
            pnlNovoEmprestimo.Visible = false;
            pnlNovoEmprestimo.Visible = false;
            panelDevolucao.Dock = DockStyle.Fill;
            txtVistoSaidaDevolucao.Text = ClsLogin.UserLogado.Nm_Usuario;
            lstTipoDevolucao.SelectedIndex = 0;
            btnAbertos.ForeColor = btnNovoEmprestimo.ForeColor = Color.SeaGreen;
            btnDevolucao.ForeColor = Color.Blue;
        }
          
        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListBox(lstEquipamentoNovoEmprestimo);
            if (lstEquipamentoNovoEmprestimo.Items.Count == 0)
            {
                lstEquipamentoNovoEmprestimo.DataSource = null;
                lstEquipamentoNovoEmprestimo.Items.Add("Nenhum Item Desse Tipo Está Disponivel. Tente outro tipo ou cadastre um novo item!");
                lstEquipamentoNovoEmprestimo.Enabled = false;
            }
            else
                lstEquipamentoNovoEmprestimo.Enabled = true;
               
        }

        private void txtNomeLocatarioNovoEmprestimo_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeLocatarioNovoEmprestimo.Text != string.Empty || txtProntuarioLocatarioNovoEmprestimo.Text != string.Empty)
            {
                groupBoxDatasNovoEmprestimo.Visible = true;
                dtpRetirada.Value = DateTime.Now;
                dtpPrevista.Value = DateTime.Now.AddHours(3.30);               
            }
        }

        private void lstEquipamentoNovoEmprestimo_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxLocatarioNovoEmprestimo.Visible = true;
        }

        private void FrmEmprestimo_Resize(object sender, EventArgs e)
        {
            //Eventos de maximizar ocorrem aqui;
        }

        private void btnCancelarNovoEmprestimo_Click(object sender, EventArgs e)
        {
            limparCampos();
            groupBoxDatasNovoEmprestimo.Visible = false;
            groupBoxLocatarioNovoEmprestimo.Visible = false;
            lstEquipamentoNovoEmprestimo.DataSource = null;
            IdLocatario = 0;
            lstTipoNovoEmprestimo.SelectedIndex = 0;
        }

        private void btnSalvarNovoEmprestimo_Click(object sender, EventArgs e)
        {
            if (txtNomeLocatarioNovoEmprestimo.Text == "" || txtProntuarioLocatarioNovoEmprestimo.Text == "" || txtProntuarioLocatarioNovoEmprestimo.Text == "CV")
                MessageBox.Show("Preencha corretamente os dados do Solicitante", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lstEquipamentoNovoEmprestimo.SelectedItem == null)
                MessageBox.Show("Selecione o Equipamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                NovoEmprestimo = new ClsNovoEmprestimo();
                NovoEmprestimo.ID_Locatario_Saida = pegarID_Locatario(txtNomeLocatarioNovoEmprestimo.Text, txtProntuarioLocatarioNovoEmprestimo.Text);
                if (NovoEmprestimo.ID_Locatario_Saida > 0)
                {
                    NovoEmprestimo.ID_Equipamento = int.Parse(lstEquipamentoNovoEmprestimo.SelectedValue.ToString());
                    NovoEmprestimo.Dt_Retirada = dtpRetirada.Text ;
                    NovoEmprestimo.Dt_PrevistaDevolucao = dtpPrevista.Text;
                    NovoEmprestimo.ID_Locador_Saida = ClsLogin.UserLogado.ID_Usuario;
                    result = NovoEmprestimo.Inserir();
                    if (result == "OK")
                    {                        
                        menssagem("Emprestimo Feito com Sucesso!");

                        log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                        log.Ds_Log = "Emprestou " + lstEquipamentoNovoEmprestimo.Text +" para " + txtNomeLocatarioNovoEmprestimo.Text; 
                        log.Dt_Log = DateTime.Now;
                        log.Inserir();

                        btnCancelarNovoEmprestimo_Click(null, null);
                    }
                    else
                    {
                        falhaNoBanco(result, "Inserir Emprestimo");
                    }
                    lstTipoNovoEmprestimo.SelectedIndex = 0;
                }
            }
        }

        private void btnBuscarLocatario_Click(object sender, EventArgs e)
        {
            FrmBuscarDados buscar = new FrmBuscarDados("Buscando Solicitante");
            buscar.ShowDialog();
            txtNomeLocatarioNovoEmprestimo.Text = ClsRelatorio.NomeResult;
            txtProntuarioLocatarioNovoEmprestimo.Text = ClsRelatorio.ProntuarioResult;
            IdLocatario = ClsRelatorio.IdResult;
        }

        private void groupBoxLocatarioNovoEmprestimo_Leave(object sender, EventArgs e)
        {

        }

        private void lstTipoDevolucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListBox(lstEquipamentoDevolucao);
            if (lstEquipamentoDevolucao.Items.Count == 0)
            {
                lstEquipamentoDevolucao.DataSource = null;
                lstEquipamentoDevolucao.Items.Add("Nenhum Item Desse Tipo Está Emprestado. Tente outro tipo!");
                lstEquipamentoDevolucao.Enabled = false;
            }
            else
                lstEquipamentoDevolucao.Enabled = true;
        }

        private void lstEquipamentoDevolucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxLocatarioDevolucao.Visible = true;
        }

        private void btnBuscarDevolucao_Click(object sender, EventArgs e)
        {             
            FrmBuscarDados buscar = new FrmBuscarDados("Buscando Solicitante");
            buscar.ShowDialog();
            txtNomeLocatarioDevolucao.Text = ClsRelatorio.NomeResult;
            txtProntuarioDevolucao.Text = ClsRelatorio.ProntuarioResult;
            IdLocatario = ClsRelatorio.IdResult;
        }

        private void btnCancelarDevolucao_Click(object sender, EventArgs e)
        {
            IdLocatario = 0;
            limparCampos();
            groupBoxDatasDevolucao.Visible = false;
            groupBoxLocatarioDevolucao.Visible = false;
            lstTipoDevolucao.SelectedIndex = 0;
        }

        private void txtNomeLocatarioDevolucao_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeLocatarioDevolucao.Text != "" && txtProntuarioDevolucao.Text != "")
            {
                groupBoxDatasDevolucao.Visible = true;
                dtpEfetivaDevolucao.Value = DateTime.Now;                
            }
        }

        private void btnSalvarDevolucao_Click(object sender, EventArgs e)
        {
            if (txtNomeLocatarioDevolucao.Text != "" && txtProntuarioDevolucao.Text != "" && txtProntuarioDevolucao.Text != "CV")
            {
                Devolucao.ID_Emprestimo = int.Parse(Devolucao.Consultar(int.Parse(lstEquipamentoDevolucao.SelectedValue.ToString())));//;;));
                Devolucao.Dt_EfetivaDevolucao = dtpEfetivaDevolucao.Text;
                Devolucao.ID_Locador_Devolucao = ClsLogin.UserLogado.ID_Usuario;
                Devolucao.ID_Locatario_Devolucao = pegarID_Locatario(txtNomeLocatarioDevolucao.Text, txtProntuarioDevolucao.Text);

                result = Devolucao.Atualizar();
                if (result == "OK")
                {

                    log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                    log.Ds_Log = "Recebeu " + lstEquipamentoDevolucao.Text + " de " + txtNomeLocatarioDevolucao.Text;
                    log.Dt_Log = DateTime.Now;
                    log.Inserir();

                    menssagem("Devolução Feito com Sucesso!");
                    IdLocatario = 0;
                    btnCancelarDevolucao_Click(null, null);
                    telaInicial();
                }
                else
                    falhaNoBanco(result, "Inserir Devolução");
                lstTipoDevolucao.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Preecha Corretamente os Campos de ");
        }

        private void btnAbertos_MouseLeave(object sender, EventArgs e)
        {
            if (panelDevolucao.Visible == true)
                btnDevolucao.ForeColor = Color.Blue;
            if (pnlNovoEmprestimo.Visible == true)
                btnNovoEmprestimo.ForeColor = Color.Blue;
            if (panelEmprestimosAbertos.Visible == true)
                btnAbertos.ForeColor = Color.Blue;
                
        }

        private void validarProntuario(object sender, KeyPressEventArgs e)
        {
            (sender as TextBox).CharacterCasing = CharacterCasing.Upper;
            (sender as TextBox).MaxLength = 10;

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else if ((sender as TextBox).TextLength < 2 && char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if ((sender as TextBox).TextLength == 9 && e.KeyChar.ToString().ToLower() == Keys.X.ToString().ToLower())
                e.Handled = false;
            else if ((sender as TextBox).TextLength >= 2 && char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string msg = "Nesta tela você pode visualizar os emprestimos abertos,\n" +
            "emprestar um novo item e efetuar a devolução de um item.\n" +
            "\n--Para visualizar os abertos basta clicar no botão Visualizar Abertos\n" +
            "\n--Para emprestar um novo item primeiro selecione o tipo do item, apos isto\n" + 
            "sera listado ao lado os nomes dos itens disponiveis, basta selecionar o item\n" +
            "que deseja. depois basta preencher o nome e prontuario de quem esta retirando o item\n" + 
            "por fim selecione a data prevista de devolução e clique em salvar\n\n" + 
            "--Para cadastrar uma devolução clique no botão devolução, primeiro selecione o tipo do item,\n"+
            "em seguida será listado os itens desse tipo que estãos emprestados, escolha qual quer devolver\n" +
            "por fim preencha o nome e prontuario de quem devolveu e clique em salvar.";

            FrmInfo info = new FrmInfo(msg);
            info.ShowDialog();
        }
    }
}
