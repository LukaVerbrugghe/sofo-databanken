namespace prjApollo
{
    partial class frmApollo
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
            this.lsvLeveranciers = new System.Windows.Forms.ListView();
            this.LVnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirmaNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gemeente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvLeveranciers
            // 
            this.lsvLeveranciers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVnr,
            this.FirmaNaam,
            this.Adres,
            this.Postnr,
            this.Gemeente});
            this.lsvLeveranciers.HideSelection = false;
            this.lsvLeveranciers.Location = new System.Drawing.Point(12, 12);
            this.lsvLeveranciers.Name = "lsvLeveranciers";
            this.lsvLeveranciers.Size = new System.Drawing.Size(292, 216);
            this.lsvLeveranciers.TabIndex = 0;
            this.lsvLeveranciers.UseCompatibleStateImageBehavior = false;
            this.lsvLeveranciers.View = System.Windows.Forms.View.Details;
            // 
            // LVnr
            // 
            this.LVnr.Text = "LVnr";
            // 
            // FirmaNaam
            // 
            this.FirmaNaam.Text = "Firma naam";
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            // 
            // Postnr
            // 
            this.Postnr.Text = "Postnr";
            // 
            // Gemeente
            // 
            this.Gemeente.Text = "Gemeente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Levrnr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Levrnr";
            // 
            // frmApollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvLeveranciers);
            this.Name = "frmApollo";
            this.Text = "Apollo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLeveranciers;
        private System.Windows.Forms.ColumnHeader LVnr;
        private System.Windows.Forms.ColumnHeader FirmaNaam;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Postnr;
        private System.Windows.Forms.ColumnHeader Gemeente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

