namespace prjExtraOefBrouwerij
{
    partial class Form1
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
            this.btnToonData = new System.Windows.Forms.Button();
            this.lsvBrouwerijen = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emailadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtxtBeschrijvingNL = new System.Windows.Forms.RichTextBox();
            this.rtxtBeschrijvingEN = new System.Windows.Forms.RichTextBox();
            this.btnEditDescription = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToonData
            // 
            this.btnToonData.Location = new System.Drawing.Point(13, 13);
            this.btnToonData.Name = "btnToonData";
            this.btnToonData.Size = new System.Drawing.Size(674, 44);
            this.btnToonData.TabIndex = 0;
            this.btnToonData.Text = "Toon data in Listview";
            this.btnToonData.UseVisualStyleBackColor = true;
            // 
            // lsvBrouwerijen
            // 
            this.lsvBrouwerijen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Naam,
            this.Emailadres,
            this.Website});
            this.lsvBrouwerijen.HideSelection = false;
            this.lsvBrouwerijen.Location = new System.Drawing.Point(13, 63);
            this.lsvBrouwerijen.Name = "lsvBrouwerijen";
            this.lsvBrouwerijen.Size = new System.Drawing.Size(674, 324);
            this.lsvBrouwerijen.TabIndex = 1;
            this.lsvBrouwerijen.UseCompatibleStateImageBehavior = false;
            this.lsvBrouwerijen.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 200;
            // 
            // Emailadres
            // 
            this.Emailadres.Text = "Emailadres";
            this.Emailadres.Width = 200;
            // 
            // Website
            // 
            this.Website.Text = "Webpagina";
            this.Website.Width = 200;
            // 
            // rtxtBeschrijvingNL
            // 
            this.rtxtBeschrijvingNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtxtBeschrijvingNL.Location = new System.Drawing.Point(13, 394);
            this.rtxtBeschrijvingNL.Name = "rtxtBeschrijvingNL";
            this.rtxtBeschrijvingNL.Size = new System.Drawing.Size(325, 127);
            this.rtxtBeschrijvingNL.TabIndex = 2;
            this.rtxtBeschrijvingNL.Text = "";
            // 
            // rtxtBeschrijvingEN
            // 
            this.rtxtBeschrijvingEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtxtBeschrijvingEN.Location = new System.Drawing.Point(361, 393);
            this.rtxtBeschrijvingEN.Name = "rtxtBeschrijvingEN";
            this.rtxtBeschrijvingEN.Size = new System.Drawing.Size(326, 128);
            this.rtxtBeschrijvingEN.TabIndex = 2;
            this.rtxtBeschrijvingEN.Text = "";
            // 
            // btnEditDescription
            // 
            this.btnEditDescription.Location = new System.Drawing.Point(13, 528);
            this.btnEditDescription.Name = "btnEditDescription";
            this.btnEditDescription.Size = new System.Drawing.Size(325, 34);
            this.btnEditDescription.TabIndex = 3;
            this.btnEditDescription.Text = "Pas beschrijving aan";
            this.btnEditDescription.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(325, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Verwijder geselecteerde brouwerij";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 574);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditDescription);
            this.Controls.Add(this.rtxtBeschrijvingEN);
            this.Controls.Add(this.rtxtBeschrijvingNL);
            this.Controls.Add(this.lsvBrouwerijen);
            this.Controls.Add(this.btnToonData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToonData;
        private System.Windows.Forms.ListView lsvBrouwerijen;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Emailadres;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.RichTextBox rtxtBeschrijvingNL;
        private System.Windows.Forms.RichTextBox rtxtBeschrijvingEN;
        private System.Windows.Forms.Button btnEditDescription;
        private System.Windows.Forms.Button btnDelete;
    }
}

