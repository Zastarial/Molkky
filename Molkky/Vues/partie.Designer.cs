namespace Molkky.Vues
{
    partial class partie
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dtg_quilles = new MetroFramework.Controls.MetroGrid();
            this.tombees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_efficacePlus = new MetroFramework.Controls.MetroLabel();
            this.lbl_joueurEfficaceMoins = new MetroFramework.Controls.MetroLabel();
            this.lbl_efficaceMoins = new MetroFramework.Controls.MetroLabel();
            this.lbl_joueurEfficacePlus = new MetroFramework.Controls.MetroLabel();
            this.pgrbar_score = new MetroFramework.Controls.MetroProgressBar();
            this.lbl_tourJoueur = new MetroFramework.Controls.MetroLabel();
            this.lbl_ptsRestant = new MetroFramework.Controls.MetroLabel();
            this.lbl_nbRate = new MetroFramework.Controls.MetroLabel();
            this.lbl_rate = new MetroFramework.Controls.MetroLabel();
            this.lbl_precision = new MetroFramework.Controls.MetroLabel();
            this.lbl_precisionPourcentage = new MetroFramework.Controls.MetroLabel();
            this.lbl_ptsSolo = new MetroFramework.Controls.MetroLabel();
            this.ptb_0 = new System.Windows.Forms.PictureBox();
            this.ptb_12 = new System.Windows.Forms.PictureBox();
            this.ptb_11 = new System.Windows.Forms.PictureBox();
            this.ptb_10 = new System.Windows.Forms.PictureBox();
            this.ptb_9 = new System.Windows.Forms.PictureBox();
            this.ptb_8 = new System.Windows.Forms.PictureBox();
            this.ptb_7 = new System.Windows.Forms.PictureBox();
            this.ptb_6 = new System.Windows.Forms.PictureBox();
            this.ptb_5 = new System.Windows.Forms.PictureBox();
            this.ptb_4 = new System.Windows.Forms.PictureBox();
            this.ptb_3 = new System.Windows.Forms.PictureBox();
            this.ptb_2 = new System.Windows.Forms.PictureBox();
            this.ptb_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quilles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(321, 640);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Scorez !";
            this.metroButton1.UseSelectable = true;
            // 
            // dtg_quilles
            // 
            this.dtg_quilles.AllowUserToResizeRows = false;
            this.dtg_quilles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_quilles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_quilles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_quilles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_quilles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_quilles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_quilles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tombees,
            this.supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_quilles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_quilles.EnableHeadersVisualStyles = false;
            this.dtg_quilles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_quilles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_quilles.Location = new System.Drawing.Point(534, 377);
            this.dtg_quilles.Name = "dtg_quilles";
            this.dtg_quilles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_quilles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_quilles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_quilles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_quilles.Size = new System.Drawing.Size(243, 150);
            this.dtg_quilles.TabIndex = 13;
            this.dtg_quilles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // tombees
            // 
            this.tombees.HeaderText = "Quilles tombées";
            this.tombees.Name = "tombees";
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer la quille";
            this.supprimer.Name = "supprimer";
            // 
            // lbl_efficacePlus
            // 
            this.lbl_efficacePlus.AutoSize = true;
            this.lbl_efficacePlus.Location = new System.Drawing.Point(123, 75);
            this.lbl_efficacePlus.Name = "lbl_efficacePlus";
            this.lbl_efficacePlus.Size = new System.Drawing.Size(144, 19);
            this.lbl_efficacePlus.TabIndex = 14;
            this.lbl_efficacePlus.Text = "Joueur le plus efficace :";
            // 
            // lbl_joueurEfficaceMoins
            // 
            this.lbl_joueurEfficaceMoins.AutoSize = true;
            this.lbl_joueurEfficaceMoins.Location = new System.Drawing.Point(303, 105);
            this.lbl_joueurEfficaceMoins.Name = "lbl_joueurEfficaceMoins";
            this.lbl_joueurEfficaceMoins.Size = new System.Drawing.Size(196, 19);
            this.lbl_joueurEfficaceMoins.TabIndex = 16;
            this.lbl_joueurEfficaceMoins.Text = "*nom du joueur* (*points*/tour)";
            // 
            // lbl_efficaceMoins
            // 
            this.lbl_efficaceMoins.AutoSize = true;
            this.lbl_efficaceMoins.Location = new System.Drawing.Point(123, 105);
            this.lbl_efficaceMoins.Name = "lbl_efficaceMoins";
            this.lbl_efficaceMoins.Size = new System.Drawing.Size(156, 19);
            this.lbl_efficaceMoins.TabIndex = 17;
            this.lbl_efficaceMoins.Text = "Joueur le moins efficace :";
            this.lbl_efficaceMoins.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // lbl_joueurEfficacePlus
            // 
            this.lbl_joueurEfficacePlus.AutoSize = true;
            this.lbl_joueurEfficacePlus.Location = new System.Drawing.Point(303, 75);
            this.lbl_joueurEfficacePlus.Name = "lbl_joueurEfficacePlus";
            this.lbl_joueurEfficacePlus.Size = new System.Drawing.Size(196, 19);
            this.lbl_joueurEfficacePlus.TabIndex = 18;
            this.lbl_joueurEfficacePlus.Text = "*nom du joueur* (*points*/tour)";
            // 
            // pgrbar_score
            // 
            this.pgrbar_score.Location = new System.Drawing.Point(123, 203);
            this.pgrbar_score.Maximum = 50;
            this.pgrbar_score.Name = "pgrbar_score";
            this.pgrbar_score.Size = new System.Drawing.Size(156, 19);
            this.pgrbar_score.Step = 1;
            this.pgrbar_score.TabIndex = 20;
            // 
            // lbl_tourJoueur
            // 
            this.lbl_tourJoueur.AutoSize = true;
            this.lbl_tourJoueur.Location = new System.Drawing.Point(123, 155);
            this.lbl_tourJoueur.Name = "lbl_tourJoueur";
            this.lbl_tourJoueur.Size = new System.Drawing.Size(347, 19);
            this.lbl_tourJoueur.TabIndex = 21;
            this.lbl_tourJoueur.Text = "Au tour du joueur *nom du joueur* (*nom de l\'équipe*)  :";
            // 
            // lbl_ptsRestant
            // 
            this.lbl_ptsRestant.AutoSize = true;
            this.lbl_ptsRestant.Location = new System.Drawing.Point(285, 203);
            this.lbl_ptsRestant.Name = "lbl_ptsRestant";
            this.lbl_ptsRestant.Size = new System.Drawing.Size(168, 19);
            this.lbl_ptsRestant.TabIndex = 22;
            this.lbl_ptsRestant.Text = "*points marqué restant*/50";
            // 
            // lbl_nbRate
            // 
            this.lbl_nbRate.AutoSize = true;
            this.lbl_nbRate.Location = new System.Drawing.Point(123, 240);
            this.lbl_nbRate.Name = "lbl_nbRate";
            this.lbl_nbRate.Size = new System.Drawing.Size(85, 19);
            this.lbl_nbRate.TabIndex = 23;
            this.lbl_nbRate.Text = "Coups ratés :";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(237, 240);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(28, 19);
            this.lbl_rate.TabIndex = 24;
            this.lbl_rate.Text = "0/3";
            // 
            // lbl_precision
            // 
            this.lbl_precision.AutoSize = true;
            this.lbl_precision.Location = new System.Drawing.Point(123, 276);
            this.lbl_precision.Name = "lbl_precision";
            this.lbl_precision.Size = new System.Drawing.Size(68, 19);
            this.lbl_precision.TabIndex = 25;
            this.lbl_precision.Text = "Précision :";
            // 
            // lbl_precisionPourcentage
            // 
            this.lbl_precisionPourcentage.AutoSize = true;
            this.lbl_precisionPourcentage.Location = new System.Drawing.Point(237, 275);
            this.lbl_precisionPourcentage.Name = "lbl_precisionPourcentage";
            this.lbl_precisionPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_precisionPourcentage.TabIndex = 26;
            this.lbl_precisionPourcentage.Text = "80%";
            // 
            // lbl_ptsSolo
            // 
            this.lbl_ptsSolo.AutoSize = true;
            this.lbl_ptsSolo.Location = new System.Drawing.Point(486, 203);
            this.lbl_ptsSolo.Name = "lbl_ptsSolo";
            this.lbl_ptsSolo.Size = new System.Drawing.Size(291, 19);
            this.lbl_ptsSolo.TabIndex = 27;
            this.lbl_ptsSolo.Text = "Points marqués en solo : *nombre de points*/50";
            // 
            // ptb_0
            // 
            this.ptb_0.Image = global::Molkky.Properties.Resources._0;
            this.ptb_0.Location = new System.Drawing.Point(219, 597);
            this.ptb_0.Name = "ptb_0";
            this.ptb_0.Size = new System.Drawing.Size(48, 66);
            this.ptb_0.TabIndex = 19;
            this.ptb_0.TabStop = false;
            this.ptb_0.Click += new System.EventHandler(this.ptb_0_Click);
            // 
            // ptb_12
            // 
            this.ptb_12.BackColor = System.Drawing.Color.Transparent;
            this.ptb_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptb_12.Image = global::Molkky.Properties.Resources._12;
            this.ptb_12.Location = new System.Drawing.Point(312, 429);
            this.ptb_12.Name = "ptb_12";
            this.ptb_12.Size = new System.Drawing.Size(41, 46);
            this.ptb_12.TabIndex = 11;
            this.ptb_12.TabStop = false;
            this.ptb_12.Click += new System.EventHandler(this.ptb_12_Click);
            // 
            // ptb_11
            // 
            this.ptb_11.Image = global::Molkky.Properties.Resources._11;
            this.ptb_11.Location = new System.Drawing.Point(377, 429);
            this.ptb_11.Name = "ptb_11";
            this.ptb_11.Size = new System.Drawing.Size(42, 46);
            this.ptb_11.TabIndex = 10;
            this.ptb_11.TabStop = false;
            this.ptb_11.Click += new System.EventHandler(this.ptb_11_Click);
            // 
            // ptb_10
            // 
            this.ptb_10.Image = global::Molkky.Properties.Resources._10;
            this.ptb_10.Location = new System.Drawing.Point(346, 481);
            this.ptb_10.Name = "ptb_10";
            this.ptb_10.Size = new System.Drawing.Size(40, 46);
            this.ptb_10.TabIndex = 9;
            this.ptb_10.TabStop = false;
            this.ptb_10.Click += new System.EventHandler(this.ptb_10_Click);
            // 
            // ptb_9
            // 
            this.ptb_9.Image = global::Molkky.Properties.Resources._9;
            this.ptb_9.Location = new System.Drawing.Point(346, 377);
            this.ptb_9.Name = "ptb_9";
            this.ptb_9.Size = new System.Drawing.Size(41, 46);
            this.ptb_9.TabIndex = 8;
            this.ptb_9.TabStop = false;
            this.ptb_9.Click += new System.EventHandler(this.ptb_9_Click);
            // 
            // ptb_8
            // 
            this.ptb_8.Image = global::Molkky.Properties.Resources._8;
            this.ptb_8.Location = new System.Drawing.Point(406, 377);
            this.ptb_8.Name = "ptb_8";
            this.ptb_8.Size = new System.Drawing.Size(42, 46);
            this.ptb_8.TabIndex = 7;
            this.ptb_8.TabStop = false;
            this.ptb_8.Click += new System.EventHandler(this.ptb_8_Click);
            // 
            // ptb_7
            // 
            this.ptb_7.Image = global::Molkky.Properties.Resources._7;
            this.ptb_7.Location = new System.Drawing.Point(281, 377);
            this.ptb_7.Name = "ptb_7";
            this.ptb_7.Size = new System.Drawing.Size(41, 46);
            this.ptb_7.TabIndex = 6;
            this.ptb_7.TabStop = false;
            this.ptb_7.Click += new System.EventHandler(this.ptb_7_Click);
            // 
            // ptb_6
            // 
            this.ptb_6.Image = global::Molkky.Properties.Resources._6;
            this.ptb_6.Location = new System.Drawing.Point(439, 429);
            this.ptb_6.Name = "ptb_6";
            this.ptb_6.Size = new System.Drawing.Size(42, 46);
            this.ptb_6.TabIndex = 5;
            this.ptb_6.TabStop = false;
            this.ptb_6.Click += new System.EventHandler(this.ptb_6_Click);
            // 
            // ptb_5
            // 
            this.ptb_5.Image = global::Molkky.Properties.Resources._5;
            this.ptb_5.Location = new System.Drawing.Point(250, 429);
            this.ptb_5.Name = "ptb_5";
            this.ptb_5.Size = new System.Drawing.Size(42, 46);
            this.ptb_5.TabIndex = 4;
            this.ptb_5.TabStop = false;
            this.ptb_5.Click += new System.EventHandler(this.ptb_5_Click);
            // 
            // ptb_4
            // 
            this.ptb_4.Image = global::Molkky.Properties.Resources._4;
            this.ptb_4.Location = new System.Drawing.Point(406, 481);
            this.ptb_4.Name = "ptb_4";
            this.ptb_4.Size = new System.Drawing.Size(41, 46);
            this.ptb_4.TabIndex = 3;
            this.ptb_4.TabStop = false;
            this.ptb_4.Click += new System.EventHandler(this.ptb_4_Click);
            // 
            // ptb_3
            // 
            this.ptb_3.Image = global::Molkky.Properties.Resources._3;
            this.ptb_3.Location = new System.Drawing.Point(281, 481);
            this.ptb_3.Name = "ptb_3";
            this.ptb_3.Size = new System.Drawing.Size(41, 46);
            this.ptb_3.TabIndex = 2;
            this.ptb_3.TabStop = false;
            this.ptb_3.Click += new System.EventHandler(this.ptb_3_Click);
            // 
            // ptb_2
            // 
            this.ptb_2.Image = global::Molkky.Properties.Resources._2;
            this.ptb_2.Location = new System.Drawing.Point(368, 533);
            this.ptb_2.Name = "ptb_2";
            this.ptb_2.Size = new System.Drawing.Size(41, 46);
            this.ptb_2.TabIndex = 1;
            this.ptb_2.TabStop = false;
            this.ptb_2.Click += new System.EventHandler(this.ptb_2_Click);
            // 
            // ptb_1
            // 
            this.ptb_1.Image = global::Molkky.Properties.Resources._1;
            this.ptb_1.Location = new System.Drawing.Point(321, 533);
            this.ptb_1.Name = "ptb_1";
            this.ptb_1.Size = new System.Drawing.Size(41, 46);
            this.ptb_1.TabIndex = 0;
            this.ptb_1.TabStop = false;
            this.ptb_1.Click += new System.EventHandler(this.ptb_1_Click);
            // 
            // partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.lbl_ptsSolo);
            this.Controls.Add(this.lbl_precisionPourcentage);
            this.Controls.Add(this.lbl_precision);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_nbRate);
            this.Controls.Add(this.lbl_ptsRestant);
            this.Controls.Add(this.lbl_tourJoueur);
            this.Controls.Add(this.pgrbar_score);
            this.Controls.Add(this.ptb_0);
            this.Controls.Add(this.lbl_joueurEfficacePlus);
            this.Controls.Add(this.lbl_efficaceMoins);
            this.Controls.Add(this.lbl_joueurEfficaceMoins);
            this.Controls.Add(this.lbl_efficacePlus);
            this.Controls.Add(this.dtg_quilles);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ptb_12);
            this.Controls.Add(this.ptb_11);
            this.Controls.Add(this.ptb_10);
            this.Controls.Add(this.ptb_9);
            this.Controls.Add(this.ptb_8);
            this.Controls.Add(this.ptb_7);
            this.Controls.Add(this.ptb_6);
            this.Controls.Add(this.ptb_5);
            this.Controls.Add(this.ptb_4);
            this.Controls.Add(this.ptb_3);
            this.Controls.Add(this.ptb_2);
            this.Controls.Add(this.ptb_1);
            this.Name = "partie";
            this.Text = "Pelissä";
            this.Load += new System.EventHandler(this.lbl_efficace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quilles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_1;
        private System.Windows.Forms.PictureBox ptb_2;
        private System.Windows.Forms.PictureBox ptb_3;
        private System.Windows.Forms.PictureBox ptb_4;
        private System.Windows.Forms.PictureBox ptb_5;
        private System.Windows.Forms.PictureBox ptb_6;
        private System.Windows.Forms.PictureBox ptb_7;
        private System.Windows.Forms.PictureBox ptb_8;
        private System.Windows.Forms.PictureBox ptb_9;
        private System.Windows.Forms.PictureBox ptb_10;
        private System.Windows.Forms.PictureBox ptb_11;
        private System.Windows.Forms.PictureBox ptb_12;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid dtg_quilles;
        private System.Windows.Forms.DataGridViewTextBoxColumn tombees;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
        private MetroFramework.Controls.MetroLabel lbl_efficacePlus;
        private MetroFramework.Controls.MetroLabel lbl_joueurEfficaceMoins;
        private MetroFramework.Controls.MetroLabel lbl_efficaceMoins;
        private MetroFramework.Controls.MetroLabel lbl_joueurEfficacePlus;
        private System.Windows.Forms.PictureBox ptb_0;
        private MetroFramework.Controls.MetroProgressBar pgrbar_score;
        private MetroFramework.Controls.MetroLabel lbl_tourJoueur;
        private MetroFramework.Controls.MetroLabel lbl_ptsRestant;
        private MetroFramework.Controls.MetroLabel lbl_nbRate;
        private MetroFramework.Controls.MetroLabel lbl_rate;
        private MetroFramework.Controls.MetroLabel lbl_precision;
        private MetroFramework.Controls.MetroLabel lbl_precisionPourcentage;
        private MetroFramework.Controls.MetroLabel lbl_ptsSolo;
    }
}