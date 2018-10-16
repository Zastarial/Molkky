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
            this.btn_stats = new MetroFramework.Controls.MetroButton();
            this.dtg_player = new MetroFramework.Controls.MetroGrid();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GagnerJouer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addPlayer = new MetroFramework.Controls.MetroButton();
            this.tbx_namePlayer = new System.Windows.Forms.TextBox();
            this.tbx_nameTeam = new MetroFramework.Controls.MetroTextBox();
            this.btn_newTeam = new MetroFramework.Controls.MetroButton();
            this.btn_play = new MetroFramework.Controls.MetroButton();
            this.lbl_ratioPourcentage = new MetroFramework.Controls.MetroLabel();
            this.lbl_ratio = new MetroFramework.Controls.MetroLabel();
            this.lbl_partieGagnees = new MetroFramework.Controls.MetroLabel();
            this.lbl_partiewin = new MetroFramework.Controls.MetroLabel();
            this.lbl_partieJouees = new MetroFramework.Controls.MetroLabel();
            this.lbl_partieplayed = new MetroFramework.Controls.MetroLabel();
            this.lbl_efficacitePoints = new MetroFramework.Controls.MetroLabel();
            this.lbl_efficacite = new MetroFramework.Controls.MetroLabel();
            this.lbl_precisionPourcentage = new MetroFramework.Controls.MetroLabel();
            this.lbl_precision = new MetroFramework.Controls.MetroLabel();
            this.lbl_nomJoueur = new MetroFramework.Controls.MetroLabel();
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
            this.equipe,
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
            this.dtg_player.Location = new System.Drawing.Point(336, 63);
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
            this.dtg_player.Size = new System.Drawing.Size(441, 150);
            this.dtg_player.TabIndex = 8;
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
            // lbl_ratioPourcentage
            // 
            this.lbl_ratioPourcentage.AutoSize = true;
            this.lbl_ratioPourcentage.Location = new System.Drawing.Point(561, 473);
            this.lbl_ratioPourcentage.Name = "lbl_ratioPourcentage";
            this.lbl_ratioPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_ratioPourcentage.TabIndex = 46;
            this.lbl_ratioPourcentage.Text = "70%";
            // 
            // lbl_ratio
            // 
            this.lbl_ratio.AutoSize = true;
            this.lbl_ratio.Location = new System.Drawing.Point(441, 473);
            this.lbl_ratio.Name = "lbl_ratio";
            this.lbl_ratio.Size = new System.Drawing.Size(111, 19);
            this.lbl_ratio.TabIndex = 45;
            this.lbl_ratio.Text = "Ratio de victoire :";
            // 
            // lbl_partieGagnees
            // 
            this.lbl_partieGagnees.AutoSize = true;
            this.lbl_partieGagnees.Location = new System.Drawing.Point(256, 487);
            this.lbl_partieGagnees.Name = "lbl_partieGagnees";
            this.lbl_partieGagnees.Size = new System.Drawing.Size(179, 19);
            this.lbl_partieGagnees.TabIndex = 44;
            this.lbl_partieGagnees.Text = "*nombre de partie gagnées*";
            // 
            // lbl_partiewin
            // 
            this.lbl_partiewin.AutoSize = true;
            this.lbl_partiewin.Location = new System.Drawing.Point(136, 487);
            this.lbl_partiewin.Name = "lbl_partiewin";
            this.lbl_partiewin.Size = new System.Drawing.Size(108, 19);
            this.lbl_partiewin.TabIndex = 43;
            this.lbl_partiewin.Text = "Parties gagnées :";
            // 
            // lbl_partieJouees
            // 
            this.lbl_partieJouees.AutoSize = true;
            this.lbl_partieJouees.Location = new System.Drawing.Point(256, 457);
            this.lbl_partieJouees.Name = "lbl_partieJouees";
            this.lbl_partieJouees.Size = new System.Drawing.Size(172, 19);
            this.lbl_partieJouees.TabIndex = 42;
            this.lbl_partieJouees.Text = "*nombre de parties jouées*";
            // 
            // lbl_partieplayed
            // 
            this.lbl_partieplayed.AutoSize = true;
            this.lbl_partieplayed.Location = new System.Drawing.Point(136, 457);
            this.lbl_partieplayed.Name = "lbl_partieplayed";
            this.lbl_partieplayed.Size = new System.Drawing.Size(96, 19);
            this.lbl_partieplayed.TabIndex = 41;
            this.lbl_partieplayed.Text = "Parties jouées :";
            // 
            // lbl_efficacitePoints
            // 
            this.lbl_efficacitePoints.AutoSize = true;
            this.lbl_efficacitePoints.Location = new System.Drawing.Point(256, 410);
            this.lbl_efficacitePoints.Name = "lbl_efficacitePoints";
            this.lbl_efficacitePoints.Size = new System.Drawing.Size(155, 19);
            this.lbl_efficacitePoints.TabIndex = 40;
            this.lbl_efficacitePoints.Text = "*nombre de points*/tour";
            // 
            // lbl_efficacite
            // 
            this.lbl_efficacite.AutoSize = true;
            this.lbl_efficacite.Location = new System.Drawing.Point(136, 410);
            this.lbl_efficacite.Name = "lbl_efficacite";
            this.lbl_efficacite.Size = new System.Drawing.Size(67, 19);
            this.lbl_efficacite.TabIndex = 39;
            this.lbl_efficacite.Text = "Efficacité :";
            // 
            // lbl_precisionPourcentage
            // 
            this.lbl_precisionPourcentage.AutoSize = true;
            this.lbl_precisionPourcentage.Location = new System.Drawing.Point(256, 380);
            this.lbl_precisionPourcentage.Name = "lbl_precisionPourcentage";
            this.lbl_precisionPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_precisionPourcentage.TabIndex = 38;
            this.lbl_precisionPourcentage.Text = "80%";
            // 
            // lbl_precision
            // 
            this.lbl_precision.AutoSize = true;
            this.lbl_precision.Location = new System.Drawing.Point(136, 380);
            this.lbl_precision.Name = "lbl_precision";
            this.lbl_precision.Size = new System.Drawing.Size(123, 19);
            this.lbl_precision.TabIndex = 37;
            this.lbl_precision.Text = "Précision générale :";
            // 
            // lbl_nomJoueur
            // 
            this.lbl_nomJoueur.AutoSize = true;
            this.lbl_nomJoueur.Location = new System.Drawing.Point(302, 317);
            this.lbl_nomJoueur.Name = "lbl_nomJoueur";
            this.lbl_nomJoueur.Size = new System.Drawing.Size(113, 19);
            this.lbl_nomJoueur.TabIndex = 47;
            this.lbl_nomJoueur.Text = "*Nom du Joueur*";
            // 
            // Equipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.lbl_nomJoueur);
            this.Controls.Add(this.lbl_ratioPourcentage);
            this.Controls.Add(this.lbl_ratio);
            this.Controls.Add(this.lbl_partieGagnees);
            this.Controls.Add(this.lbl_partiewin);
            this.Controls.Add(this.lbl_partieJouees);
            this.Controls.Add(this.lbl_partieplayed);
            this.Controls.Add(this.lbl_efficacitePoints);
            this.Controls.Add(this.lbl_efficacite);
            this.Controls.Add(this.lbl_precisionPourcentage);
            this.Controls.Add(this.lbl_precision);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_newTeam);
            this.Controls.Add(this.tbx_nameTeam);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.dtg_player);
            this.Controls.Add(this.btn_addPlayer);
            this.Controls.Add(this.tbx_namePlayer);
            this.Name = "Equipes";
            this.Text = "Équipe contre Équipe";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_stats;
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
        private MetroFramework.Controls.MetroLabel lbl_ratioPourcentage;
        private MetroFramework.Controls.MetroLabel lbl_ratio;
        private MetroFramework.Controls.MetroLabel lbl_partieGagnees;
        private MetroFramework.Controls.MetroLabel lbl_partiewin;
        private MetroFramework.Controls.MetroLabel lbl_partieJouees;
        private MetroFramework.Controls.MetroLabel lbl_partieplayed;
        private MetroFramework.Controls.MetroLabel lbl_efficacitePoints;
        private MetroFramework.Controls.MetroLabel lbl_efficacite;
        private MetroFramework.Controls.MetroLabel lbl_precisionPourcentage;
        private MetroFramework.Controls.MetroLabel lbl_precision;
        private MetroFramework.Controls.MetroLabel lbl_nomJoueur;
    }
}