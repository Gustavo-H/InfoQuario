namespace TIND_4S
{
    partial class FrmPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.panelDados = new ns1.BunifuCards();
            this.chkMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtpermissoes = new System.Windows.Forms.RichTextBox();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.panelOpcoes = new System.Windows.Forms.GroupBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txtUltimoLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.lblUltimoLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panelDados.SuspendLayout();
            this.panelOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDados
            // 
            this.panelDados.BackColor = System.Drawing.Color.Transparent;
            this.panelDados.BorderRadius = 5;
            this.panelDados.BottomSahddow = true;
            this.panelDados.color = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(165)))), ((int)(((byte)(80)))));
            this.panelDados.Controls.Add(this.chkMostrarSenha);
            this.panelDados.Controls.Add(this.txtpermissoes);
            this.panelDados.Controls.Add(this.lblMenssagem);
            this.panelDados.Controls.Add(this.panelOpcoes);
            this.panelDados.Controls.Add(this.label2);
            this.panelDados.Controls.Add(this.txtNome);
            this.panelDados.Controls.Add(this.label16);
            this.panelDados.Controls.Add(this.label1);
            this.panelDados.Controls.Add(this.lblCadastro);
            this.panelDados.Controls.Add(this.txtUltimoLogin);
            this.panelDados.Controls.Add(this.label3);
            this.panelDados.Controls.Add(this.txtProntuario);
            this.panelDados.Controls.Add(this.txtCadastro);
            this.panelDados.Controls.Add(this.lblUltimoLogin);
            this.panelDados.Controls.Add(this.txtSenha);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDados.LeftSahddow = false;
            this.panelDados.Location = new System.Drawing.Point(0, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.RightSahddow = true;
            this.panelDados.ShadowDepth = 20;
            this.panelDados.Size = new System.Drawing.Size(1514, 775);
            this.panelDados.TabIndex = 300;
            this.panelDados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDados_Paint);
            // 
            // chkMostrarSenha
            // 
            this.chkMostrarSenha.AutoSize = true;
            this.chkMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarSenha.Location = new System.Drawing.Point(1081, 121);
            this.chkMostrarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.chkMostrarSenha.Name = "chkMostrarSenha";
            this.chkMostrarSenha.Size = new System.Drawing.Size(86, 44);
            this.chkMostrarSenha.TabIndex = 1;
            this.chkMostrarSenha.Text = "Mostrar \r\nSenha";
            this.chkMostrarSenha.UseVisualStyleBackColor = true;
            this.chkMostrarSenha.CheckedChanged += new System.EventHandler(this.chkMostrarSenha_CheckedChanged);
            // 
            // txtpermissoes
            // 
            this.txtpermissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpermissoes.Location = new System.Drawing.Point(747, 215);
            this.txtpermissoes.Margin = new System.Windows.Forms.Padding(2);
            this.txtpermissoes.Name = "txtpermissoes";
            this.txtpermissoes.ReadOnly = true;
            this.txtpermissoes.Size = new System.Drawing.Size(329, 212);
            this.txtpermissoes.TabIndex = 302;
            this.txtpermissoes.Text = " ";
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMenssagem.Location = new System.Drawing.Point(3, 541);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(241, 25);
            this.lblMenssagem.TabIndex = 298;
            this.lblMenssagem.Text = "Menssagem Ao Usuario";
            this.lblMenssagem.Visible = false;
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.panelOpcoes.Controls.Add(this.lblEditar);
            this.panelOpcoes.Controls.Add(this.btnEditar);
            this.panelOpcoes.Controls.Add(this.lblCancelar);
            this.panelOpcoes.Controls.Add(this.btnCancelar);
            this.panelOpcoes.Controls.Add(this.lblSalvar);
            this.panelOpcoes.Controls.Add(this.btnSalvar);
            this.panelOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.panelOpcoes.Location = new System.Drawing.Point(1432, 8);
            this.panelOpcoes.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Padding = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Size = new System.Drawing.Size(77, 756);
            this.panelOpcoes.TabIndex = 299;
            this.panelOpcoes.TabStop = false;
            this.panelOpcoes.Text = "Opções";
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditar.Location = new System.Drawing.Point(13, 75);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(46, 18);
            this.lblEditar.TabIndex = 304;
            this.lblEditar.Text = "Editar";
            this.lblEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(11, 23);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 51);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditar.TabIndex = 303;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.Location = new System.Drawing.Point(4, 401);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(67, 18);
            this.lblCancelar.TabIndex = 296;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(11, 347);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 51);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 295;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.BackColor = System.Drawing.Color.Transparent;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalvar.Location = new System.Drawing.Point(-11, 239);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(89, 18);
            this.lblSalvar.TabIndex = 26;
            this.lblSalvar.Text = "      &Salvar    ";
            this.lblSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(11, 190);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(56, 51);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(643, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Permissões :";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(78, 56);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(1088, 26);
            this.txtNome.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(12, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(34, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "RA :";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCadastro.Location = new System.Drawing.Point(12, 264);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(143, 20);
            this.lblCadastro.TabIndex = 297;
            this.lblCadastro.Text = "Data de Cadastro :";
            // 
            // txtUltimoLogin
            // 
            this.txtUltimoLogin.Enabled = false;
            this.txtUltimoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoLogin.Location = new System.Drawing.Point(161, 347);
            this.txtUltimoLogin.MaxLength = 30;
            this.txtUltimoLogin.Name = "txtUltimoLogin";
            this.txtUltimoLogin.ReadOnly = true;
            this.txtUltimoLogin.Size = new System.Drawing.Size(182, 26);
            this.txtUltimoLogin.TabIndex = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(643, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 295;
            this.label3.Text = "Senha :";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuario.Location = new System.Drawing.Point(78, 145);
            this.txtProntuario.MaxLength = 10;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(337, 26);
            this.txtProntuario.TabIndex = 86;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Enabled = false;
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(161, 262);
            this.txtCadastro.MaxLength = 30;
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(182, 26);
            this.txtCadastro.TabIndex = 298;
            this.txtCadastro.Text = "22/09/2019 - 19:59:50";
            // 
            // lblUltimoLogin
            // 
            this.lblUltimoLogin.AutoSize = true;
            this.lblUltimoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoLogin.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltimoLogin.Location = new System.Drawing.Point(9, 349);
            this.lblUltimoLogin.Name = "lblUltimoLogin";
            this.lblUltimoLogin.Size = new System.Drawing.Size(144, 20);
            this.lblUltimoLogin.TabIndex = 299;
            this.lblUltimoLogin.Text = "Data Ultimo Login :";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(711, 131);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(365, 26);
            this.txtSenha.TabIndex = 294;
            this.txtSenha.Text = "**********";
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 775);
            this.Controls.Add(this.panelDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards panelDados;
        private System.Windows.Forms.GroupBox panelOpcoes;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtUltimoLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Label lblUltimoLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.RichTextBox txtpermissoes;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.CheckBox chkMostrarSenha;
    }
}