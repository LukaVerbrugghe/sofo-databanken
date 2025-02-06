namespace prjBrouwerij
{
    partial class frmBrouwerij
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
            this.lsbBrouwerijen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrouwerij = new System.Windows.Forms.TextBox();
            this.lsvBier = new System.Windows.Forms.ListView();
            this.Biernaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alcohol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kleur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBiernaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlcohol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKleur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsbBrouwerijen
            // 
            this.lsbBrouwerijen.FormattingEnabled = true;
            this.lsbBrouwerijen.Location = new System.Drawing.Point(451, 26);
            this.lsbBrouwerijen.Name = "lsbBrouwerijen";
            this.lsbBrouwerijen.Size = new System.Drawing.Size(196, 381);
            this.lsbBrouwerijen.TabIndex = 6;
            this.lsbBrouwerijen.SelectedIndexChanged += new System.EventHandler(this.lsbBrouwerijen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brouwerij";
            // 
            // txtBrouwerij
            // 
            this.txtBrouwerij.Location = new System.Drawing.Point(69, 23);
            this.txtBrouwerij.Name = "txtBrouwerij";
            this.txtBrouwerij.Size = new System.Drawing.Size(351, 20);
            this.txtBrouwerij.TabIndex = 1;
            // 
            // lsvBier
            // 
            this.lsvBier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Biernaam,
            this.Alcohol,
            this.Kleur});
            this.lsvBier.FullRowSelect = true;
            this.lsvBier.HideSelection = false;
            this.lsvBier.Location = new System.Drawing.Point(653, 26);
            this.lsvBier.Name = "lsvBier";
            this.lsvBier.Size = new System.Drawing.Size(362, 381);
            this.lsvBier.TabIndex = 7;
            this.lsvBier.UseCompatibleStateImageBehavior = false;
            this.lsvBier.View = System.Windows.Forms.View.Details;
            this.lsvBier.SelectedIndexChanged += new System.EventHandler(this.lsvBier_SelectedIndexChanged);
            // 
            // Biernaam
            // 
            this.Biernaam.Text = "Biernaam";
            // 
            // Alcohol
            // 
            this.Alcohol.Text = "Alcohol";
            // 
            // Kleur
            // 
            this.Kleur.Text = "Kleur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Biernaam";
            // 
            // txtBiernaam
            // 
            this.txtBiernaam.Location = new System.Drawing.Point(73, 66);
            this.txtBiernaam.Name = "txtBiernaam";
            this.txtBiernaam.Size = new System.Drawing.Size(347, 20);
            this.txtBiernaam.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alcohol";
            // 
            // txtAlcohol
            // 
            this.txtAlcohol.Location = new System.Drawing.Point(73, 93);
            this.txtAlcohol.Name = "txtAlcohol";
            this.txtAlcohol.Size = new System.Drawing.Size(347, 20);
            this.txtAlcohol.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kleur";
            // 
            // txtKleur
            // 
            this.txtKleur.Location = new System.Drawing.Point(73, 122);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(347, 20);
            this.txtKleur.TabIndex = 4;
            // 
            // frmBrouwerij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.txtAlcohol);
            this.Controls.Add(this.txtBiernaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvBier);
            this.Controls.Add(this.txtBrouwerij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbBrouwerijen);
            this.Name = "frmBrouwerij";
            this.Text = "Brouwerij";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbBrouwerijen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrouwerij;
        private System.Windows.Forms.ListView lsvBier;
        private System.Windows.Forms.ColumnHeader Biernaam;
        private System.Windows.Forms.ColumnHeader Alcohol;
        private System.Windows.Forms.ColumnHeader Kleur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBiernaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlcohol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKleur;
    }
}

