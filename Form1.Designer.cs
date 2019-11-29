namespace LABMUSIC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paneLeft = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Label();
            this.LinkLogin = new System.Windows.Forms.LinkLabel();
            this.BotãoRegistrar = new System.Windows.Forms.Button();
            this.TxtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtRepetirSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.paneLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneLeft
            // 
            this.paneLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.paneLeft.Controls.Add(this.label6);
            this.paneLeft.Controls.Add(this.pictureBox1);
            this.paneLeft.Location = new System.Drawing.Point(0, 0);
            this.paneLeft.Name = "paneLeft";
            this.paneLeft.Size = new System.Drawing.Size(398, 603);
            this.paneLeft.TabIndex = 0;
            this.paneLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.paneLeft_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qualidade Nos Ouvidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.BtnFechar);
            this.panelRight.Controls.Add(this.LinkLogin);
            this.panelRight.Controls.Add(this.BotãoRegistrar);
            this.panelRight.Controls.Add(this.TxtEmail);
            this.panelRight.Controls.Add(this.TxtRepetirSenha);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.TxtSenha);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.TxtNome);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(396, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(454, 603);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // BtnFechar
            // 
            this.BtnFechar.AutoSize = true;
            this.BtnFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFechar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.BtnFechar.Location = new System.Drawing.Point(424, 4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 30);
            this.BtnFechar.TabIndex = 13;
            this.BtnFechar.Text = "x";
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // LinkLogin
            // 
            this.LinkLogin.AutoSize = true;
            this.LinkLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LinkLogin.LinkColor = System.Drawing.Color.Green;
            this.LinkLogin.Location = new System.Drawing.Point(22, 382);
            this.LinkLogin.Name = "LinkLogin";
            this.LinkLogin.Size = new System.Drawing.Size(147, 19);
            this.LinkLogin.TabIndex = 12;
            this.LinkLogin.TabStop = true;
            this.LinkLogin.Text = "Ja sou cadastrado !";
            this.LinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogin_LinkClicked);
            // 
            // BotãoRegistrar
            // 
            this.BotãoRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BotãoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotãoRegistrar.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BotãoRegistrar.Location = new System.Drawing.Point(65, 489);
            this.BotãoRegistrar.Name = "BotãoRegistrar";
            this.BotãoRegistrar.Size = new System.Drawing.Size(309, 56);
            this.BotãoRegistrar.TabIndex = 10;
            this.BotãoRegistrar.Text = "Registrar";
            this.BotãoRegistrar.UseVisualStyleBackColor = false;
            this.BotãoRegistrar.Click += new System.EventHandler(this.BotãoRegistrar_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.TxtEmail.HintText = "Seu Email";
            this.TxtEmail.isPassword = false;
            this.TxtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtEmail.LineThickness = 3;
            this.TxtEmail.Location = new System.Drawing.Point(26, 328);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(370, 24);
            this.TxtEmail.TabIndex = 9;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtRepetirSenha
            // 
            this.TxtRepetirSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRepetirSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtRepetirSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRepetirSenha.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRepetirSenha.HintText = "Senha";
            this.TxtRepetirSenha.isPassword = true;
            this.TxtRepetirSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtRepetirSenha.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtRepetirSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtRepetirSenha.LineThickness = 3;
            this.TxtRepetirSenha.Location = new System.Drawing.Point(26, 265);
            this.TxtRepetirSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRepetirSenha.Name = "TxtRepetirSenha";
            this.TxtRepetirSenha.Size = new System.Drawing.Size(370, 24);
            this.TxtRepetirSenha.TabIndex = 8;
            this.TxtRepetirSenha.Text = "Repetir Senha";
            this.TxtRepetirSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(21, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email :";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSenha.HintForeColor = System.Drawing.Color.Empty;
            this.TxtSenha.HintText = "";
            this.TxtSenha.isPassword = true;
            this.TxtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtSenha.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtSenha.LineThickness = 3;
            this.TxtSenha.Location = new System.Drawing.Point(26, 202);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(370, 24);
            this.TxtSenha.TabIndex = 6;
            this.TxtSenha.Text = "Repetir Senha";
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(21, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Repetir Senha :";
            // 
            // TxtNome
            // 
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNome.HintForeColor = System.Drawing.Color.Empty;
            this.TxtNome.HintText = "Nome Completo";
            this.TxtNome.isPassword = false;
            this.TxtNome.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtNome.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtNome.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtNome.LineThickness = 3;
            this.TxtNome.Location = new System.Drawing.Point(26, 139);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(370, 24);
            this.TxtNome.TabIndex = 4;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 603);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.paneLeft);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneLeft.ResumeLayout(false);
            this.paneLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRepetirSenha;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSenha;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotãoRegistrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel LinkLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label BtnFechar;
    }
}

