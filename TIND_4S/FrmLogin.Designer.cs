namespace TIND_4S
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.imgMostrarSenha = new System.Windows.Forms.PictureBox();
            this.imgNaoMostarSenha = new System.Windows.Forms.PictureBox();
            this.txtLogin = new ns1.BunifuMetroTextbox();
            this.txtSenha = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.lblMenssage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.IMG_RED = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMostrarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNaoMostarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_RED)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(20, 19);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 33);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfo.TabIndex = 75;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnIr
            // 
            this.btnIr.BackColor = System.Drawing.Color.Transparent;
            this.btnIr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIr.BackgroundImage")));
            this.btnIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIr.FlatAppearance.BorderSize = 0;
            this.btnIr.Location = new System.Drawing.Point(449, 270);
            this.btnIr.Margin = new System.Windows.Forms.Padding(0);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(50, 44);
            this.btnIr.TabIndex = 63;
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // imgMostrarSenha
            // 
            this.imgMostrarSenha.BackColor = System.Drawing.Color.Silver;
            this.imgMostrarSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgMostrarSenha.Image")));
            this.imgMostrarSenha.Location = new System.Drawing.Point(398, 342);
            this.imgMostrarSenha.Name = "imgMostrarSenha";
            this.imgMostrarSenha.Size = new System.Drawing.Size(43, 35);
            this.imgMostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMostrarSenha.TabIndex = 74;
            this.imgMostrarSenha.TabStop = false;
            this.imgMostrarSenha.Click += new System.EventHandler(this.imgMostrarSenha_Click);
            // 
            // imgNaoMostarSenha
            // 
            this.imgNaoMostarSenha.BackColor = System.Drawing.Color.Silver;
            this.imgNaoMostarSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgNaoMostarSenha.Image")));
            this.imgNaoMostarSenha.Location = new System.Drawing.Point(398, 342);
            this.imgNaoMostarSenha.Name = "imgNaoMostarSenha";
            this.imgNaoMostarSenha.Size = new System.Drawing.Size(43, 35);
            this.imgNaoMostarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNaoMostarSenha.TabIndex = 73;
            this.imgNaoMostarSenha.TabStop = false;
            this.imgNaoMostarSenha.Visible = false;
            this.imgNaoMostarSenha.Click += new System.EventHandler(this.imgNaoMostarSenha_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Silver;
            this.txtLogin.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLogin.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtLogin.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.txtLogin.BorderThickness = 3;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtLogin.isPassword = false;
            this.txtLogin.Location = new System.Drawing.Point(159, 270);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(286, 44);
            this.txtLogin.TabIndex = 61;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Silver;
            this.txtSenha.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSenha.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(159, 337);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(286, 44);
            this.txtSenha.TabIndex = 62;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(69, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Senha :";
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(-8, 0);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(640, 18);
            this.lblSuperior.TabIndex = 71;
            this.lblSuperior.Text = "                                                                                 " +
    "                                                                             ";
            this.lblSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.lblSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Location = new System.Drawing.Point(614, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 442);
            this.panel3.TabIndex = 70;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(580, 17);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(33, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 69;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // lblMenssage
            // 
            this.lblMenssage.AutoSize = true;
            this.lblMenssage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssage.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMenssage.Location = new System.Drawing.Point(161, 229);
            this.lblMenssage.Name = "lblMenssage";
            this.lblMenssage.Size = new System.Drawing.Size(179, 20);
            this.lblMenssage.TabIndex = 68;
            this.lblMenssage.Text = "Menssagem Ao Usuario";
            this.lblMenssage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(-5, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 19);
            this.panel2.TabIndex = 67;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 429);
            this.panel1.TabIndex = 66;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(32, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Prontuario :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // IMG_RED
            // 
            this.IMG_RED.Image = ((System.Drawing.Image)(resources.GetObject("IMG_RED.Image")));
            this.IMG_RED.Location = new System.Drawing.Point(747, 88);
            this.IMG_RED.Margin = new System.Windows.Forms.Padding(2);
            this.IMG_RED.Name = "IMG_RED";
            this.IMG_RED.Size = new System.Drawing.Size(33, 33);
            this.IMG_RED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_RED.TabIndex = 77;
            this.IMG_RED.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnIr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 441);
            this.Controls.Add(this.IMG_RED);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.imgMostrarSenha);
            this.Controls.Add(this.imgNaoMostarSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMenssage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMostrarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNaoMostarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_RED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.PictureBox imgMostrarSenha;
        private System.Windows.Forms.PictureBox imgNaoMostarSenha;
        private ns1.BunifuMetroTextbox txtLogin;
        private ns1.BunifuMetroTextbox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Label lblMenssage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox IMG_RED;

    }
}

