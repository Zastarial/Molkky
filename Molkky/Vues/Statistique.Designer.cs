namespace Molkky.Vues
{
    partial class Statistique
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
            this.lbl_precisionPourcentage = new MetroFramework.Controls.MetroLabel();
            this.lbl_precision = new MetroFramework.Controls.MetroLabel();
            this.lbl_efficacitePoints = new MetroFramework.Controls.MetroLabel();
            this.lbl_efficacite = new MetroFramework.Controls.MetroLabel();
            this.lbl_partieGagnees = new MetroFramework.Controls.MetroLabel();
            this.lbl_partiewin = new MetroFramework.Controls.MetroLabel();
            this.lbl_partieJouees = new MetroFramework.Controls.MetroLabel();
            this.lbl_partieplayed = new MetroFramework.Controls.MetroLabel();
            this.lbl_ratioPourcentage = new MetroFramework.Controls.MetroLabel();
            this.lbl_ratio = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbl_precisionPourcentage
            // 
            this.lbl_precisionPourcentage.AutoSize = true;
            this.lbl_precisionPourcentage.Location = new System.Drawing.Point(254, 131);
            this.lbl_precisionPourcentage.Name = "lbl_precisionPourcentage";
            this.lbl_precisionPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_precisionPourcentage.TabIndex = 28;
            this.lbl_precisionPourcentage.Text = "80%";
            // 
            // lbl_precision
            // 
            this.lbl_precision.AutoSize = true;
            this.lbl_precision.Location = new System.Drawing.Point(134, 131);
            this.lbl_precision.Name = "lbl_precision";
            this.lbl_precision.Size = new System.Drawing.Size(123, 19);
            this.lbl_precision.TabIndex = 27;
            this.lbl_precision.Text = "Précision générale :";
            // 
            // lbl_efficacitePoints
            // 
            this.lbl_efficacitePoints.AutoSize = true;
            this.lbl_efficacitePoints.Location = new System.Drawing.Point(254, 161);
            this.lbl_efficacitePoints.Name = "lbl_efficacitePoints";
            this.lbl_efficacitePoints.Size = new System.Drawing.Size(155, 19);
            this.lbl_efficacitePoints.TabIndex = 30;
            this.lbl_efficacitePoints.Text = "*nombre de points*/tour";
            // 
            // lbl_efficacite
            // 
            this.lbl_efficacite.AutoSize = true;
            this.lbl_efficacite.Location = new System.Drawing.Point(134, 161);
            this.lbl_efficacite.Name = "lbl_efficacite";
            this.lbl_efficacite.Size = new System.Drawing.Size(67, 19);
            this.lbl_efficacite.TabIndex = 29;
            this.lbl_efficacite.Text = "Efficacité :";
            // 
            // lbl_partieGagnees
            // 
            this.lbl_partieGagnees.AutoSize = true;
            this.lbl_partieGagnees.Location = new System.Drawing.Point(254, 238);
            this.lbl_partieGagnees.Name = "lbl_partieGagnees";
            this.lbl_partieGagnees.Size = new System.Drawing.Size(179, 19);
            this.lbl_partieGagnees.TabIndex = 34;
            this.lbl_partieGagnees.Text = "*nombre de partie gagnées*";
            // 
            // lbl_partiewin
            // 
            this.lbl_partiewin.AutoSize = true;
            this.lbl_partiewin.Location = new System.Drawing.Point(134, 238);
            this.lbl_partiewin.Name = "lbl_partiewin";
            this.lbl_partiewin.Size = new System.Drawing.Size(108, 19);
            this.lbl_partiewin.TabIndex = 33;
            this.lbl_partiewin.Text = "Parties gagnées :";
            // 
            // lbl_partieJouees
            // 
            this.lbl_partieJouees.AutoSize = true;
            this.lbl_partieJouees.Location = new System.Drawing.Point(254, 208);
            this.lbl_partieJouees.Name = "lbl_partieJouees";
            this.lbl_partieJouees.Size = new System.Drawing.Size(172, 19);
            this.lbl_partieJouees.TabIndex = 32;
            this.lbl_partieJouees.Text = "*nombre de parties jouées*";
            // 
            // lbl_partieplayed
            // 
            this.lbl_partieplayed.AutoSize = true;
            this.lbl_partieplayed.Location = new System.Drawing.Point(134, 208);
            this.lbl_partieplayed.Name = "lbl_partieplayed";
            this.lbl_partieplayed.Size = new System.Drawing.Size(96, 19);
            this.lbl_partieplayed.TabIndex = 31;
            this.lbl_partieplayed.Text = "Parties jouées :";
            // 
            // lbl_ratioPourcentage
            // 
            this.lbl_ratioPourcentage.AutoSize = true;
            this.lbl_ratioPourcentage.Location = new System.Drawing.Point(285, 280);
            this.lbl_ratioPourcentage.Name = "lbl_ratioPourcentage";
            this.lbl_ratioPourcentage.Size = new System.Drawing.Size(34, 19);
            this.lbl_ratioPourcentage.TabIndex = 36;
            this.lbl_ratioPourcentage.Text = "70%";
            // 
            // lbl_ratio
            // 
            this.lbl_ratio.AutoSize = true;
            this.lbl_ratio.Location = new System.Drawing.Point(165, 280);
            this.lbl_ratio.Name = "lbl_ratio";
            this.lbl_ratio.Size = new System.Drawing.Size(111, 19);
            this.lbl_ratio.TabIndex = 35;
            this.lbl_ratio.Text = "Ratio de victoire :";
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
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
            this.Name = "Statistique";
            this.Text = "*nom du joueur*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_precisionPourcentage;
        private MetroFramework.Controls.MetroLabel lbl_precision;
        private MetroFramework.Controls.MetroLabel lbl_efficacitePoints;
        private MetroFramework.Controls.MetroLabel lbl_efficacite;
        private MetroFramework.Controls.MetroLabel lbl_partieGagnees;
        private MetroFramework.Controls.MetroLabel lbl_partiewin;
        private MetroFramework.Controls.MetroLabel lbl_partieJouees;
        private MetroFramework.Controls.MetroLabel lbl_partieplayed;
        private MetroFramework.Controls.MetroLabel lbl_ratioPourcentage;
        private MetroFramework.Controls.MetroLabel lbl_ratio;
    }
}