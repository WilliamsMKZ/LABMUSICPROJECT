namespace LABMUSIC
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSenha2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtNome2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BotãoEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(154, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logar";
            // 
            // BtnFechar
            // 
            this.BtnFechar.AutoSize = true;
            this.BtnFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFechar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.BtnFechar.Location = new System.Drawing.Point(452, 2);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 30);
            this.BtnFechar.TabIndex = 14;
            this.BtnFechar.Text = "x";
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(56, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(56, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Usuário :";
            // 
            // TxtSenha2
            // 
            this.TxtSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSenha2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSenha2.HintForeColor = System.Drawing.Color.Empty;
            this.TxtSenha2.HintText = "";
            this.TxtSenha2.isPassword = true;
            this.TxtSenha2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtSenha2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtSenha2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtSenha2.LineThickness = 3;
            this.TxtSenha2.Location = new System.Drawing.Point(56, 331);
            this.TxtSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSenha2.Name = "TxtSenha2";
            this.TxtSenha2.Size = new System.Drawing.Size(339, 24);
            this.TxtSenha2.TabIndex = 18;
            this.TxtSenha2.Text = "Nome Completo";
            this.TxtSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtNome2
            // 
            this.TxtNome2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNome2.HintForeColor = System.Drawing.Color.Empty;
            this.TxtNome2.HintText = "Nome do usuario";
            this.TxtNome2.isPassword = false;
            this.TxtNome2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtNome2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtNome2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.TxtNome2.LineThickness = 3;
            this.TxtNome2.Location = new System.Drawing.Point(56, 268);
            this.TxtNome2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome2.Name = "TxtNome2";
            this.TxtNome2.Size = new System.Drawing.Size(339, 24);
            this.TxtNome2.TabIndex = 17;
            this.TxtNome2.Text = "Nome Completo";
            this.TxtNome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BotãoEntrar
            // 
            this.BotãoEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BotãoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotãoEntrar.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BotãoEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotãoEntrar.Location = new System.Drawing.Point(56, 568);
            this.BotãoEntrar.Name = "BotãoEntrar";
            this.BotãoEntrar.Size = new System.Drawing.Size(339, 56);
            this.BotãoEntrar.TabIndex = 19;
            this.BotãoEntrar.Text = "Entrar";
            this.BotãoEntrar.UseVisualStyleBackColor = false;
            this.BotãoEntrar.Click += new System.EventHandler(this.BotãoEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 664);
            this.Controls.Add(this.BotãoEntrar);
            this.Controls.Add(this.TxtSenha2);
            this.Controls.Add(this.TxtNome2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BtnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSenha2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNome2;
        private System.Windows.Forms.Button BotãoEntrar;
    }
}