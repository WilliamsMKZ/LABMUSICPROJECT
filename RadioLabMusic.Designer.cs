namespace LABMUSIC
{
    partial class RadioLabMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioLabMusic));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVoltar3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnOuvirRadio = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(28, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 399);
            this.listBox1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(401, 198);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(502, 403);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.BtnOuvirRadio);
            this.panel1.Controls.Add(this.BtnVoltar3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 639);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione sua Radio";
            // 
            // BtnVoltar3
            // 
            this.BtnVoltar3.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVoltar3.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltar3.BackgroundImage")));
            this.BtnVoltar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltar3.BorderRadius = 0;
            this.BtnVoltar3.ButtonText = "";
            this.BtnVoltar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar3.DisabledColor = System.Drawing.Color.Transparent;
            this.BtnVoltar3.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVoltar3.Iconimage = null;
            this.BtnVoltar3.Iconimage_right = null;
            this.BtnVoltar3.Iconimage_right_Selected = null;
            this.BtnVoltar3.Iconimage_Selected = null;
            this.BtnVoltar3.IconMarginLeft = 0;
            this.BtnVoltar3.IconMarginRight = 0;
            this.BtnVoltar3.IconRightVisible = true;
            this.BtnVoltar3.IconRightZoom = 0D;
            this.BtnVoltar3.IconVisible = true;
            this.BtnVoltar3.IconZoom = 90D;
            this.BtnVoltar3.IsTab = false;
            this.BtnVoltar3.Location = new System.Drawing.Point(10, 12);
            this.BtnVoltar3.Name = "BtnVoltar3";
            this.BtnVoltar3.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnVoltar3.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnVoltar3.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnVoltar3.selected = false;
            this.BtnVoltar3.Size = new System.Drawing.Size(55, 45);
            this.BtnVoltar3.TabIndex = 4;
            this.BtnVoltar3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar3.Textcolor = System.Drawing.Color.White;
            this.BtnVoltar3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar3.Click += new System.EventHandler(this.BtnVoltar3_Click);
            // 
            // BtnOuvirRadio
            // 
            this.BtnOuvirRadio.ActiveBorderThickness = 1;
            this.BtnOuvirRadio.ActiveCornerRadius = 20;
            this.BtnOuvirRadio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnOuvirRadio.ActiveForecolor = System.Drawing.Color.White;
            this.BtnOuvirRadio.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnOuvirRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.BtnOuvirRadio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOuvirRadio.BackgroundImage")));
            this.BtnOuvirRadio.ButtonText = "Ouvir Radio";
            this.BtnOuvirRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOuvirRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOuvirRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnOuvirRadio.IdleBorderThickness = 1;
            this.BtnOuvirRadio.IdleCornerRadius = 20;
            this.BtnOuvirRadio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnOuvirRadio.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnOuvirRadio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnOuvirRadio.Location = new System.Drawing.Point(517, 121);
            this.BtnOuvirRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOuvirRadio.Name = "BtnOuvirRadio";
            this.BtnOuvirRadio.Size = new System.Drawing.Size(284, 47);
            this.BtnOuvirRadio.TabIndex = 39;
            this.BtnOuvirRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOuvirRadio.Click += new System.EventHandler(this.BtnOuvirRadio_Click_1);
            // 
            // RadioLabMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(934, 639);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RadioLabMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioLabMusic";
            this.Load += new System.EventHandler(this.RadioLabMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVoltar3;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnOuvirRadio;
    }
}