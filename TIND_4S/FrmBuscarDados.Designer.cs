namespace TIND_4S
{
    partial class FrmBuscarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarDados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDados = new ns1.BunifuCards();
            this.IMG_RED = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtProntuario = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDados
            // 
            this.panelDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDados.BackColor = System.Drawing.Color.Transparent;
            this.panelDados.BorderRadius = 5;
            this.panelDados.BottomSahddow = true;
            this.panelDados.color = System.Drawing.Color.ForestGreen;
            this.panelDados.LeftSahddow = false;
            this.panelDados.Location = new System.Drawing.Point(1, 1);
            this.panelDados.Name = "panelDados";
            this.panelDados.RightSahddow = true;
            this.panelDados.ShadowDepth = 20;
            this.panelDados.Size = new System.Drawing.Size(739, 10);
            this.panelDados.TabIndex = 298;
            // 
            // IMG_RED
            // 
            this.IMG_RED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IMG_RED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_RED.Image = ((System.Drawing.Image)(resources.GetObject("IMG_RED.Image")));
            this.IMG_RED.Location = new System.Drawing.Point(789, 31);
            this.IMG_RED.Name = "IMG_RED";
            this.IMG_RED.Size = new System.Drawing.Size(30, 30);
            this.IMG_RED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_RED.TabIndex = 299;
            this.IMG_RED.TabStop = false;
            this.IMG_RED.Visible = false;
            this.IMG_RED.Click += new System.EventHandler(this.IMGCloseRED_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(741, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 300;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.IMGCloseRED_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridDados.Location = new System.Drawing.Point(5, 163);
            this.gridDados.MultiSelect = false;
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.RowHeadersVisible = false;
            this.gridDados.Size = new System.Drawing.Size(758, 283);
            this.gridDados.TabIndex = 305;
            this.gridDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarItem);
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(5, 8);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 33);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfo.TabIndex = 306;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMensagem.Location = new System.Drawing.Point(72, 16);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(241, 25);
            this.lblMensagem.TabIndex = 307;
            this.lblMensagem.Text = "Menssagem Ao Usuario";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNome.BackgroundImage")));
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNome.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtNome.Icon = ((System.Drawing.Image)(resources.GetObject("txtNome.Icon")));
            this.txtNome.Location = new System.Drawing.Point(12, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 42);
            this.txtNome.TabIndex = 308;
            this.txtNome.text = "";
            this.txtNome.OnTextChange += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // txtProntuario
            // 
            this.txtProntuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtProntuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProntuario.BackgroundImage")));
            this.txtProntuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtProntuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtProntuario.Icon = ((System.Drawing.Image)(resources.GetObject("txtProntuario.Icon")));
            this.txtProntuario.Location = new System.Drawing.Point(466, 91);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(293, 42);
            this.txtProntuario.TabIndex = 309;
            this.txtProntuario.text = "";
            this.txtProntuario.OnTextChange += new System.EventHandler(this.txtNome_TextChanged);
            this.txtProntuario.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNome.Location = new System.Drawing.Point(190, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 25);
            this.lblNome.TabIndex = 310;
            this.lblNome.Text = "Nome ";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProntuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProntuario.Location = new System.Drawing.Point(565, 63);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(117, 25);
            this.lblProntuario.TabIndex = 311;
            this.lblProntuario.Text = "Prontuario ";
            // 
            // FrmBuscarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(771, 458);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.IMG_RED);
            this.Controls.Add(this.panelDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarDados";
            this.Load += new System.EventHandler(this.FrmBuscarDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCards panelDados;
        private System.Windows.Forms.PictureBox IMG_RED;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView gridDados;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.Label lblMensagem;
        private Bunifu.Framework.UI.BunifuTextbox txtNome;
        private Bunifu.Framework.UI.BunifuTextbox txtProntuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProntuario;
    }
}