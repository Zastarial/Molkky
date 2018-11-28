namespace Molkky.Formulaires
{
    partial class SelectionJoueur
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
            this.dtgv_joueur = new System.Windows.Forms.DataGridView();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.btn_nom = new System.Windows.Forms.Button();
            this.btn_lancementPartie = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_joueur)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_joueur
            // 
            this.dtgv_joueur.AllowUserToAddRows = false;
            this.dtgv_joueur.AllowUserToDeleteRows = false;
            this.dtgv_joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_joueur.Location = new System.Drawing.Point(382, 31);
            this.dtgv_joueur.Name = "dtgv_joueur";
            this.dtgv_joueur.ReadOnly = true;
            this.dtgv_joueur.Size = new System.Drawing.Size(351, 234);
            this.dtgv_joueur.TabIndex = 0;
            // 
            // tbx_nom
            // 
            this.tbx_nom.Location = new System.Drawing.Point(12, 90);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(161, 20);
            this.tbx_nom.TabIndex = 1;
            this.tbx_nom.Text = "Nom du joueur";
            // 
            // btn_nom
            // 
            this.btn_nom.Location = new System.Drawing.Point(179, 90);
            this.btn_nom.Name = "btn_nom";
            this.btn_nom.Size = new System.Drawing.Size(122, 20);
            this.btn_nom.TabIndex = 2;
            this.btn_nom.Text = "Ajout du joueur";
            this.btn_nom.UseVisualStyleBackColor = true;
            this.btn_nom.Click += new System.EventHandler(this.btn_nom_Click);
            // 
            // btn_lancementPartie
            // 
            this.btn_lancementPartie.Location = new System.Drawing.Point(496, 327);
            this.btn_lancementPartie.Name = "btn_lancementPartie";
            this.btn_lancementPartie.Size = new System.Drawing.Size(237, 64);
            this.btn_lancementPartie.TabIndex = 3;
            this.btn_lancementPartie.Text = "Lancer la partie";
            this.btn_lancementPartie.UseVisualStyleBackColor = true;
            this.btn_lancementPartie.Click += new System.EventHandler(this.btn_lancementPartie_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(179, 327);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(103, 46);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SelectionJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_lancementPartie);
            this.Controls.Add(this.btn_nom);
            this.Controls.Add(this.tbx_nom);
            this.Controls.Add(this.dtgv_joueur);
            this.Name = "SelectionJoueur";
            this.Text = "SelectionJoueur";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_joueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_joueur;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.Button btn_nom;
        private System.Windows.Forms.Button btn_lancementPartie;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}