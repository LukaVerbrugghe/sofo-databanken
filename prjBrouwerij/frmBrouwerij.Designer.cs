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
            this.SuspendLayout();
            // 
            // lsbBrouwerijen
            // 
            this.lsbBrouwerijen.FormattingEnabled = true;
            this.lsbBrouwerijen.Location = new System.Drawing.Point(451, 26);
            this.lsbBrouwerijen.Name = "lsbBrouwerijen";
            this.lsbBrouwerijen.Size = new System.Drawing.Size(196, 381);
            this.lsbBrouwerijen.TabIndex = 0;
            // 
            // frmBrouwerij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbBrouwerijen);
            this.Name = "frmBrouwerij";
            this.Text = "Brouwerij";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbBrouwerijen;
    }
}

