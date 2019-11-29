namespace LABMUSIC
{
    partial class ArtistasFavoritos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistasFavoritos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnVoltar2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtAlbum = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.BtnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnExcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.generolabel = new System.Windows.Forms.Label();
            this.TxtGenero = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.albumlabel = new System.Windows.Forms.Label();
            this.artistalabel = new System.Windows.Forms.Label();
            this.TxtArtista = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.idlabel = new System.Windows.Forms.Label();
            this.BtnExibir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnVoltar2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 75);
            this.panel1.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Icon")));
            this.BtnBuscar.Location = new System.Drawing.Point(831, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(220, 35);
            this.BtnBuscar.TabIndex = 42;
            this.BtnBuscar.text = "";
            this.BtnBuscar.OnTextChange += new System.EventHandler(this.BtnBuscar_OnTextChange);
            // 
            // BtnVoltar2
            // 
            this.BtnVoltar2.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVoltar2.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltar2.BackgroundImage")));
            this.BtnVoltar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltar2.BorderRadius = 0;
            this.BtnVoltar2.ButtonText = "";
            this.BtnVoltar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar2.DisabledColor = System.Drawing.Color.Transparent;
            this.BtnVoltar2.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVoltar2.Iconimage = null;
            this.BtnVoltar2.Iconimage_right = null;
            this.BtnVoltar2.Iconimage_right_Selected = null;
            this.BtnVoltar2.Iconimage_Selected = null;
            this.BtnVoltar2.IconMarginLeft = 0;
            this.BtnVoltar2.IconMarginRight = 0;
            this.BtnVoltar2.IconRightVisible = true;
            this.BtnVoltar2.IconRightZoom = 0D;
            this.BtnVoltar2.IconVisible = true;
            this.BtnVoltar2.IconZoom = 90D;
            this.BtnVoltar2.IsTab = false;
            this.BtnVoltar2.Location = new System.Drawing.Point(11, 14);
            this.BtnVoltar2.Name = "BtnVoltar2";
            this.BtnVoltar2.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnVoltar2.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnVoltar2.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnVoltar2.selected = false;
            this.BtnVoltar2.Size = new System.Drawing.Size(55, 45);
            this.BtnVoltar2.TabIndex = 1;
            this.BtnVoltar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar2.Textcolor = System.Drawing.Color.White;
            this.BtnVoltar2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar2.Click += new System.EventHandler(this.BtnVoltar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(324, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARTISTAS FAVORITOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.BtnExibir);
            this.panel2.Controls.Add(this.idlabel);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.TxtAlbum);
            this.panel2.Controls.Add(this.BtnAdicionar);
            this.panel2.Controls.Add(this.BtnExcluir);
            this.panel2.Controls.Add(this.generolabel);
            this.panel2.Controls.Add(this.TxtGenero);
            this.panel2.Controls.Add(this.albumlabel);
            this.panel2.Controls.Add(this.artistalabel);
            this.panel2.Controls.Add(this.TxtArtista);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 596);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TxtAlbum
            // 
            this.TxtAlbum.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtAlbum.Location = new System.Drawing.Point(679, 97);
            this.TxtAlbum.Name = "TxtAlbum";
            this.TxtAlbum.Size = new System.Drawing.Size(206, 20);
            this.TxtAlbum.TabIndex = 41;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.ActiveBorderThickness = 1;
            this.BtnAdicionar.ActiveCornerRadius = 20;
            this.BtnAdicionar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnAdicionar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnAdicionar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.BackgroundImage")));
            this.BtnAdicionar.ButtonText = "Adicionar";
            this.BtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnAdicionar.IdleBorderThickness = 1;
            this.BtnAdicionar.IdleCornerRadius = 20;
            this.BtnAdicionar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnAdicionar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnAdicionar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnAdicionar.Location = new System.Drawing.Point(219, 171);
            this.BtnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(209, 47);
            this.BtnAdicionar.TabIndex = 40;
            this.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ActiveBorderThickness = 1;
            this.BtnExcluir.ActiveCornerRadius = 20;
            this.BtnExcluir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExcluir.ActiveForecolor = System.Drawing.Color.White;
            this.BtnExcluir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.BackgroundImage")));
            this.BtnExcluir.ButtonText = "Excluir";
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExcluir.IdleBorderThickness = 1;
            this.BtnExcluir.IdleCornerRadius = 20;
            this.BtnExcluir.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnExcluir.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExcluir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExcluir.Location = new System.Drawing.Point(463, 171);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(209, 47);
            this.BtnExcluir.TabIndex = 38;
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // generolabel
            // 
            this.generolabel.AutoSize = true;
            this.generolabel.BackColor = System.Drawing.Color.Transparent;
            this.generolabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.generolabel.Location = new System.Drawing.Point(458, 70);
            this.generolabel.Name = "generolabel";
            this.generolabel.Size = new System.Drawing.Size(77, 21);
            this.generolabel.TabIndex = 33;
            this.generolabel.Text = "Genêro :";
            // 
            // TxtGenero
            // 
            this.TxtGenero.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtGenero.Location = new System.Drawing.Point(462, 97);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(206, 20);
            this.TxtGenero.TabIndex = 32;
            // 
            // albumlabel
            // 
            this.albumlabel.AutoSize = true;
            this.albumlabel.BackColor = System.Drawing.Color.Transparent;
            this.albumlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.albumlabel.Location = new System.Drawing.Point(675, 73);
            this.albumlabel.Name = "albumlabel";
            this.albumlabel.Size = new System.Drawing.Size(70, 21);
            this.albumlabel.TabIndex = 31;
            this.albumlabel.Text = "Album :";
            // 
            // artistalabel
            // 
            this.artistalabel.AutoSize = true;
            this.artistalabel.BackColor = System.Drawing.Color.Transparent;
            this.artistalabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistalabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.artistalabel.Location = new System.Drawing.Point(243, 70);
            this.artistalabel.Name = "artistalabel";
            this.artistalabel.Size = new System.Drawing.Size(70, 21);
            this.artistalabel.TabIndex = 30;
            this.artistalabel.Text = "Artista :";
            // 
            // TxtArtista
            // 
            this.TxtArtista.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtArtista.Location = new System.Drawing.Point(246, 97);
            this.TxtArtista.Name = "TxtArtista";
            this.TxtArtista.Size = new System.Drawing.Size(206, 20);
            this.TxtArtista.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1134, 370);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtID
            // 
            this.TxtID.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtID.Location = new System.Drawing.Point(187, 97);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(51, 20);
            this.TxtID.TabIndex = 42;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.Color.Transparent;
            this.idlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(72)))));
            this.idlabel.Location = new System.Drawing.Point(184, 71);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(31, 21);
            this.idlabel.TabIndex = 43;
            this.idlabel.Text = "ID:";
            this.idlabel.Click += new System.EventHandler(this.idlabel_Click);
            // 
            // BtnExibir
            // 
            this.BtnExibir.ActiveBorderThickness = 1;
            this.BtnExibir.ActiveCornerRadius = 20;
            this.BtnExibir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExibir.ActiveForecolor = System.Drawing.Color.White;
            this.BtnExibir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnExibir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExibir.BackgroundImage")));
            this.BtnExibir.ButtonText = "Exibir";
            this.BtnExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExibir.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExibir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExibir.IdleBorderThickness = 1;
            this.BtnExibir.IdleCornerRadius = 20;
            this.BtnExibir.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnExibir.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExibir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(38)))), ((int)(((byte)(72)))));
            this.BtnExibir.Location = new System.Drawing.Point(699, 171);
            this.BtnExibir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(209, 47);
            this.BtnExibir.TabIndex = 44;
            this.BtnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // ArtistasFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArtistasFavoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtistasFavoritos";
            this.Load += new System.EventHandler(this.ArtistasFavoritos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVoltar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label generolabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtGenero;
        private System.Windows.Forms.Label albumlabel;
        private System.Windows.Forms.Label artistalabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtArtista;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtAlbum;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAdicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnExcluir;
        private Bunifu.Framework.UI.BunifuTextbox BtnBuscar;
        private System.Windows.Forms.Label idlabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtID;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnExibir;
    }
}