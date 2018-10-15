namespace Molkky
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.btn_solo = new MetroFramework.Controls.MetroButton();
            this.btn_team = new MetroFramework.Controls.MetroButton();
            this.tbx_rules = new System.Windows.Forms.RichTextBox();
            this.ptb_molkky = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_molkky)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_solo
            // 
            this.btn_solo.Location = new System.Drawing.Point(102, 238);
            this.btn_solo.Name = "btn_solo";
            this.btn_solo.Size = new System.Drawing.Size(126, 23);
            this.btn_solo.TabIndex = 0;
            this.btn_solo.Text = "Joueur contre Joueur";
            this.btn_solo.UseSelectable = true;
            this.btn_solo.Click += new System.EventHandler(this.btn_solo_Click);
            // 
            // btn_team
            // 
            this.btn_team.Location = new System.Drawing.Point(569, 238);
            this.btn_team.Name = "btn_team";
            this.btn_team.Size = new System.Drawing.Size(126, 23);
            this.btn_team.TabIndex = 1;
            this.btn_team.Text = "Équipe contre Équipe";
            this.btn_team.UseSelectable = true;
            this.btn_team.Click += new System.EventHandler(this.btn_team_Click);
            // 
            // tbx_rules
            // 
            this.tbx_rules.Location = new System.Drawing.Point(102, 337);
            this.tbx_rules.Name = "tbx_rules";
            this.tbx_rules.ReadOnly = true;
            this.tbx_rules.Size = new System.Drawing.Size(593, 330);
            this.tbx_rules.TabIndex = 3;
            this.tbx_rules.Text = resources.GetString("tbx_rules.Text");
            // 
            // ptb_molkky
            // 
            this.ptb_molkky.Image = global::Molkky.Properties.Resources.molkky_position_798;
            this.ptb_molkky.Location = new System.Drawing.Point(293, 134);
            this.ptb_molkky.Name = "ptb_molkky";
            this.ptb_molkky.Size = new System.Drawing.Size(200, 197);
            this.ptb_molkky.TabIndex = 4;
            this.ptb_molkky.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.ptb_molkky);
            this.Controls.Add(this.tbx_rules);
            this.Controls.Add(this.btn_team);
            this.Controls.Add(this.btn_solo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.Text = "Tulostaulu Mölkky";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_molkky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_solo;
        private MetroFramework.Controls.MetroButton btn_team;
        private System.Windows.Forms.RichTextBox tbx_rules;
        private System.Windows.Forms.PictureBox ptb_molkky;
    }
}