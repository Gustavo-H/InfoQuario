namespace TIND_4S
{
    partial class FrmRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.panelDados = new ns1.BunifuCards();
            this.gridReport = new System.Windows.Forms.DataGridView();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparCampos = new System.Windows.Forms.PictureBox();
            this.lblSalvarFile = new System.Windows.Forms.Label();
            this.lblLimparCampos = new System.Windows.Forms.Label();
            this.btnSalvarFile = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscarLocatario = new System.Windows.Forms.PictureBox();
            this.btnBuscarUsuarioDevolucao = new System.Windows.Forms.PictureBox();
            this.txtLocadorDevolucao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarUsuarioSaida = new System.Windows.Forms.PictureBox();
            this.btnBuscarEquipamento = new System.Windows.Forms.PictureBox();
            this.chkDataSaida = new System.Windows.Forms.CheckBox();
            this.panelDataDevolucao = new System.Windows.Forms.Panel();
            this.chkDataDevolucao = new System.Windows.Forms.CheckBox();
            this.dtpDevolucaoInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDevolucaoFim = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLocatarioSaida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeLocadorSaida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeEquipamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSaidaFim = new System.Windows.Forms.DateTimePicker();
            this.dtpSaidaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtConcluidos = new System.Windows.Forms.RadioButton();
            this.rbtAbertos = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtAmbos = new System.Windows.Forms.RadioButton();
            this.panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvarFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLocatario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarUsuarioDevolucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarUsuarioSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEquipamento)).BeginInit();
            this.panelDataDevolucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDados
            // 
            this.panelDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDados.BackColor = System.Drawing.Color.Transparent;
            this.panelDados.BorderRadius = 5;
            this.panelDados.BottomSahddow = true;
            this.panelDados.color = System.Drawing.Color.ForestGreen;
            this.panelDados.Controls.Add(this.gridReport);
            this.panelDados.Controls.Add(this.lblMenssagem);
            this.panelDados.Controls.Add(this.groupBox1);
            this.panelDados.LeftSahddow = false;
            this.panelDados.Location = new System.Drawing.Point(0, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.RightSahddow = true;
            this.panelDados.ShadowDepth = 20;
            this.panelDados.Size = new System.Drawing.Size(1515, 777);
            this.panelDados.TabIndex = 302;
            this.panelDados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDados_Paint);
            // 
            // gridReport
            // 
            this.gridReport.AllowUserToAddRows = false;
            this.gridReport.AllowUserToDeleteRows = false;
            this.gridReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridReport.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridReport.Location = new System.Drawing.Point(3, 258);
            this.gridReport.MultiSelect = false;
            this.gridReport.Name = "gridReport";
            this.gridReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridReport.RowHeadersVisible = false;
            this.gridReport.Size = new System.Drawing.Size(1509, 516);
            this.gridReport.TabIndex = 303;
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMenssagem.Location = new System.Drawing.Point(11, 255);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(241, 25);
            this.lblMenssagem.TabIndex = 302;
            this.lblMenssagem.Text = "Menssagem Ao Usuario";
            this.lblMenssagem.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnBuscarLocatario);
            this.groupBox1.Controls.Add(this.btnBuscarUsuarioDevolucao);
            this.groupBox1.Controls.Add(this.txtLocadorDevolucao);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnBuscarUsuarioSaida);
            this.groupBox1.Controls.Add(this.btnBuscarEquipamento);
            this.groupBox1.Controls.Add(this.chkDataSaida);
            this.groupBox1.Controls.Add(this.panelDataDevolucao);
            this.groupBox1.Controls.Add(this.txtLocatarioSaida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNomeLocadorSaida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNomeEquipamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpSaidaFim);
            this.groupBox1.Controls.Add(this.dtpSaidaInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtConcluidos);
            this.groupBox1.Controls.Add(this.rbtAbertos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtAmbos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1509, 240);
            this.groupBox1.TabIndex = 274;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(8, 24);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 33);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfo.TabIndex = 307;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnLimparCampos);
            this.panel1.Controls.Add(this.lblSalvarFile);
            this.panel1.Controls.Add(this.lblLimparCampos);
            this.panel1.Controls.Add(this.btnSalvarFile);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Location = new System.Drawing.Point(1169, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 114);
            this.panel1.TabIndex = 304;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCampos.Image")));
            this.btnLimparCampos.Location = new System.Drawing.Point(164, 27);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(53, 51);
            this.btnLimparCampos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimparCampos.TabIndex = 294;
            this.btnLimparCampos.TabStop = false;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblSalvarFile
            // 
            this.lblSalvarFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalvarFile.AutoSize = true;
            this.lblSalvarFile.BackColor = System.Drawing.Color.Transparent;
            this.lblSalvarFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalvarFile.Location = new System.Drawing.Point(263, 77);
            this.lblSalvarFile.Name = "lblSalvarFile";
            this.lblSalvarFile.Size = new System.Drawing.Size(77, 20);
            this.lblSalvarFile.TabIndex = 295;
            this.lblSalvarFile.Text = "Exportar  ";
            this.lblSalvarFile.Visible = false;
            this.lblSalvarFile.Click += new System.EventHandler(this.btnSalvarFile_Click);
            // 
            // lblLimparCampos
            // 
            this.lblLimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLimparCampos.AutoSize = true;
            this.lblLimparCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLimparCampos.Location = new System.Drawing.Point(143, 77);
            this.lblLimparCampos.Name = "lblLimparCampos";
            this.lblLimparCampos.Size = new System.Drawing.Size(77, 20);
            this.lblLimparCampos.TabIndex = 297;
            this.lblLimparCampos.Text = "     &Limpar";
            this.lblLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnSalvarFile
            // 
            this.btnSalvarFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFile.Image")));
            this.btnSalvarFile.Location = new System.Drawing.Point(266, 16);
            this.btnSalvarFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarFile.Name = "btnSalvarFile";
            this.btnSalvarFile.Size = new System.Drawing.Size(62, 62);
            this.btnSalvarFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvarFile.TabIndex = 300;
            this.btnSalvarFile.TabStop = false;
            this.btnSalvarFile.Visible = false;
            this.btnSalvarFile.Click += new System.EventHandler(this.btnSalvarFile_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(37, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 51);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 298;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Location = new System.Drawing.Point(36, 77);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(59, 20);
            this.lblBuscar.TabIndex = 299;
            this.lblBuscar.Text = "&Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarLocatario
            // 
            this.btnBuscarLocatario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarLocatario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLocatario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLocatario.Image")));
            this.btnBuscarLocatario.Location = new System.Drawing.Point(1465, 13);
            this.btnBuscarLocatario.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarLocatario.Name = "btnBuscarLocatario";
            this.btnBuscarLocatario.Size = new System.Drawing.Size(32, 26);
            this.btnBuscarLocatario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarLocatario.TabIndex = 292;
            this.btnBuscarLocatario.TabStop = false;
            this.btnBuscarLocatario.Click += new System.EventHandler(this.btnBuscarLocatario_Click);
            // 
            // btnBuscarUsuarioDevolucao
            // 
            this.btnBuscarUsuarioDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarUsuarioDevolucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUsuarioDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuarioDevolucao.Image")));
            this.btnBuscarUsuarioDevolucao.Location = new System.Drawing.Point(1465, 60);
            this.btnBuscarUsuarioDevolucao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarUsuarioDevolucao.Name = "btnBuscarUsuarioDevolucao";
            this.btnBuscarUsuarioDevolucao.Size = new System.Drawing.Size(32, 26);
            this.btnBuscarUsuarioDevolucao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarUsuarioDevolucao.TabIndex = 291;
            this.btnBuscarUsuarioDevolucao.TabStop = false;
            this.btnBuscarUsuarioDevolucao.Click += new System.EventHandler(this.btnBuscarUsuarioDevolucao_Click);
            // 
            // txtLocadorDevolucao
            // 
            this.txtLocadorDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocadorDevolucao.Location = new System.Drawing.Point(1119, 60);
            this.txtLocadorDevolucao.MaxLength = 100;
            this.txtLocadorDevolucao.Name = "txtLocadorDevolucao";
            this.txtLocadorDevolucao.Size = new System.Drawing.Size(345, 26);
            this.txtLocadorDevolucao.TabIndex = 290;
            this.txtLocadorDevolucao.TextChanged += new System.EventHandler(this.txtNomeEquipamento_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(959, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 20);
            this.label11.TabIndex = 289;
            this.label11.Text = "Visto de Devolução :";
            // 
            // btnBuscarUsuarioSaida
            // 
            this.btnBuscarUsuarioSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarUsuarioSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUsuarioSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuarioSaida.Image")));
            this.btnBuscarUsuarioSaida.Location = new System.Drawing.Point(843, 58);
            this.btnBuscarUsuarioSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarUsuarioSaida.Name = "btnBuscarUsuarioSaida";
            this.btnBuscarUsuarioSaida.Size = new System.Drawing.Size(32, 26);
            this.btnBuscarUsuarioSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarUsuarioSaida.TabIndex = 288;
            this.btnBuscarUsuarioSaida.TabStop = false;
            this.btnBuscarUsuarioSaida.Click += new System.EventHandler(this.btnBuscarUsuarioSaida_Click);
            // 
            // btnBuscarEquipamento
            // 
            this.btnBuscarEquipamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarEquipamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEquipamento.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEquipamento.Image")));
            this.btnBuscarEquipamento.Location = new System.Drawing.Point(843, 13);
            this.btnBuscarEquipamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEquipamento.Name = "btnBuscarEquipamento";
            this.btnBuscarEquipamento.Size = new System.Drawing.Size(32, 26);
            this.btnBuscarEquipamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarEquipamento.TabIndex = 287;
            this.btnBuscarEquipamento.TabStop = false;
            this.btnBuscarEquipamento.Click += new System.EventHandler(this.btnBuscarEquipamento_Click);
            // 
            // chkDataSaida
            // 
            this.chkDataSaida.AutoSize = true;
            this.chkDataSaida.Location = new System.Drawing.Point(108, 124);
            this.chkDataSaida.Name = "chkDataSaida";
            this.chkDataSaida.Size = new System.Drawing.Size(154, 24);
            this.chkDataSaida.TabIndex = 286;
            this.chkDataSaida.Text = "Usar Este Campo";
            this.chkDataSaida.UseVisualStyleBackColor = true;
            // 
            // panelDataDevolucao
            // 
            this.panelDataDevolucao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDataDevolucao.Controls.Add(this.chkDataDevolucao);
            this.panelDataDevolucao.Controls.Add(this.dtpDevolucaoInicio);
            this.panelDataDevolucao.Controls.Add(this.label8);
            this.panelDataDevolucao.Controls.Add(this.label10);
            this.panelDataDevolucao.Controls.Add(this.dtpDevolucaoFim);
            this.panelDataDevolucao.Controls.Add(this.label9);
            this.panelDataDevolucao.Location = new System.Drawing.Point(465, 114);
            this.panelDataDevolucao.Name = "panelDataDevolucao";
            this.panelDataDevolucao.Size = new System.Drawing.Size(399, 114);
            this.panelDataDevolucao.TabIndex = 285;
            // 
            // chkDataDevolucao
            // 
            this.chkDataDevolucao.AutoSize = true;
            this.chkDataDevolucao.Location = new System.Drawing.Point(158, 4);
            this.chkDataDevolucao.Name = "chkDataDevolucao";
            this.chkDataDevolucao.Size = new System.Drawing.Size(154, 24);
            this.chkDataDevolucao.TabIndex = 287;
            this.chkDataDevolucao.Text = "Usar Este Campo";
            this.chkDataDevolucao.UseVisualStyleBackColor = true;
            // 
            // dtpDevolucaoInicio
            // 
            this.dtpDevolucaoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucaoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucaoInicio.Location = new System.Drawing.Point(196, 34);
            this.dtpDevolucaoInicio.Name = "dtpDevolucaoInicio";
            this.dtpDevolucaoInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpDevolucaoInicio.TabIndex = 282;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 284;
            this.label8.Text = "Data Devolução:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(153, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 283;
            this.label10.Text = "Até :";
            // 
            // dtpDevolucaoFim
            // 
            this.dtpDevolucaoFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucaoFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucaoFim.Location = new System.Drawing.Point(196, 79);
            this.dtpDevolucaoFim.Name = "dtpDevolucaoFim";
            this.dtpDevolucaoFim.Size = new System.Drawing.Size(200, 26);
            this.dtpDevolucaoFim.TabIndex = 280;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(155, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 281;
            this.label9.Text = "De :";
            // 
            // txtLocatarioSaida
            // 
            this.txtLocatarioSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocatarioSaida.Location = new System.Drawing.Point(1119, 13);
            this.txtLocatarioSaida.MaxLength = 50;
            this.txtLocatarioSaida.Name = "txtLocatarioSaida";
            this.txtLocatarioSaida.Size = new System.Drawing.Size(345, 26);
            this.txtLocatarioSaida.TabIndex = 279;
            this.txtLocatarioSaida.TextChanged += new System.EventHandler(this.txtNomeEquipamento_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(1007, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 278;
            this.label7.Text = "Retirado Por :";
            // 
            // txtNomeLocadorSaida
            // 
            this.txtNomeLocadorSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeLocadorSaida.Location = new System.Drawing.Point(515, 59);
            this.txtNomeLocadorSaida.MaxLength = 100;
            this.txtNomeLocadorSaida.Name = "txtNomeLocadorSaida";
            this.txtNomeLocadorSaida.Size = new System.Drawing.Size(327, 26);
            this.txtNomeLocadorSaida.TabIndex = 277;
            this.txtNomeLocadorSaida.TextChanged += new System.EventHandler(this.txtNomeEquipamento_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(390, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 276;
            this.label6.Text = "Visto de Saida :";
            // 
            // txtNomeEquipamento
            // 
            this.txtNomeEquipamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeEquipamento.Location = new System.Drawing.Point(515, 14);
            this.txtNomeEquipamento.MaxLength = 32;
            this.txtNomeEquipamento.Name = "txtNomeEquipamento";
            this.txtNomeEquipamento.Size = new System.Drawing.Size(327, 26);
            this.txtNomeEquipamento.TabIndex = 275;
            this.txtNomeEquipamento.TextChanged += new System.EventHandler(this.txtNomeEquipamento_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(399, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 274;
            this.label2.Text = "Equipamento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(9, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 273;
            this.label1.Text = "Data Saida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(117, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 272;
            this.label5.Text = "Estado :";
            // 
            // dtpSaidaFim
            // 
            this.dtpSaidaFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaidaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaidaFim.Location = new System.Drawing.Point(146, 202);
            this.dtpSaidaFim.Name = "dtpSaidaFim";
            this.dtpSaidaFim.Size = new System.Drawing.Size(200, 26);
            this.dtpSaidaFim.TabIndex = 264;
            // 
            // dtpSaidaInicio
            // 
            this.dtpSaidaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaidaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaidaInicio.Location = new System.Drawing.Point(146, 157);
            this.dtpSaidaInicio.Name = "dtpSaidaInicio";
            this.dtpSaidaInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpSaidaInicio.TabIndex = 267;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(105, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 266;
            this.label4.Text = "De :";
            // 
            // rbtConcluidos
            // 
            this.rbtConcluidos.AutoSize = true;
            this.rbtConcluidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtConcluidos.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtConcluidos.Location = new System.Drawing.Point(191, 26);
            this.rbtConcluidos.Name = "rbtConcluidos";
            this.rbtConcluidos.Size = new System.Drawing.Size(98, 24);
            this.rbtConcluidos.TabIndex = 268;
            this.rbtConcluidos.Text = "Fechados";
            this.rbtConcluidos.UseVisualStyleBackColor = true;
            this.rbtConcluidos.CheckedChanged += new System.EventHandler(this.CheckedRbts);
            // 
            // rbtAbertos
            // 
            this.rbtAbertos.AutoSize = true;
            this.rbtAbertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAbertos.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtAbertos.Location = new System.Drawing.Point(191, 56);
            this.rbtAbertos.Name = "rbtAbertos";
            this.rbtAbertos.Size = new System.Drawing.Size(83, 24);
            this.rbtAbertos.TabIndex = 269;
            this.rbtAbertos.Text = "Abertos";
            this.rbtAbertos.UseVisualStyleBackColor = true;
            this.rbtAbertos.CheckedChanged += new System.EventHandler(this.CheckedRbts);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(103, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 271;
            this.label3.Text = "Até :";
            // 
            // rbtAmbos
            // 
            this.rbtAmbos.AutoSize = true;
            this.rbtAmbos.Checked = true;
            this.rbtAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAmbos.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtAmbos.Location = new System.Drawing.Point(6, 91);
            this.rbtAmbos.Name = "rbtAmbos";
            this.rbtAmbos.Size = new System.Drawing.Size(77, 24);
            this.rbtAmbos.TabIndex = 270;
            this.rbtAmbos.TabStop = true;
            this.rbtAmbos.Text = "Ambos";
            this.rbtAmbos.UseVisualStyleBackColor = true;
            this.rbtAmbos.Visible = false;
            this.rbtAmbos.CheckedChanged += new System.EventHandler(this.CheckedRbts);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 777);
            this.Controls.Add(this.panelDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerando Relatorio";
            this.Load += new System.EventHandler(this.FrmRelatorio2_Load);
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimparCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvarFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarLocatario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarUsuarioDevolucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarUsuarioSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEquipamento)).EndInit();
            this.panelDataDevolucao.ResumeLayout(false);
            this.panelDataDevolucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards panelDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnLimparCampos;
        private System.Windows.Forms.Label lblSalvarFile;
        private System.Windows.Forms.Label lblLimparCampos;
        private System.Windows.Forms.PictureBox btnSalvarFile;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox btnBuscarLocatario;
        private System.Windows.Forms.PictureBox btnBuscarUsuarioDevolucao;
        private System.Windows.Forms.TextBox txtLocadorDevolucao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnBuscarUsuarioSaida;
        private System.Windows.Forms.PictureBox btnBuscarEquipamento;
        private System.Windows.Forms.CheckBox chkDataSaida;
        private System.Windows.Forms.Panel panelDataDevolucao;
        private System.Windows.Forms.CheckBox chkDataDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDevolucaoInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDevolucaoFim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLocatarioSaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeLocadorSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSaidaFim;
        private System.Windows.Forms.DateTimePicker dtpSaidaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtConcluidos;
        private System.Windows.Forms.RadioButton rbtAbertos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtAmbos;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.DataGridView gridReport;
        private System.Windows.Forms.PictureBox btnInfo;
    }
}