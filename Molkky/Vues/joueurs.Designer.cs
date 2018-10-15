namespace Molkky
{
    partial class joueurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.btn_addplayer = new MetroFramework.Controls.MetroButton();
            this.dtg_player = new MetroFramework.Controls.MetroGrid();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GagnerJouer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_jouer = new MetroFramework.Controls.MetroButton();
            this.dtg_news = new MetroFramework.Controls.MetroGrid();
            this.titre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_statistique = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_news)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(23, 122);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(179, 20);
            this.tbx_name.TabIndex = 0;
            this.tbx_name.Text = "Nom du joueur";
            // 
            // btn_addplayer
            // 
            this.btn_addplayer.Location = new System.Drawing.Point(208, 122);
            this.btn_addplayer.Name = "btn_addplayer";
            this.btn_addplayer.Size = new System.Drawing.Size(122, 23);
            this.btn_addplayer.TabIndex = 1;
            this.btn_addplayer.Text = "Ajouter";
            this.btn_addplayer.UseSelectable = true;
            // 
            // dtg_player
            // 
            this.dtg_player.AllowUserToResizeRows = false;
            this.dtg_player.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_player.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_player.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_player.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_player.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_player.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selection,
            this.nom,
            this.GagnerJouer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_player.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_player.EnableHeadersVisualStyles = false;
            this.dtg_player.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_player.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_player.Location = new System.Drawing.Point(394, 63);
            this.dtg_player.Name = "dtg_player";
            this.dtg_player.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_player.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_player.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_player.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_player.Size = new System.Drawing.Size(344, 150);
            this.dtg_player.TabIndex = 2;
            // 
            // selection
            // 
            this.selection.HeaderText = "Joueurs participants";
            this.selection.Name = "selection";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom du joueur";
            this.nom.Name = "nom";
            // 
            // GagnerJouer
            // 
            this.GagnerJouer.HeaderText = "Nombre de parties gagnées/jouées";
            this.GagnerJouer.Name = "GagnerJouer";
            // 
            // btn_jouer
            // 
            this.btn_jouer.Location = new System.Drawing.Point(336, 654);
            this.btn_jouer.Name = "btn_jouer";
            this.btn_jouer.Size = new System.Drawing.Size(75, 23);
            this.btn_jouer.TabIndex = 3;
            this.btn_jouer.Text = "C\'est Parti !";
            this.btn_jouer.UseSelectable = true;
            this.btn_jouer.Click += new System.EventHandler(this.btn_jouer_Click);
            // 
            // dtg_news
            // 
            this.dtg_news.AllowUserToResizeRows = false;
            this.dtg_news.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_news.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_news.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_news.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_news.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_news.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_news.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titre,
            this.description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_news.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_news.EnableHeadersVisualStyles = false;
            this.dtg_news.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_news.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_news.Location = new System.Drawing.Point(23, 253);
            this.dtg_news.Name = "dtg_news";
            this.dtg_news.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_news.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_news.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_news.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_news.Size = new System.Drawing.Size(493, 315);
            this.dtg_news.TabIndex = 4;
            // 
            // titre
            // 
            this.titre.HeaderText = "News";
            this.titre.Name = "titre";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 350;
            // 
            // btn_statistique
            // 
            this.btn_statistique.Location = new System.Drawing.Point(634, 219);
            this.btn_statistique.Name = "btn_statistique";
            this.btn_statistique.Size = new System.Drawing.Size(143, 23);
            this.btn_statistique.TabIndex = 5;
            this.btn_statistique.Text = "Statistique des joueurs";
            this.btn_statistique.UseSelectable = true;
            this.btn_statistique.Click += new System.EventHandler(this.btn_statistique_Click);
            // 
            // joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btn_statistique);
            this.Controls.Add(this.dtg_news);
            this.Controls.Add(this.btn_jouer);
            this.Controls.Add(this.dtg_player);
            this.Controls.Add(this.btn_addplayer);
            this.Controls.Add(this.tbx_name);
            this.Name = "joueurs";
            this.Text = "Joueurs contre Joueurs";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_news)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_name;
        private MetroFramework.Controls.MetroButton btn_addplayer;
        private MetroFramework.Controls.MetroGrid dtg_player;
        private MetroFramework.Controls.MetroButton btn_jouer;
        private MetroFramework.Controls.MetroGrid dtg_news;
        private System.Windows.Forms.DataGridViewLinkColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private MetroFramework.Controls.MetroButton btn_statistique;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GagnerJouer;
    }
}