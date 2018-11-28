namespace Molkky.Formulaires
{
    partial class AccueilMolkky
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
            this.btn_News = new MetroFramework.Controls.MetroButton();
            this.btn_pvp = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_News
            // 
            this.btn_News.Location = new System.Drawing.Point(500, 27);
            this.btn_News.Name = "btn_News";
            this.btn_News.Size = new System.Drawing.Size(244, 66);
            this.btn_News.TabIndex = 0;
            this.btn_News.Text = "News & Synchronisation";
            this.btn_News.UseSelectable = true;
            // 
            // btn_pvp
            // 
            this.btn_pvp.Location = new System.Drawing.Point(500, 138);
            this.btn_pvp.Name = "btn_pvp";
            this.btn_pvp.Size = new System.Drawing.Size(244, 66);
            this.btn_pvp.TabIndex = 1;
            this.btn_pvp.Text = "Lancer une partie joueur contre joueur";
            this.btn_pvp.UseSelectable = true;
            this.btn_pvp.Click += new System.EventHandler(this.btn_pvp_Click);
            // 
            // AccueilMolkky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pvp);
            this.Controls.Add(this.btn_News);
            this.Name = "AccueilMolkky";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_News;
        private MetroFramework.Controls.MetroButton btn_pvp;
    }
}