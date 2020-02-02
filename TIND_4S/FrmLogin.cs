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
    public partial class FrmLogin : Form 
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MouseDownFrm);
            this.MouseMove += new MouseEventHandler(MouseMoveFrm);

            txtLogin.Text = txtSenha.Text = "admin";
        }        

        int clique = 0;
        int X = 0;
        int Y = 0;

        ClsLogin login;
        Image imgBKP;
               
        private async void validarLogin()
        {
            await Task.Delay(100);
            login = new ClsLogin();

            login.Ds_Senha = txtSenha.Text;
            login.Ds_Prontuario = txtLogin.Text;

            string resultado = login.validarLogin();

            if (resultado.Length > 5)
            {
                falhaNoBanco(resultado, "Tentar Validar Login no Servidor");
                lblMenssage.Visible = false;
                btnIr.Enabled = true;
            }

            else if (Convert.ToBoolean(resultado))
                loginValido();

            else
                loginInvalido();             
        }

        private async void loginValido()
        {            
            lblSuperior.BackColor = Color.ForestGreen;
            menssagem(Color.SeaGreen, "Login Feito Com Sucesso");
            await Task.Delay(100);
            FrmPrincipal frmPrincipal = new FrmPrincipal();           
            this.Hide();
            frmPrincipal.ShowDialog();
            btnIr.Enabled = true;
            
            this.Show();
            txtSenha.Text = string.Empty;
            lblSuperior.BackColor = Color.Red;
        }

        private async void loginInvalido()
        {            
            lblSuperior.BackColor = Color.Red;
            menssagem(Color.Red, "Login ou Senha Invalidos");
            await Task.Delay(1500);
            //lblMenssage.Visible = false;   
            btnIr.Enabled = true; 
        }

        private bool verificarCampos()
        {
            bool verificar = true;

            string erros = string.Empty;

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                erros = "--Preencher Corretamente o Campo Prontuario\n";
                verificar = false;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                erros += "--Preencher Corretamente o Campo Senha\n";
                verificar = false;
            }

            if (erros != string.Empty)
            {
                if (erros.Length > 48)
                    MessageBox.Show(erros, "Antenção Corrija Os Seguintes Erros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show(erros, "Antenção Corrija O Seguinte Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnIr.Enabled = true;
            }
                return verificar;
        }

        private void falhaNoBanco(string falha, string onde)  //Ao Tentar Conectar Ao Servidor
        {
            if (MessageBox.Show("Erro " + onde +"\n\nClique Sim Para Ver a \nDescrição Completa do Erro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                MessageBox.Show(falha, "Descrição Completa do Erro", MessageBoxButtons.OK);
        }

        private async void cliqueBtnIr()
        {
            menssagem(Color.Blue, "Validando Login . . .");

            if (clique > 0)
                await Task.Delay(500);

            validarLogin();
            clique++;            
        }

        private async void menssagem(Color cor, string texto)
        {
            lblMenssage.Text = texto;
            lblMenssage.ForeColor = cor;
            lblMenssage.Visible = true;

            if (cor == Color.ForestGreen)
            {
                lblSuperior.BackColor = cor;
                await Task.Delay(1800);
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.imgMostrarSenha, "Clique Para Mostar\nA Senha Digitada");
            toolTip1.SetToolTip(this.imgNaoMostarSenha, "Clique Para Ocultar\nA Senha Digitada");
            toolTip1.SetToolTip(this.btnSair, "Clique Para Sair");
            toolTip1.SetToolTip(this.btnIr, "Clique Para\nValidar o Login");
            toolTip1.SetToolTip(this.btnInfo, "Clique Para Obter\nAjuda ou Informações");
            toolTip1.SetToolTip(this.txtLogin, "Digite Seu Prontuario Aqui");
            toolTip1.SetToolTip(this.txtSenha, "Digite Sua Senha Aqui");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            btnIr.Enabled = false;
            if (verificarCampos())
                cliqueBtnIr();            
        }

        private void imgNaoMostarSenha_Click(object sender, EventArgs e)
        {
            imgNaoMostarSenha.Visible = false;
            imgMostrarSenha.Visible = true;
            txtSenha.isPassword = true;
        }

        private void imgMostrarSenha_Click(object sender, EventArgs e)
        {
            imgNaoMostarSenha.Visible = true;
            imgMostrarSenha.Visible = false;
            txtSenha.isPassword = false;
        }

        private void MouseDownFrm(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void MouseMoveFrm(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Logar no Sistema e necessario ter um login ja registrado\nCaso Você não tenha contate o administrador");
        }

        
        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            imgBKP = btnSair.Image;
            btnSair.Image = IMG_RED.Image;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.Image = imgBKP;
        }             
    }
}