using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIND_4S
{
    public partial class FrmUsuario : Form
    {       
        public FrmUsuario()
        {
            InitializeComponent();
            telaInicial();
        }        
        
        ClsUsuario user;
        ClsLog log = new ClsLog();
        string resultado;
         

        private async void menssagem(string messagem)
        {
            lblMensagem.Text = messagem;
            lblMensagem.Visible = true;
            await Task.Delay(2000);
            lblMensagem.Visible = false;            
            //telaInicial();
        }              

        private void telaInicial()
        {
            user = new ClsUsuario();          
            carregarFuncionalidades();
            limparCampos();

            gridUsuarios.DataSource = null;

            clbPermissoes.Enabled = false;
            
            panelDados.Enabled = false;
            gridUsuarios.Enabled = false;
            btnBuscar.Visible = false;            
            btnDesativar.Visible = false;
            
            btnRedefinirSenha.Visible = false;
            btnSalvar.Visible = false;

            lblBuscar.Visible = false;
            lblCadastro.Visible = false;           
            lblDesativar.Visible = false;
            
            lblRedefinirSenha.Visible = false;
            lblSalvar.Visible = false;
            lblUltimoLogin.Visible = false;

            txtUltimoLogin.Visible = false;
            txtCadastro.Visible = false;
            txtProntuario.Enabled = true;
                     
            abrirPermissoes(1);
        }
          
        private void limparCampos()
        {
            txtCadastro.Text = txtProntuario.Text = txtNome.Text = txtSenha.Text = txtUltimoLogin.Text = string.Empty;            
            for (int i = 0; i < clbPermissoes.Items.Count; i++)
                clbPermissoes.SetItemChecked(i, false);
            txtNome.Focus();
        }

        private void abrirPermissoes(int p)
        {
            if (p == 1)
            {
                if (ClsLogin.UserLogado.ID_Permissoes.Contains(3))
                {
                    btnBuscar.Visible = lblBuscar.Visible = btnLimparCampos.Visible = lblLimparCampos.Visible = true;
                    btnSalvar.Visible = lblSalvar.Visible = true;
                    panelDados.Enabled = true;
                    panelDados.Visible = true;
                    panelOpcoes.Enabled = true;
                    panelOpcoes.Visible = true;
                    gridUsuarios.Enabled = true;
                    clbPermissoes.Enabled = true;
                    btnRedefinirSenha.Visible = lblRedefinirSenha.Visible = false;
                    btnDesativar.Visible = lblDesativar.Visible = false;
                }                
            }
            else
            {
                if (ClsLogin.UserLogado.ID_Permissoes.Contains(5))
                {
                    btnRedefinirSenha.Visible = lblRedefinirSenha.Visible = true;
                    btnDesativar.Visible = lblDesativar.Visible = true;
                    btnSalvar.Visible = lblSalvar.Visible = true;
                }
            }
        }

        private void carregarFuncionalidades()
        {
            resultado = user.getFuncionalidades();

            if (resultado == "OK")
            {
                clbPermissoes.DataSource = user.Ds.Tables[0];
                clbPermissoes.DisplayMember = "Descricao";
                clbPermissoes.ValueMember = "ID";
                //cltPermissoes.DataBind();
            }
            else            
                falhaNoBanco(resultado, "Carregar Permissões");            
        }

        private void falhaNoBanco(string falha, string onde)
        {
            if (MessageBox.Show("Erro Ao Tentar " + onde + " No Banco de Dados\n\nClique Sim Para Ver a \nDescrição Completa do Erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
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

            if (string.IsNullOrWhiteSpace(txtProntuario.Text))
            {
                erros += "--Preencher Corretamente o Campo RA\n";
                verificar = false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erros += "--Preencher Corretamente o Campo Senha\n";
                verificar = false;
            }
            
            if (!(user.ID_Usuario > 0) && !ClsUsuario.validarProntuario(txtProntuario.Text))
            {
                erros += "--Prontuario Invalido ou Já Existente, Escolha Outro\n";
                verificar = false;
            }

            if (clbPermissoes.CheckedIndices.Count < 1)
            {
                erros += "--Selecione Pelo Menos Uma Permissão Para Este Usuario\n";
                verificar = false;
            }

            if (erros != string.Empty)
                if (erros.Length > 56)
                    MessageBox.Show(erros, "Antenção Corrija Os Seguintes Erros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show(erros, "Antenção Corrija O Seguinte Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return verificar;
        }

        private void carregarUsuario(int id)
        {
            user = new ClsUsuario();
            user.ID_Usuario = id;
            resultado = user.Consultar();
            
            if (resultado == "OK")
            {                
                txtNome.Text = user.Nm_Usuario;
                txtProntuario.Text = user.Ds_Prontuario;
                txtCadastro.Text = user.Dt_CadastroUsuario;
                txtUltimoLogin.Text = user.Dt_UltimoLogin;
                txtSenha.Text = user.Ds_Senha;
                
                if (txtCadastro.Text != txtUltimoLogin.Text)
                {
                    txtSenha.Text = "**********";                  
                }

                for (int i = 0; i < user.ID_Permissoes.Count; i++)
                {
                     clbPermissoes.SetItemChecked(user.ID_Permissoes[i] - 1, true);
                }
            }
            else
            {
                falhaNoBanco(user.Nm_Usuario, "Carregar Usuario");
            }
        }        

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.txtNome, "Insira aqui o nome do usuario");
            toolTip1.SetToolTip(this.txtProntuario, "Insira aqui o prontuario do usuario");            
            toolTip1.SetToolTip(this.gridUsuarios, "1 Clique Visualiza\n2 Cliques Edita");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (panelDados.Enabled == false)
            {
                telaInicial();
            }
            else
            {
                user = new ClsUsuario();
                user.Nm_Usuario = txtNome.Text;
                user.Ds_Prontuario = txtProntuario.Text;

                resultado = user.Grid();

                if (resultado == "OK")
                {
                    gridUsuarios.DataSource = user.Ds.Tables[0];
                    gridUsuarios.ReadOnly = true;
                    gridUsuarios.Columns[0].HeaderText = "ID";
                    gridUsuarios.Columns[1].HeaderText = "Nome";
                    gridUsuarios.Columns[2].HeaderText = "Login";

                    gridUsuarios.Columns[0].Visible = false;
                    gridUsuarios.Columns[0].Width = 0;

                    gridUsuarios.AutoResizeColumns();

                    gridUsuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //gridAlunos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    // gridEquipamentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    falhaNoBanco(resultado, "Buscar Dados");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                user.Nm_Usuario = txtNome.Text;
                user.Ds_Prontuario = txtProntuario.Text;
                if(txtSenha.Text != "**********")
                    user.Ds_Senha = txtSenha.Text;

                user.ID_Permissoes = new List<int>();
                foreach (int id in clbPermissoes.CheckedIndices)
                {
                    user.ID_Permissoes.Add(id+1);
                }

                if (user.ID_Usuario > 0)
                {
                    resultado = user.Atualizar();
                    if (resultado == "OK")
                    {
                        menssagem("Usuario Atualizado Com Sucesso");
                        log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                        log.Ds_Log = "Atualizou os dados do usuario " + user.Nm_Usuario + " no banco de dados";
                        log.Dt_Log = DateTime.Now;
                        log.Inserir();
                    }
                    else
                        falhaNoBanco(resultado, "Atualizar Usuario");                    
                }
                else
                {
                    resultado = user.Inserir();
                    if (resultado == "OK")
                    {
                        menssagem("Usuario Inserido Com Sucesso");
                        log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                        log.Ds_Log = "Inseriu o usuario " + user.Nm_Usuario + " no banco de dados";
                        log.Dt_Log = DateTime.Now;
                        log.Inserir();
                    }
                    else
                        falhaNoBanco(resultado, "Inserir Usuario");
                }
                telaInicial();
            }
        }

        private void visualizarUsuario(object sender, DataGridViewCellMouseEventArgs e)
        {
            limparCampos();
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                carregarUsuario(int.Parse((gridUsuarios.CurrentRow.Cells[0].Value).ToString()));
            }
            panelDados.Enabled = false;
            btnLimparCampos.Visible = lblLimparCampos.Visible = false;
            btnSalvar.Visible = lblSalvar.Visible = false;
            btnRedefinirSenha.Visible = lblRedefinirSenha.Visible = false;
            btnDesativar.Visible = lblDesativar.Visible = false;
        }

        private void editarUsuario(object sender, DataGridViewCellMouseEventArgs e)
        {
            limparCampos();
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                carregarUsuario(int.Parse((gridUsuarios.CurrentRow.Cells[0].Value).ToString()));
                abrirPermissoes(2);
                panelDados.Enabled = true;
                btnLimparCampos.Visible = lblLimparCampos.Visible = true;
                if (user.ID_Usuario == ClsLogin.UserLogado.ID_Usuario)
                    clbPermissoes.Enabled = false;
            }
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Redefinir a Senha ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString().ToUpper() == "YES")
            {
                txtSenha.Text = string.Empty;
                MessageBox.Show("Basta Escolher Qual Será a Nova Senha e Salvar as Alterações", "Pronto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                txtSenha.Enabled = true;
                log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                log.Ds_Log = "Resetou a senha do usuario " + user.Nm_Usuario;
                log.Dt_Log = DateTime.Now;
                log.Inserir();
                txtSenha.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja\nExcluir Permanentemente Este Usuario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString().ToUpper() == "YES")
            {          
                resultado = user.Excluir();
                if (resultado == "OK")
                {
                    menssagem("Usuario Excluido Com Sucesso");
                    log.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
                    log.Ds_Log = "Apagou permanentemente o usuario " + user.Nm_Usuario + " do banco de dados";
                    log.Dt_Log = DateTime.Now;
                    log.Inserir();                    
                }
                else
                    falhaNoBanco(resultado, "Excluir Usuario");

                telaInicial();
            }        
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            telaInicial();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void validarProntuario(object sender, KeyPressEventArgs e)
        {
            (sender as TextBox).CharacterCasing = CharacterCasing.Upper;
            (sender as TextBox).MaxLength = 10;

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else if (txtProntuario.TextLength < 2 && char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (txtProntuario.TextLength == 9 && e.KeyChar.ToString().ToLower() == Keys.X.ToString().ToLower())
                e.Handled = false;
            else if (txtProntuario.TextLength >= 2 && char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }               
    }
}
