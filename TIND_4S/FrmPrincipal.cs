using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TIND_4S
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            telaInicial();

            imgClose = btnClose.Image;
            imgMaximizar = btnMaximizar.Image;
            imgDesmaximizar = btnDesMaximizar.Image;
            imgMinimize = btnMinimizar.Image;
        }

        /*/Formularios Instaciados Prontos Para uso em seus respectivos botões/*/

        FrmUsuario            frmUser               = new FrmUsuario();
        FrmEquipamento        frmEquipamento        = new FrmEquipamento();        
        FrmPerfil             frmPerfil             = new FrmPerfil();        
        FrmEmprestimo         frmEmprestimo         = new FrmEmprestimo();
        FrmLog                frmLog                = new FrmLog();
        FrmRelatorio          frmReport             = new FrmRelatorio();

        Image imgMaximizar;
        Image imgDesmaximizar;
        Image imgClose;
        Image imgMinimize;
      
        Point point;
        Size size;

        int X = 0;
        int Y = 0;

        int[] posicoes = new int[5];

        public bool logoff = false;        
        private string aberto = "";


        private void telaInicial()
        {
            btnEmprestimos.Visible = false;
            btnGerarRelatorio.Visible = false;
            btnUsuarios.Visible = false;
            btnEquipamentos.Visible = false;            
            btnLog.Visible = false;

            posicoes[0] = 191;
            posicoes[1] = 245;
            posicoes[2] = 299;
            posicoes[3] = 353;
            posicoes[4] = 407;

            abrirPermissoes();
            mostarNomeUsuario();
            alterarPosicaoLblTitulo();
            alterarMenu(1);
            selecinarButton(btnInicio.Location.Y);
        }

        private void mostarNomeUsuario()
        {
            btnUser.Text = "     ";
            try{
                if (ClsLogin.UserLogado.Nm_Usuario.Length < 19)
                    btnUser.Text += ClsLogin.UserLogado.Nm_Usuario;
                else
                {
                    string[] nomes = ClsLogin.UserLogado.Nm_Usuario.Split(' ');

                    if (nomes.Length == 2 && nomes[0].Length < 19)
                        btnUser.Text += nomes[0];
                    else if (nomes.Length >= 3 && (nomes[0].Length + nomes[2].Length + 1 < 19))
                    {
                        btnUser.Text += nomes[0] + " " + nomes[2];
                    }
                    else if (nomes.Length >= 4 && (nomes[0].Length + nomes[3].Length + 1 < 19))
                    {
                        btnUser.Text += nomes[0] + " " + nomes[3];
                    }
                    else
                    {
                        if (nomes[0].Length < 19)
                            btnUser.Text = nomes[0];
                        else
                            btnUser.Text += "Perfil";
                    }
                }
            }
            catch
            {
                btnUser.Text += "Perfil";
            }            
        }
                
        private void abrirPermissoes()
        {
            int i = 0;
            int x = 2;
            if (ClsLogin.UserLogado.ID_Permissoes.Contains(3) || ClsLogin.UserLogado.ID_Permissoes.Contains(5))
            {
                btnUsuarios.Visible = true;                
                i++;
            }

            if (ClsLogin.UserLogado.ID_Permissoes.Contains(4))
            {
                btnEquipamentos.Visible = true;

                btnEquipamentos.Location = new Point(x, posicoes[i]);                
                i++;
            }

            if (ClsLogin.UserLogado.ID_Permissoes.Contains(2))
            {
                btnEmprestimos.Visible = true;
                               
                btnEmprestimos.Location = new Point(x, posicoes[i]);                
                i++;
            }

            if (ClsLogin.UserLogado.ID_Permissoes.Contains(1))
            {
                btnGerarRelatorio.Visible = true;

                btnGerarRelatorio.Location = new Point(x, posicoes[i]);
                i++;
            }

            if (ClsLogin.UserLogado.ID_Permissoes.Contains(6))
            {
                btnLog.Visible = true;
                
                btnLog.Location = new Point(x, posicoes[i]);
                i++;
            }
        }   

        private void alterarPosicaoLblTitulo()
        {
            int sobra = linha.Size.Width - lblIFSP.Size.Width;
            if (sobra % 2 == 0)
            {
                lblIFSP.Left = (sobra / 2);
            }
            else
            {
                sobra--;
                lblIFSP.Left = (sobra / 2) + 1;
            }
        }

        private void alterarMaximizedForms()
        {
            try
            {
                foreach (Form f in menuConteudo.Controls)
                {
                    f.Size = this.menuConteudo.Size;
                }
            }
            catch
            { }
            
        }

        private void alterarMenu(int p)
        {
            if (p == 0)
            {
                lblTitulo.Visible = false;
                btnMenu.Location = new Point(1, 15);
                btnMenu.Size = new System.Drawing.Size(50, 50);
                menuLateral.Size = new Size(56, menuLateral.Size.Height);
                btnMenu.Image = menuNormal.Image;
            }
            else
            {
                lblTitulo.Visible = true;
                btnMenu.Location = new Point(184, 10);
                btnMenu.Size = new System.Drawing.Size(40, 40);
                menuLateral.Size = new Size(260, menuLateral.Size.Height);
                btnMenu.Image = menuLeft.Image;
            }
        }
        
        private void selecinarButton(int y)
        {
            marcarBtnSelecionado.BackColor = Color.Green;
            marcarBtnSelecionado.Visible = true;
            marcarBtnSelecionado.Location = new Point(0, y); 
        }
        
        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (aberto != "frmReport")
            {
                frmReport = new FrmRelatorio();
                frmReport.TopLevel = false;
                menuConteudo.Controls.Clear();
                menuConteudo.Controls.Add(frmReport);
                aberto = "frmReport";
                alterarMaximizedForms();
                alterarMenu(0);
                selecinarButton((sender as Bunifu.Framework.UI.BunifuFlatButton).Location.Y);
                frmReport.Show();                
            }                      
        }
        
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            if (aberto != "frmUser")
            {
                frmUser = new FrmUsuario();
                frmUser.TopLevel = false;
                menuConteudo.Controls.Clear();
                menuConteudo.Controls.Add(frmUser);
                alterarMaximizedForms();
                alterarMenu(0);
                aberto = "frmUser";
                selecinarButton((sender as Bunifu.Framework.UI.BunifuFlatButton).Location.Y);
                frmUser.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnMenu, "Clique Para Mostar \\ Ocultar o Menu");
            toolTip1.SetToolTip(this.btnClose, "Clique Para Fechar o Sistema");
            toolTip1.SetToolTip(this.btnDesMaximizar, "Clique Para Desmaximizar a Tela");
            toolTip1.SetToolTip(this.btnEmprestimos, "Clique Para Gerenciar Emprestimos");
            toolTip1.SetToolTip(this.btnEquipamentos, "Clique Para Gerenciar os Equipamentos");
            toolTip1.SetToolTip(this.btnGerarRelatorio, "Clique Para Gerar\nRelatorio e Exportar como PDF");
            toolTip1.SetToolTip(this.btnInicio, "Clique Para Ir Para a Tela Inicial");
            toolTip1.SetToolTip(this.btnLog, "Clique Para Mostar\nHistorico de Uso do Sistema");
            toolTip1.SetToolTip(this.btnLogoff, "Clique Para Voltar Pra Tela de Login");
            toolTip1.SetToolTip(this.btnMaximizar, "Clique Para Maximizar a Tela");
            toolTip1.SetToolTip(this.btnMinimizar, "Clique Para Minimizar o Sistema");
            toolTip1.SetToolTip(this.btnUser, "Clique Para Mostar e Editar Seu Perfil");
            toolTip1.SetToolTip(this.btnUsuarios, "Clique Para Gerenciar os Usuarios do Sistema");
            toolTip1.SetToolTip(this.lblIFSP, "Clique Para Abrir o Site do IFSP-Capivari");
            ///toolTip1.SetToolTip(this.imgNaoMostarSenha, "Clique Para Ocultar\nA Senha Digitada");
            //toolTip1.SetToolTip(this.btnSair, "Clique Para Sair");
            //toolTip1.SetToolTip(this.btnIr, "Clique Para\nValidar o Login");
            //toolTip1.SetToolTip(this.btnInfo, "Clique Para Obter\nAjuda ou Informações");
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            if (aberto != "frmEquipamento")
            {
                frmEquipamento = new FrmEquipamento();
                frmEquipamento.TopLevel = false;
                menuConteudo.Controls.Clear();
                menuConteudo.Controls.Add(frmEquipamento);
                aberto = "frmEquipamento";
                alterarMaximizedForms();
                alterarMenu(0);
                selecinarButton((sender as Bunifu.Framework.UI.BunifuFlatButton).Location.Y);
                frmEquipamento.Show();
            }
        }
                
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            logoff = true;
            this.Close();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            if (aberto !=  "frmPerfil")
            {
                frmPerfil = new FrmPerfil();
                frmPerfil.TopLevel = false;
                menuConteudo.Controls.Clear();
                menuConteudo.Controls.Add(frmPerfil);                
                aberto = "frmPerfil";
                alterarMaximizedForms();
                alterarMenu(0);
                selecinarButton(btnUser.Location.Y);
                frmPerfil.Show();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            menuConteudo.Controls.Clear();
            selecinarButton(btnInicio.Location.Y);
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            if (aberto != "frmEmprestimo")
            {
                frmEmprestimo = new FrmEmprestimo();
                frmEmprestimo.TopLevel = false;
                menuConteudo.Controls.Clear();
                menuConteudo.Controls.Add(frmEmprestimo);
                aberto = "frmEmprestimo";
                alterarMaximizedForms();
                alterarMenu(0);
                selecinarButton((sender as Bunifu.Framework.UI.BunifuFlatButton).Location.Y);
                frmEmprestimo.Show();                
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (aberto != "frmLog")
            {
                frmLog = new FrmLog();
                frmLog.TopLevel = false;
                menuConteudo.Controls.Clear();
                menuConteudo.Controls.Add(frmLog);
                aberto = "frmLog";
                alterarMaximizedForms();
                alterarMenu(0);
                selecinarButton((sender as Bunifu.Framework.UI.BunifuFlatButton).Location.Y);
                frmLog.Show();                
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Visible == true)            
                alterarMenu(0);            
            else            
                alterarMenu(1);            
        }

        private void btnDesMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = size;
            this.Location = point;

            btnDesMaximizar.Visible = false;
            btnMaximizar.Visible = true;            
            //maximizado = false;
            alterarMaximizedForms();
            alterarPosicaoLblTitulo();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (!logoff)
                Application.Exit();
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            point = this.Location;
            size = this.Size;
            Screen tela = Screen.FromPoint(this.Location);
            this.Size = tela.WorkingArea.Size;
            this.Location = Point.Empty;
            btnDesMaximizar.Visible = true;
            btnMaximizar.Visible = false; 
            alterarMaximizedForms(); 
            alterarPosicaoLblTitulo();
        }

        private void MouseEnterBtnClose(object sender, EventArgs e)
        {
            btnClose.Image = IMGCloseRED.Image;
        }

        private void MouseLeaveBtnClose(object sender, EventArgs e)
        {
            btnClose.Image = imgClose;
        }

        private void enterBtnMaximise(object sender, EventArgs e)
        {
            btnMaximizar.Image = IMGmaximizeRED.Image;
        }

        private void leaveBtnMaximise(object sender, EventArgs e)
        {
            btnMaximizar.Image = imgMaximizar;
        }

        private void enterBtnMinimize(object sender, EventArgs e)
        {
            btnMinimizar.Image = IMGminimizarRED.Image;
        }

        private void leaveBtnMinimize(object sender, EventArgs e)
        {
            btnMinimizar.Image = imgMinimize;
        }

        private void btnDesMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnDesMaximizar.Image = IMGdesmaximarRED.Image;            
        }

        private void btnDesMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnDesMaximizar.Image = imgDesmaximizar;
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

        private void lblIFSP_Click(object sender, EventArgs e)
        {
            Process.Start("https://cpv.ifsp.edu.br/");
        }

        private void menuLateral_MouseEnter(object sender, EventArgs e)
        {
            //alterarMenu(1);
        }

        private void menuConteudo_MouseEnter(object sender, EventArgs e)
        {
            //lblIFSP.ButtonText = "entrou";
        }
    }
}
