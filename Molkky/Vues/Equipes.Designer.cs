namespace Molkky.Vues
{
    partial class Equipes
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
            this.btn_stats = new MetroFramework.Controls.MetroButton();
            this.dtg_news = new MetroFramework.Controls.MetroGrid();
            this.titre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_player = new MetroFramework.Controls.MetroGrid();
            this.btn_addPlayer = new MetroFramework.Controls.MetroButton();
            this.tbx_namePlayer = new System.Windows.Forms.TextBox();
            this.tbx_nameTeam = new MetroFramework.Controls.MetroTextBox();
            this.btn_newTeam = new MetroFramework.Controls.MetroButton();
            this.btn_play = new MetroFramework.Controls.MetroButton();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GagnerJouer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_news)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(634, 219);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(143, 23);
            this.btn_stats.TabIndex = 10;
            this.btn_stats.Text = "Statistique des joueurs";
            this.btn_stats.UseSelectable = true;
            // 
            // dtg_news
            // 
            this.dtg_news.AllowUserToResizeRows = false;
            this.dtg_news.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_news.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_news.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_news.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_news.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_news.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_news.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titre,
            this.description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_news.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_news.EnableHeadersVisualStyles = false;
            this.dtg_news.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_news.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_news.Location = new System.Drawing.Point(23, 253);
            this.dtg_news.Name = "dtg_news";
            this.dtg_news.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_news.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_news.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_news.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_news.Size = new System.Drawing.Size(493, 315);
            this.dtg_news.TabIndex = 9;
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
            // dtg_player
            // 
            this.dtg_player.AllowUserToResizeRows = false;
            this.dtg_player.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_player.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_player.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_player.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_player.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_player.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selection,
            this.nom,
            this.equipe,
            this.GagnerJouer});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_player.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_player.EnableHeadersVisualStyles = false;
            this.dtg_player.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_player.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_player.Location = new System.Drawing.Point(336, 63);
            this.dtg_player.Name = "dtg_player";
            this.dtg_player.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_player.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_player.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_player.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_player.Size = new System.Drawing.Size(441, 150);
            this.dtg_player.TabIndex = 8;
            // 
            // btn_addPlayer
            // 
            this.btn_addPlayer.Location = new System.Drawing.Point(208, 125);
            this.btn_addPlayer.Name = "btn_addPlayer";
            this.btn_addPlayer.Size = new System.Drawing.Size(122, 20);
            this.btn_addPlayer.TabIndex = 7;
            this.btn_addPlayer.Text = "Ajouter";
            this.btn_addPlayer.UseSelectable = true;
            // 
            // tbx_namePlayer
            // 
            this.tbx_namePlayer.Location = new System.Drawing.Point(23, 125);
            this.tbx_namePlayer.Name = "tbx_namePlayer";
            this.tbx_namePlayer.Size = new System.Drawing.Size(179, 20);
            this.tbx_namePlayer.TabIndex = 6;
            this.tbx_namePlayer.Text = "Nom du joueur";
            // 
            // tbx_nameTeam
            // 
            // 
            // 
            // 
            this.tbx_nameTeam.CustomButton.Image = null;
            this.tbx_nameTeam.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.tbx_nameTeam.CustomButton.Name = "";
            this.tbx_nameTeam.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbx_nameTeam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_nameTeam.CustomButton.TabIndex = 1;
            this.tbx_nameTeam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_nameTeam.CustomButton.UseSelectable = true;
            this.tbx_nameTeam.CustomButton.Visible = false;
            this.tbx_nameTeam.Lines = new string[] {
        "Nom de l\'équipe"};
            this.tbx_nameTeam.Location = new System.Drawing.Point(23, 181);
            this.tbx_nameTeam.MaxLength = 32767;
            this.tbx_nameTeam.Name = "tbx_nameTeam";
            this.tbx_nameTeam.PasswordChar = '\0';
            this.tbx_nameTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_nameTeam.SelectedText = "";
            this.tbx_nameTeam.SelectionLength = 0;
            this.tbx_nameTeam.SelectionStart = 0;
            this.tbx_nameTeam.ShortcutsEnabled = true;
            this.tbx_nameTeam.Size = new System.Drawing.Size(179, 20);
            this.tbx_nameTeam.TabIndex = 11;
            this.tbx_nameTeam.Text = "Nom de l\'équipe";
            this.tbx_nameTeam.UseSelectable = true;
            this.tbx_nameTeam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_nameTeam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_newTeam
            // 
            this.btn_newTeam.Location = new System.Drawing.Point(209, 181);
            this.btn_newTeam.Name = "btn_newTeam";
            this.btn_newTeam.Size = new System.Drawing.Size(121, 20);
            this.btn_newTeam.TabIndex = 12;
            this.btn_newTeam.Text = "Nouvelle équipe";
            this.btn_newTeam.UseSelectable = true;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(336, 654);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 13;
            this.btn_play.Text = "C\'est Parti !";
            this.btn_play.UseSelectable = true;
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
            // equipe
            // 
            this.equipe.HeaderText = "Nom de l\'équipe";
            this.equipe.Name = "equipe";
            this.equipe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.equipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GagnerJouer
            // 
            this.GagnerJouer.HeaderText = "Nombre de parties gagnées/jouées";
            this.GagnerJouer.Name = "GagnerJouer";
            // 
            // Equipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_newTeam);
            this.Controls.Add(this.tbx_nameTeam);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.dtg_news);
            this.Controls.Add(this.dtg_player);
            this.Controls.Add(this.btn_addPlayer);
            this.Controls.Add(this.tbx_namePlayer);
            this.Name = "Equipes";
            this.Text = "Équipe contre Équipe";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_news)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_stats;
        private MetroFramework.Controls.MetroGrid dtg_news;
        private System.Windows.Forms.DataGridViewLinkColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private MetroFramework.Controls.MetroGrid dtg_player;
        private MetroFramework.Controls.MetroButton btn_addPlayer;
        private System.Windows.Forms.TextBox tbx_namePlayer;
        private MetroFramework.Controls.MetroTextBox tbx_nameTeam;
        private MetroFramework.Controls.MetroButton btn_newTeam;
        private MetroFramework.Controls.MetroButton btn_play;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewComboBoxColumn equipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GagnerJouer;
    }
}