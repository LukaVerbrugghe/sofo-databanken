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
            this.txtLevernr = new System.Windows.Forms.TextBox();
            this.txtFirmaNaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lsvWijnen = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Omschrijving = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inhoud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoeveelheid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtJaar = new System.Windows.Forms.TextBox();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInhoud = new System.Windows.Forms.TextBox();
            this.txtPrijsPerFles = new System.Windows.Forms.TextBox();
            this.txtHoeveelheid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVoorraad = new System.Windows.Forms.TextBox();
            this.btnWijnWijzigen = new System.Windows.Forms.Button();
            this.btnWijnAdd = new System.Windows.Forms.Button();
            this.btnVerwijderWijn = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(115, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma naam";
            // 
            // txtLevernr
            // 
            this.txtLevernr.Location = new System.Drawing.Point(12, 261);
            this.txtLevernr.Name = "txtLevernr";
            this.txtLevernr.Size = new System.Drawing.Size(100, 20);
            this.txtLevernr.TabIndex = 2;
            // 
            // txtFirmaNaam
            // 
            this.txtFirmaNaam.Location = new System.Drawing.Point(118, 261);
            this.txtFirmaNaam.Name = "txtFirmaNaam";
            this.txtFirmaNaam.Size = new System.Drawing.Size(100, 20);
            this.txtFirmaNaam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Postnr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gemeente";
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(12, 312);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 2;
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(118, 312);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(100, 20);
            this.txtGemeente.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(224, 261);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 3;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(12, 366);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 4;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(224, 366);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(519, 12);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 21);
            this.cmbSort.TabIndex = 5;
            // 
            // lsvWijnen
            // 
            this.lsvWijnen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Jaar,
            this.Omschrijving,
            this.Inhoud,
            this.ppf,
            this.Hoeveelheid,
            this.Voorraad});
            this.lsvWijnen.HideSelection = false;
            this.lsvWijnen.Location = new System.Drawing.Point(339, 39);
            this.lsvWijnen.Name = "lsvWijnen";
            this.lsvWijnen.Size = new System.Drawing.Size(449, 189);
            this.lsvWijnen.TabIndex = 6;
            this.lsvWijnen.UseCompatibleStateImageBehavior = false;
            this.lsvWijnen.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            // 
            // Jaar
            // 
            this.Jaar.Text = "Jaar";
            // 
            // Omschrijving
            // 
            this.Omschrijving.Text = "Omschrijving";
            // 
            // Inhoud
            // 
            this.Inhoud.Text = "Inhoud";
            // 
            // ppf
            // 
            this.ppf.Text = "Prijs per fles";
            // 
            // Hoeveelheid
            // 
            this.Hoeveelheid.Text = "Hoeveelheid";
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Jaar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Omschrijving";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(445, 261);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtJaar
            // 
            this.txtJaar.Location = new System.Drawing.Point(551, 261);
            this.txtJaar.Name = "txtJaar";
            this.txtJaar.Size = new System.Drawing.Size(100, 20);
            this.txtJaar.TabIndex = 3;
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(657, 261);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(100, 20);
            this.txtOmschrijving.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Inhoud";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "PrijsPerFles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Hoeveelheid";
            // 
            // txtInhoud
            // 
            this.txtInhoud.Location = new System.Drawing.Point(339, 312);
            this.txtInhoud.Name = "txtInhoud";
            this.txtInhoud.Size = new System.Drawing.Size(100, 20);
            this.txtInhoud.TabIndex = 2;
            // 
            // txtPrijsPerFles
            // 
            this.txtPrijsPerFles.Location = new System.Drawing.Point(445, 312);
            this.txtPrijsPerFles.Name = "txtPrijsPerFles";
            this.txtPrijsPerFles.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsPerFles.TabIndex = 3;
            // 
            // txtHoeveelheid
            // 
            this.txtHoeveelheid.Location = new System.Drawing.Point(551, 312);
            this.txtHoeveelheid.Name = "txtHoeveelheid";
            this.txtHoeveelheid.Size = new System.Drawing.Size(100, 20);
            this.txtHoeveelheid.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Voorraad";
            // 
            // txtVoorraad
            // 
            this.txtVoorraad.Location = new System.Drawing.Point(657, 312);
            this.txtVoorraad.Name = "txtVoorraad";
            this.txtVoorraad.Size = new System.Drawing.Size(100, 20);
            this.txtVoorraad.TabIndex = 3;
            // 
            // btnWijnWijzigen
            // 
            this.btnWijnWijzigen.Location = new System.Drawing.Point(445, 366);
            this.btnWijnWijzigen.Name = "btnWijnWijzigen";
            this.btnWijnWijzigen.Size = new System.Drawing.Size(75, 23);
            this.btnWijnWijzigen.TabIndex = 4;
            this.btnWijnWijzigen.Text = "Wijzig";
            this.btnWijnWijzigen.UseVisualStyleBackColor = true;
            // 
            // btnWijnAdd
            // 
            this.btnWijnAdd.Location = new System.Drawing.Point(551, 366);
            this.btnWijnAdd.Name = "btnWijnAdd";
            this.btnWijnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWijnAdd.TabIndex = 4;
            this.btnWijnAdd.Text = "Add";
            this.btnWijnAdd.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderWijn
            // 
            this.btnVerwijderWijn.Location = new System.Drawing.Point(657, 366);
            this.btnVerwijderWijn.Name = "btnVerwijderWijn";
            this.btnVerwijderWijn.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderWijn.TabIndex = 4;
            this.btnVerwijderWijn.Text = "Verwijder";
            this.btnVerwijderWijn.UseVisualStyleBackColor = true;
            // 
            // frmApollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvWijnen);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnVerwijderWijn);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWijnAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnWijnWijzigen);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.txtVoorraad);
            this.Controls.Add(this.txtHoeveelheid);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtPrijsPerFles);
            this.Controls.Add(this.txtJaar);
            this.Controls.Add(this.txtFirmaNaam);
            this.Controls.Add(this.txtPostnr);
            this.Controls.Add(this.txtInhoud);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLevernr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.TextBox txtLevernr;
        private System.Windows.Forms.TextBox txtFirmaNaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ListView lsvWijnen;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Jaar;
        private System.Windows.Forms.ColumnHeader Omschrijving;
        private System.Windows.Forms.ColumnHeader Inhoud;
        private System.Windows.Forms.ColumnHeader ppf;
        private System.Windows.Forms.ColumnHeader Hoeveelheid;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtJaar;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInhoud;
        private System.Windows.Forms.TextBox txtPrijsPerFles;
        private System.Windows.Forms.TextBox txtHoeveelheid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVoorraad;
        private System.Windows.Forms.Button btnWijnWijzigen;
        private System.Windows.Forms.Button btnWijnAdd;
        private System.Windows.Forms.Button btnVerwijderWijn;
    }
}

