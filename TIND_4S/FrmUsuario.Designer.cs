namespace TIND_4S
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.txtUltimoLogin = new System.Windows.Forms.TextBox();
            this.lblUltimoLogin = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.clbPermissoes = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDesativar = new System.Windows.Forms.Label();
            this.btnDesativar = new System.Windows.Forms.PictureBox();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.panelOpcoes = new System.Windows.Forms.GroupBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.lblRedefinirSenha = new System.Windows.Forms.Label();
            this.btnRedefinirSenha = new System.Windows.Forms.PictureBox();
            this.btnLimparCampos = new System.Windows.Forms.PictureBox();
            this.lblLimparCampos = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panelDados = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new ns1.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesativar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.panelOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedefinirSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.panelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProntuario
            // 
            this.txtProntuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuario.Location = new System.Drawing.Point(118, 55);
            this.txtProntuario.MaxLength = 12;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(223, 26);
            this.txtProntuario.TabIndex = 86;
            this.txtProntuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarProntuario);
            // 
            // txtUltimoLogin
            // 
            this.txtUltimoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoLogin.Location = new System.Drawing.Point(465, 92);
            this.txtUltimoLogin.MaxLength = 30;
            this.txtUltimoLogin.Name = "txtUltimoLogin";
            this.txtUltimoLogin.ReadOnly = true;
            this.txtUltimoLogin.Size = new System.Drawing.Size(182, 26);
            this.txtUltimoLogin.TabIndex = 300;
            // 
            // lblUltimoLogin
            // 
            this.lblUltimoLogin.AutoSize = true;
            this.lblUltimoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoLogin.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltimoLogin.Location = new System.Drawing.Point(357, 94);
            this.lblUltimoLogin.Name = "lblUltimoLogin";
            this.lblUltimoLogin.Size = new System.Drawing.Size(101, 20);
            this.lblUltimoLogin.TabIndex = 299;
            this.lblUltimoLogin.Text = "Ultino Login :";
            // 
            // txtCadastro
            // 
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(465, 55);
            this.txtCadastro.MaxLength = 30;
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.ReadOnly = true;
            this.txtCadastro.Size = new System.Drawing.Size(182, 26);
            this.txtCadastro.TabIndex = 298;
            this.txtCadastro.Text = "22/09/2019 - 19:59:50";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCadastro.Location = new System.Drawing.Point(378, 57);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(82, 20);
            this.lblCadastro.TabIndex = 297;
            this.lblCadastro.Text = "Cadastro :";
            // 
            // clbPermissoes
            // 
            this.clbPermissoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbPermissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPermissoes.FormattingEnabled = true;
            this.clbPermissoes.Location = new System.Drawing.Point(986, 15);
            this.clbPermissoes.Name = "clbPermissoes";
            this.clbPermissoes.Size = new System.Drawing.Size(255, 151);
            this.clbPermissoes.TabIndex = 296;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(50, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 295;
            this.label3.Text = "Senha :";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(118, 92);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(223, 26);
            this.txtSenha.TabIndex = 294;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(879, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Permissões :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Prontuario :";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(118, 15);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(529, 26);
            this.txtNome.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(52, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Nome :";
            // 
            // lblDesativar
            // 
            this.lblDesativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesativar.AutoSize = true;
            this.lblDesativar.BackColor = System.Drawing.Color.Transparent;
            this.lblDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesativar.Location = new System.Drawing.Point(9, 661);
            this.lblDesativar.Name = "lblDesativar";
            this.lblDesativar.Size = new System.Drawing.Size(52, 18);
            this.lblDesativar.TabIndex = 292;
            this.lblDesativar.Text = "Excluir";
            this.lblDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesativar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesativar.Image")));
            this.btnDesativar.Location = new System.Drawing.Point(10, 609);
            this.btnDesativar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(53, 51);
            this.btnDesativar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDesativar.TabIndex = 291;
            this.btnDesativar.TabStop = false;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridUsuarios.Location = new System.Drawing.Point(7, 234);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.RowHeadersVisible = false;
            this.gridUsuarios.Size = new System.Drawing.Size(1244, 474);
            this.gridUsuarios.TabIndex = 296;
            this.gridUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.visualizarUsuario);
            this.gridUsuarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.editarUsuario);
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.panelOpcoes.Controls.Add(this.lblCancelar);
            this.panelOpcoes.Controls.Add(this.btnCancelar);
            this.panelOpcoes.Controls.Add(this.lblRedefinirSenha);
            this.panelOpcoes.Controls.Add(this.btnRedefinirSenha);
            this.panelOpcoes.Controls.Add(this.lblDesativar);
            this.panelOpcoes.Controls.Add(this.btnDesativar);
            this.panelOpcoes.Controls.Add(this.btnLimparCampos);
            this.panelOpcoes.Controls.Add(this.lblLimparCampos);
            this.panelOpcoes.Controls.Add(this.lblBuscar);
            this.panelOpcoes.Controls.Add(this.btnBuscar);
            this.panelOpcoes.Controls.Add(this.lblSalvar);
            this.panelOpcoes.Controls.Add(this.btnSalvar);
            this.panelOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.panelOpcoes.Location = new System.Drawing.Point(1256, 17);
            this.panelOpcoes.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Padding = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Size = new System.Drawing.Size(78, 691);
            this.panelOpcoes.TabIndex = 295;
            this.panelOpcoes.TabStop = false;
            this.panelOpcoes.Text = "Opções";
            // 
            // lblCancelar
            // 
            this.lblCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.Location = new System.Drawing.Point(1, 397);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(67, 18);
            this.lblCancelar.TabIndex = 296;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(10, 345);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 51);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 295;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lblRedefinirSenha
            // 
            this.lblRedefinirSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRedefinirSenha.AutoSize = true;
            this.lblRedefinirSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblRedefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRedefinirSenha.Location = new System.Drawing.Point(1, 279);
            this.lblRedefinirSenha.Name = "lblRedefinirSenha";
            this.lblRedefinirSenha.Size = new System.Drawing.Size(66, 36);
            this.lblRedefinirSenha.TabIndex = 294;
            this.lblRedefinirSenha.Text = "Redefinir\r\n  Senha";
            this.lblRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRedefinirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedefinirSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnRedefinirSenha.Image")));
            this.btnRedefinirSenha.Location = new System.Drawing.Point(10, 228);
            this.btnRedefinirSenha.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(53, 51);
            this.btnRedefinirSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRedefinirSenha.TabIndex = 293;
            this.btnRedefinirSenha.TabStop = false;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCampos.Image")));
            this.btnLimparCampos.Location = new System.Drawing.Point(10, 446);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(53, 51);
            this.btnLimparCampos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimparCampos.TabIndex = 17;
            this.btnLimparCampos.TabStop = false;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblLimparCampos
            // 
            this.lblLimparCampos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLimparCampos.AutoSize = true;
            this.lblLimparCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLimparCampos.Location = new System.Drawing.Point(-9, 496);
            this.lblLimparCampos.Name = "lblLimparCampos";
            this.lblLimparCampos.Size = new System.Drawing.Size(81, 36);
            this.lblLimparCampos.TabIndex = 27;
            this.lblLimparCampos.Text = "     &Limpar \r\n    Campos";
            this.lblLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Location = new System.Drawing.Point(10, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 18);
            this.lblBuscar.TabIndex = 290;
            this.lblBuscar.Text = "&Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(10, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 51);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 289;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.BackColor = System.Drawing.Color.Transparent;
            this.lblSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalvar.Location = new System.Drawing.Point(-13, 179);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(89, 18);
            this.lblSalvar.TabIndex = 26;
            this.lblSalvar.Text = "      &Salvar    ";
            this.lblSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(10, 126);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 51);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMensagem.Location = new System.Drawing.Point(3, 199);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(241, 25);
            this.lblMensagem.TabIndex = 294;
            this.lblMensagem.Text = "Menssagem Ao Usuario";
            this.lblMensagem.Visible = false;
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.txtNome);
            this.panelDados.Controls.Add(this.label16);
            this.panelDados.Controls.Add(this.label1);
            this.panelDados.Controls.Add(this.txtProntuario);
            this.panelDados.Controls.Add(this.clbPermissoes);
            this.panelDados.Controls.Add(this.label2);
            this.panelDados.Controls.Add(this.txtUltimoLogin);
            this.panelDados.Controls.Add(this.txtSenha);
            this.panelDados.Controls.Add(this.lblUltimoLogin);
            this.panelDados.Controls.Add(this.label3);
            this.panelDados.Controls.Add(this.txtCadastro);
            this.panelDados.Controls.Add(this.lblCadastro);
            this.panelDados.Location = new System.Drawing.Point(7, 12);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1244, 175);
            this.panelDados.TabIndex = 298;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.ForestGreen;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1343, 10);
            this.bunifuCards1.TabIndex = 299;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 716);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.panelOpcoes);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDesativar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedefinirSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDesativar;
        private System.Windows.Forms.PictureBox btnDesativar;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.GroupBox panelOpcoes;
        private System.Windows.Forms.PictureBox btnLimparCampos;
        private System.Windows.Forms.Label lblLimparCampos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblRedefinirSenha;
        private System.Windows.Forms.PictureBox btnRedefinirSenha;
        private System.Windows.Forms.CheckedListBox clbPermissoes;
        private System.Windows.Forms.TextBox txtUltimoLogin;
        private System.Windows.Forms.Label lblUltimoLogin;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.Panel panelDados;
        private ns1.BunifuCards bunifuCards1;
    }
}