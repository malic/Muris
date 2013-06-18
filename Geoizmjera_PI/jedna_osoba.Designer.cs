namespace Geoizmjera_PI
{
    partial class jedna_osoba
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
            this.lblPrezimeIIme = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblOib = new System.Windows.Forms.Label();
            this.lblMobitel = new System.Windows.Forms.Label();
            this.lblBrojKontakta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrezimeIIme
            // 
            this.lblPrezimeIIme.AutoSize = true;
            this.lblPrezimeIIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezimeIIme.Location = new System.Drawing.Point(56, 83);
            this.lblPrezimeIIme.Name = "lblPrezimeIIme";
            this.lblPrezimeIIme.Size = new System.Drawing.Size(129, 24);
            this.lblPrezimeIIme.TabIndex = 0;
            this.lblPrezimeIIme.Text = "Prezime i ime:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(56, 151);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(75, 24);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOib.Location = new System.Drawing.Point(56, 214);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(46, 24);
            this.lblOib.TabIndex = 2;
            this.lblOib.Text = "OIB:";
            // 
            // lblMobitel
            // 
            this.lblMobitel.AutoSize = true;
            this.lblMobitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMobitel.Location = new System.Drawing.Point(56, 279);
            this.lblMobitel.Name = "lblMobitel";
            this.lblMobitel.Size = new System.Drawing.Size(76, 24);
            this.lblMobitel.TabIndex = 3;
            this.lblMobitel.Text = "Mobitel:";
            // 
            // lblBrojKontakta
            // 
            this.lblBrojKontakta.AutoSize = true;
            this.lblBrojKontakta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojKontakta.Location = new System.Drawing.Point(56, 341);
            this.lblBrojKontakta.Name = "lblBrojKontakta";
            this.lblBrojKontakta.Size = new System.Drawing.Size(121, 24);
            this.lblBrojKontakta.TabIndex = 4;
            this.lblBrojKontakta.Text = "Broj kontakta:";
            // 
            // jedna_osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 545);
            this.Controls.Add(this.lblBrojKontakta);
            this.Controls.Add(this.lblMobitel);
            this.Controls.Add(this.lblOib);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrezimeIIme);
            this.Name = "jedna_osoba";
            this.Text = "Jedna osoba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrezimeIIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblOib;
        private System.Windows.Forms.Label lblMobitel;
        private System.Windows.Forms.Label lblBrojKontakta;
    }
}