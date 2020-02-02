using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIND_4S
{
    public partial class FrmEquipamento : Form
    {
        public FrmEquipamento()
        {
            InitializeComponent();
            lstTipo.Items.Add("Selecione");
            lstTipo.Items.Add("Sala/Lab");
            lstTipo.Items.Add("Objeto");

            btnCancelar_Click(null, null);
        }

        ClsEquipamento Equipamento = new ClsEquipamento();
        string result = string.Empty;

        ClsLog log = new ClsLog();

        private async void menssagem(string messagem)
        {
            lblMenssagem.Text = messagem;
            lblMenssagem.Visible = true;
            await Task.Delay(2000);
            lblMenssagem.Visible = false;
            limparCampos();
           // telaInicial();
        }

        private void limparCampos()
        {
            txtNome.Text = txtNumero.Text = string.Empty;
            lstTipo.SelectedIndex = 0;
        }

        private void falhaNoBanco(string falha, string onde)
        {
            if (MessageBox.Show("Ocorreu um Erro Ao Tentar " + onde + "\n\nClique Sim Para Ver a \nDescrição Completa do Erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                MessageBox.Show(falha, "Descrição Completa do Erro", MessageBoxButtons.OK);
        }

        private bool verificarCampos()
        {
            bool verificar = true;

            string erros = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                erros = "--Preencher Corretamente o Campo Nome\n";
                verificar = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                erros += "--Preencher Corretamente o Campo Numero\n";
                verificar = false;
            }   

            if (lstTipo.SelectedItem == null || lstTipo.SelectedItem.ToString() == "Selecione")
            {
                erros += "--Preencher Corretamente o Campo Tipo\n";
                verificar = false;
            }

            try
            {
                Equipamento.Nm_Equipamento = txtNome.Text;
                Equipamento.Nr_Equipamento = int.Parse(txtNumero.Text);
                if (bool.Parse(Equipamento.ConsultarExistente()))
                {
                    erros += "--Combinação de nome e numero já existente\n";
                    verificar = false;
                }
            }
            catch
            {
                falhaNoBanco(Equipamento.ConsultarExistente(), "Verificar Item Existente");
                return false;
            }
                       

            if (erros != string.Empty)
                if (erros.Length > 43)
                    MessageBox.Show(erros, "Antenção Corrija Os Seguintes Erros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show(erros, "Antenção Corrija O Seguinte Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return verificar;
        }

        private void carregarEquipamento(int id)
        {
            Equipamento = new ClsEquipamento();
            Equipamento.ID_Equipamento = id;
            result = Equipamento.Consultar();
            if (result == "OK")
            {
                txtNome.Text = Equipamento.Nm_Equipamento;
                txtNumero.Text = Equipamento.Nr_Equipamento.ToString();
                lstTipo.Text = Equipamento.Ds_Tipo;
            }
            else
                falhaNoBanco(result, "Carregar Equipamento");            
        }

        private void visualizarEquipamento(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                carregarEquipamento(int.Parse((gridEquipamento.CurrentRow.Cells[0].Value).ToString()));
                panelDados.Enabled = false;
                lblExcluir.Visible = btnExcluir.Visible = false;
            }

        }

        private void editarEquipamento(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                carregarEquipamento(int.Parse((gridEquipamento.CurrentRow.Cells[0].Value).ToString()));
                try
                {
                    btnExcluir.Visible = lblExcluir.Visible = true;
                    panelDados.Enabled = true;
                    txtNome.Focus();
                }
                catch { }
            }
        }
        
        private void FrmEquipamento_Load(object sender, EventArgs e)
        {           
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.gridEquipamento, "1 Clique Visualiza\n2 Cliques Edita");
            //toolTip1.SetToolTip(this.imgNaoMostarSenha, "Clique Para Ocultar\nA Senha Digitada");
           // toolTip1.SetToolTip(this.btnSair, "Clique Para Sair");
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Equipamento = new ClsEquipamento();

            Equipamento.Nm_Equipamento = txtNome.Text;           

            try
            {
                Equipamento.Nr_Equipamento = int.Parse(txtNumero.Text);
                if (lstTipo.SelectedValue.ToString() != "Selecione")
                    Equipamento.Ds_Tipo = lstTipo.Text;
                else
                    Equipamento.Ds_Tipo = string.Empty;
            }
            catch 
            {
                Equipamento.Nr_Equipamento = 0;
                Equipamento.Ds_Tipo = "";
            }


            if (Equipamento.Grid() == "OK")
            {
                gridEquipamento.DataSource = Equipamento.Ds.Tables[0];
                gridEquipamento.ReadOnly = true;
                gridEquipamento.Columns[0].HeaderText = "ID";
                gridEquipamento.Columns[1].HeaderText = "Nome";
                gridEquipamento.Columns[2].HeaderText = "Numero";
                gridEquipamento.Columns[3].HeaderText = "Tipo";

                gridEquipamento.Columns[0].Visible = false;
                gridEquipamento.Columns[0].Width = 0;

                gridEquipamento.AutoResizeColumns();

                gridEquipamento.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //gridAlunos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                // gridEquipamentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridEquipamento.Enabled = true;
            }
            else
            {
                MessageBox.Show(Equipamento.Grid());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {           
            if (verificarCampos())
            {
                Equipamento.Nm_Equipamento = txtNome.Text;
                Equipamento.Nr_Equipamento = int.Parse(txtNumero.Text);
                Equipamento.Ds_Tipo = lstTipo.Text;

                if (Equipamento.ID_Equipamento > 0)   //Editando 
                {
                    result = Equipamento.Atualizar();
                    if (result == "OK")
                    {
                        menssagem("Equipamento Alterado Com Sucesso!");
                        log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                        log.Ds_Log = "Atualizou os dados do item " + Equipamento.Nm_Equipamento + " " + Equipamento.Nr_Equipamento.ToString() + " no banco de dados";
                        log.Dt_Log = DateTime.Now;
                        log.Inserir();
                    }
                    else
                        falhaNoBanco(result, "Atualizar Equipamento");                        
                }
                else //Inserindo 
                {
                    result = Equipamento.Inserir();
                    if (result == "OK")
                    {
                        menssagem("Equipamento Inserido Com Sucesso!");
                        log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                        log.Ds_Log = "Inseriu o item " + Equipamento.Nm_Equipamento + " " + Equipamento.Nr_Equipamento.ToString() + " no banco de dados";
                        log.Dt_Log = DateTime.Now;
                        log.Inserir();
                    }
                    else
                        falhaNoBanco(result, "Inserir Equipamento");  
                }
                btnCancelar_Click(null, null);
                btnBuscar_Click(null, null);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Este item será apagado permantemente do banco de dados\nVocê tem certeza disso?", "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString().ToUpper() == "YES")
                {
                    result = Equipamento.Excluir();

                    if (result == "OK")
                    {
                        menssagem("Equipamento Excluido Com Sucesso");
                        log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                        log.Ds_Log = "Excluiu o item " + Equipamento.Nm_Equipamento + " " + Equipamento.Nr_Equipamento.ToString() + " do banco de dados";
                        log.Dt_Log = DateTime.Now;
                        log.Inserir();
                    }
                    else
                    {
                        if (result.Contains("REFERENCE constraint"))
                            MessageBox.Show("Não será possivel excluir este equipamento\nPois o mesmo possui historico de empréstimo\nA sua exlusão acarretaria em perca de dados importantes", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            falhaNoBanco(result, "Excluir Equipamento");
                    }
                    btnCancelar_Click(null, null);
                }                    
            }
            catch { }            
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();           
            
        }

        private void validarNumero(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {           
            limparCampos();
            Equipamento = new ClsEquipamento();
            lstTipo.SelectedIndex = 0;
            gridEquipamento.DataSource = null;
            btnExcluir.Visible = lblExcluir.Visible = false;
            txtNome.Focus();
        }              
    }
}
