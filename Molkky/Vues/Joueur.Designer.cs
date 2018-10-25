namespace Molkky.Vues
{
    partial class Joueur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_nomJoueur = new MetroFramework.Controls.MetroLabel();
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
            this.btn_statistique = new MetroFramework.Controls.MetroButton();
            this.btn_jouer = new MetroFramework.Controls.MetroButton();
            this.dtg_player = new MetroFramework.Controls.MetroGrid();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GagnerJouer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addplayer = new MetroFramework.Controls.MetroButton();
            this.tbx_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nomJoueur
            // 
            this.lbl_nomJoueur.AutoSize = true;
            this.lbl_nomJoueur.Location = new System.Drawing.Point(289, 300);
            this.lbl_nomJoueur.Name = "lbl_nomJoueur";
            this.lbl_nomJoueur.Size = new System.Drawing.Size(113, 19);
            this.lbl_nomJoueur.TabIndex = 74;
            this.lbl_nomJoueur.Text = "*Nom du Joueur*";
            // 
            // lbl_ratioPourcentage
            // 
            this.lbl_ratioPourcentage.AutoSize = true;
            this.lbl_ratioPourcentage.Location = new System.Drawing.Point(548, 456);
            this.lbl_ratioPourcentage.Name = "lbl_ratioPourcentage";
            this.lbl_ratioPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_ratioPourcentage.TabIndex = 73;
            this.lbl_ratioPourcentage.Text = "70%";
            // 
            // lbl_ratio
            // 
            this.lbl_ratio.AutoSize = true;
            this.lbl_ratio.Location = new System.Drawing.Point(428, 456);
            this.lbl_ratio.Name = "lbl_ratio";
            this.lbl_ratio.Size = new System.Drawing.Size(111, 19);
            this.lbl_ratio.TabIndex = 72;
            this.lbl_ratio.Text = "Ratio de victoire :";
            // 
            // lbl_partieGagnees
            // 
            this.lbl_partieGagnees.AutoSize = true;
            this.lbl_partieGagnees.Location = new System.Drawing.Point(243, 470);
            this.lbl_partieGagnees.Name = "lbl_partieGagnees";
            this.lbl_partieGagnees.Size = new System.Drawing.Size(179, 19);
            this.lbl_partieGagnees.TabIndex = 71;
            this.lbl_partieGagnees.Text = "*nombre de partie gagnées*";
            // 
            // lbl_partiewin
            // 
            this.lbl_partiewin.AutoSize = true;
            this.lbl_partiewin.Location = new System.Drawing.Point(117, 470);
            this.lbl_partiewin.Name = "lbl_partiewin";
            this.lbl_partiewin.Size = new System.Drawing.Size(108, 19);
            this.lbl_partiewin.TabIndex = 70;
            this.lbl_partiewin.Text = "Parties gagnées :";
            // 
            // lbl_partieJouees
            // 
            this.lbl_partieJouees.AutoSize = true;
            this.lbl_partieJouees.Location = new System.Drawing.Point(243, 440);
            this.lbl_partieJouees.Name = "lbl_partieJouees";
            this.lbl_partieJouees.Size = new System.Drawing.Size(172, 19);
            this.lbl_partieJouees.TabIndex = 69;
            this.lbl_partieJouees.Text = "*nombre de parties jouées*";
            // 
            // lbl_partieplayed
            // 
            this.lbl_partieplayed.AutoSize = true;
            this.lbl_partieplayed.Location = new System.Drawing.Point(117, 440);
            this.lbl_partieplayed.Name = "lbl_partieplayed";
            this.lbl_partieplayed.Size = new System.Drawing.Size(96, 19);
            this.lbl_partieplayed.TabIndex = 68;
            this.lbl_partieplayed.Text = "Parties jouées :";
            // 
            // lbl_efficacitePoints
            // 
            this.lbl_efficacitePoints.AutoSize = true;
            this.lbl_efficacitePoints.Location = new System.Drawing.Point(243, 393);
            this.lbl_efficacitePoints.Name = "lbl_efficacitePoints";
            this.lbl_efficacitePoints.Size = new System.Drawing.Size(155, 19);
            this.lbl_efficacitePoints.TabIndex = 67;
            this.lbl_efficacitePoints.Text = "*nombre de points*/tour";
            // 
            // lbl_efficacite
            // 
            this.lbl_efficacite.AutoSize = true;
            this.lbl_efficacite.Location = new System.Drawing.Point(117, 393);
            this.lbl_efficacite.Name = "lbl_efficacite";
            this.lbl_efficacite.Size = new System.Drawing.Size(67, 19);
            this.lbl_efficacite.TabIndex = 66;
            this.lbl_efficacite.Text = "Efficacité :";
            // 
            // lbl_precisionPourcentage
            // 
            this.lbl_precisionPourcentage.AutoSize = true;
            this.lbl_precisionPourcentage.Location = new System.Drawing.Point(243, 363);
            this.lbl_precisionPourcentage.Name = "lbl_precisionPourcentage";
            this.lbl_precisionPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_precisionPourcentage.TabIndex = 65;
            this.lbl_precisionPourcentage.Text = "80%";
            // 
            // lbl_precision
            // 
            this.lbl_precision.AutoSize = true;
            this.lbl_precision.Location = new System.Drawing.Point(117, 363);
            this.lbl_precision.Name = "lbl_precision";
            this.lbl_precision.Size = new System.Drawing.Size(123, 19);
            this.lbl_precision.TabIndex = 64;
            this.lbl_precision.Text = "Précision générale :";
            // 
            // btn_statistique
            // 
            this.btn_statistique.Location = new System.Drawing.Point(621, 209);
            this.btn_statistique.Name = "btn_statistique";
            this.btn_statistique.Size = new System.Drawing.Size(143, 23);
            this.btn_statistique.TabIndex = 63;
            this.btn_statistique.Text = "Statistique des joueurs";
            this.btn_statistique.UseSelectable = true;
            // 
            // btn_jouer
            // 
            this.btn_jouer.Location = new System.Drawing.Point(323, 644);
            this.btn_jouer.Name = "btn_jouer";
            this.btn_jouer.Size = new System.Drawing.Size(75, 23);
            this.btn_jouer.TabIndex = 62;
            this.btn_jouer.Text = "C\'est Parti !";
            this.btn_jouer.UseSelectable = true;
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
            this.dtg_player.Location = new System.Drawing.Point(381, 53);
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
            this.dtg_player.Size = new System.Drawing.Size(344, 150);
            this.dtg_player.TabIndex = 61;
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
            // btn_addplayer
            // 
            this.btn_addplayer.Location = new System.Drawing.Point(195, 112);
            this.btn_addplayer.Name = "btn_addplayer";
            this.btn_addplayer.Size = new System.Drawing.Size(122, 23);
            this.btn_addplayer.TabIndex = 60;
            this.btn_addplayer.Text = "Ajouter";
            this.btn_addplayer.UseSelectable = true;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(10, 115);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(179, 20);
            this.tbx_name.TabIndex = 59;
            this.tbx_name.Text = "Nom du joueur";
            // 
            // Joueur
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
            this.Controls.Add(this.btn_statistique);
            this.Controls.Add(this.btn_jouer);
            this.Controls.Add(this.dtg_player);
            this.Controls.Add(this.btn_addplayer);
            this.Controls.Add(this.tbx_name);
            this.Name = "Joueur";
            this.Text = "Joueurs contre Joueurs";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_nomJoueur;
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
        private MetroFramework.Controls.MetroButton btn_statistique;
        private MetroFramework.Controls.MetroButton btn_jouer;
        private MetroFramework.Controls.MetroGrid dtg_player;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GagnerJouer;
        private MetroFramework.Controls.MetroButton btn_addplayer;
        private System.Windows.Forms.TextBox tbx_name;
    }
}