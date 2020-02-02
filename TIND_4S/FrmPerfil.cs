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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
            telaInicial();            
        }

        ClsUsuario user;
         

        private void telaInicial()
        {
            this.Location = new Point(0, 0);
            user = new ClsUsuario();
            btnSalvar.Visible = lblSalvar.Visible = false;
            txtProntuario.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            carregarPermissoes();
            carregarDados();
            chkMostrarSenha.Focus();
        }

        private void carregarDados()
        {
            user.ID_Usuario = ClsLogin.UserLogado.ID_Usuario;
            string r = user.Consultar();
            if (r == "OK")
            {
                txtNome.Text = user.Nm_Usuario;
                txtProntuario.Text = user.Ds_Prontuario;
                txtUltimoLogin.Text = user.Dt_UltimoLogin;
                txtCadastro.Text = user.Dt_CadastroUsuario;
                
                btnEditar.Visible = lblEditar.Visible = true;
            }
            else
                falhaNoBanco(r, "Carregar Perfil");                
        }

        private void carregarPermissoes()
        {
            txtpermissoes.Text = string.Empty;
            for (int i = 0; i < ClsLogin.UserLogado.ID_Permissoes.Count; i++)
            {
                switch (ClsLogin.UserLogado.ID_Permissoes[i])
                {
                    case 1:
                        txtpermissoes.Text += "--Gerar Relatorios.\n";
                        break;

                    case 2:
                        txtpermissoes.Text += "--Gereciar Emprestimos.\n";
                        break;

                    case 3:
                        txtpermissoes.Text += "--Criar/Editar Usuarios.\n";
                        break;

                    case 4:
                        txtpermissoes.Text += "--Criar/Editar Equipamentos.\n";
                        break;

                    case 5:
                        txtpermissoes.Text += "--Excluir Usuarios/Senhas.\n";
                        break;
                    
                    case 6:
                        txtpermissoes.Text += "--Visualizar Registro de Uso\n";
                        break;
                }
            }
        }

        private void falhaNoBanco(string falha, string onde)
        {
            if (MessageBox.Show("Ocorreu Uma Falha\nAo Tentar " + onde + " Do Banco de Dados\n\nClique Sim Para Ver a \nDescrição Completa do Erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                MessageBox.Show(falha, "Descrição Completa do Erro", MessageBoxButtons.OK);
        }

        private async void menssagem(string messagem)
        {
            lblMenssagem.Text = messagem;
            lblMenssagem.Visible = true;
            await Task.Delay(2000);
            lblMenssagem.Visible = false;
            telaInicial();
        }              

        private void FrmPerfil_Load(object sender, EventArgs e)
        {           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;            
            txtSenha.Enabled = true;
            btnSalvar.Visible = lblSalvar.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show("--Preencher Corretamente o Campo Nome\n", "Antenção Corrija Os Seguintes Erros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                user.Nm_Usuario = txtNome.Text;
                if(txtSenha.Text != "**********")
                    user.Ds_Senha = txtSenha.Text;
                string r = user.Atualizar();
                if (r == "OK")
                    menssagem("Dados do Perfil Atualizados com Sucesso!");
                else
                    falhaNoBanco(r, "Atualizar Dados");
            }            
        }                

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaInicial();
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked == true)
                txtSenha.Text = user.Ds_Senha;
            else
                txtSenha.Text = "**********";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Location.X.ToString() + "  " + this.Location.Y.ToString());
        }

        private void panelDados_Paint(object sender, PaintEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            //toolTip1.SetToolTip(this.txtSenha, "Clique Para Mostar\nA Senha Digitada");
            //toolTip1.SetToolTip(this.imgNaoMostarSenha, "Clique Para Ocultar\nA Senha Digitada");
            //toolTip1.SetToolTip(this.btnSair, "Clique Para Sair");
        }      
    }
}
