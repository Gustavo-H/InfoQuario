namespace TIND_4S
{
    partial class FrmEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOpcoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.gridEquipamento = new System.Windows.Forms.DataGridView();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.panelDados = new System.Windows.Forms.GroupBox();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.panelOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamento)).BeginInit();
            this.panelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.panelOpcoes.Controls.Add(this.label1);
            this.panelOpcoes.Controls.Add(this.btnCancelar);
            this.panelOpcoes.Controls.Add(this.lblExcluir);
            this.panelOpcoes.Controls.Add(this.btnExcluir);
            this.panelOpcoes.Controls.Add(this.btnLimpar);
            this.panelOpcoes.Controls.Add(this.lblCancelar);
            this.panelOpcoes.Controls.Add(this.lblBuscar);
            this.panelOpcoes.Controls.Add(this.btnBuscar);
            this.panelOpcoes.Controls.Add(this.lblSalvar);
            this.panelOpcoes.Controls.Add(this.btnSalvar);
            this.panelOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.panelOpcoes.Location = new System.Drawing.Point(1277, 16);
            this.panelOpcoes.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Padding = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Size = new System.Drawing.Size(76, 625);
            this.panelOpcoes.TabIndex = 303;
            this.panelOpcoes.TabStop = false;
            this.panelOpcoes.Text = "Opções";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(2, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 298;
            this.label1.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(11, 382);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 51);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 297;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblExcluir
            // 
            this.lblExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.BackColor = System.Drawing.Color.Transparent;
            this.lblExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExcluir.Location = new System.Drawing.Point(10, 565);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(52, 18);
            this.lblExcluir.TabIndex = 292;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(11, 515);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(53, 52);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcluir.TabIndex = 291;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(11, 255);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 52);
            this.btnLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.Location = new System.Drawing.Point(-9, 308);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(81, 36);
            this.lblCancelar.TabIndex = 27;
            this.lblCancelar.Text = "     &Limpar \r\n    Campos";
            this.lblCancelar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Location = new System.Drawing.Point(11, 84);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 18);
            this.lblBuscar.TabIndex = 290;
            this.lblBuscar.Text = "&Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(11, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 52);
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
            this.lblSalvar.Location = new System.Drawing.Point(-11, 196);
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
            this.btnSalvar.Location = new System.Drawing.Point(11, 146);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 52);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gridEquipamento
            // 
            this.gridEquipamento.AllowUserToAddRows = false;
            this.gridEquipamento.AllowUserToDeleteRows = false;
            this.gridEquipamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEquipamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEquipamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEquipamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEquipamento.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridEquipamento.Location = new System.Drawing.Point(3, 132);
            this.gridEquipamento.MultiSelect = false;
            this.gridEquipamento.Name = "gridEquipamento";
            this.gridEquipamento.ReadOnly = true;
            this.gridEquipamento.RowHeadersVisible = false;
            this.gridEquipamento.Size = new System.Drawing.Size(1269, 509);
            this.gridEquipamento.TabIndex = 304;
            this.gridEquipamento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.visualizarEquipamento);
            this.gridEquipamento.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.editarEquipamento);
            // 
            // lstTipo
            // 
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Location = new System.Drawing.Point(867, 31);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(152, 28);
            this.lstTipo.TabIndex = 307;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(634, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 295;
            this.label3.Text = "Nr :";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(673, 31);
            this.txtNumero.MaxLength = 4;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 26);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumero);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(814, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tipo :";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 31);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(463, 26);
            this.txtNome.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(7, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Nome :";
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMenssagem.Location = new System.Drawing.Point(8, 104);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(241, 25);
            this.lblMenssagem.TabIndex = 306;
            this.lblMenssagem.Text = "Menssagem Ao Usuario";
            this.lblMenssagem.Visible = false;
            // 
            // panelDados
            // 
            this.panelDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDados.Controls.Add(this.label16);
            this.panelDados.Controls.Add(this.txtNome);
            this.panelDados.Controls.Add(this.label4);
            this.panelDados.Controls.Add(this.txtNumero);
            this.panelDados.Controls.Add(this.lstTipo);
            this.panelDados.Controls.Add(this.label3);
            this.panelDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDados.ForeColor = System.Drawing.Color.DarkGreen;
            this.panelDados.Location = new System.Drawing.Point(2, 16);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1270, 85);
            this.panelDados.TabIndex = 307;
            this.panelDados.TabStop = false;
            this.panelDados.Text = "Dados do Item";
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
            this.bunifuCards1.Location = new System.Drawing.Point(-1, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1366, 17);
            this.bunifuCards1.TabIndex = 309;
            // 
            // FrmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 644);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.lblMenssagem);
            this.Controls.Add(this.gridEquipamento);
            this.Controls.Add(this.panelOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Equipamento";
            this.Load += new System.EventHandler(this.FrmEquipamento_Load);
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamento)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox panelOpcoes;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnLimpar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.DataGridView gridEquipamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.GroupBox panelDados;
        private ns1.BunifuCards bunifuCards1;
    }
}