namespace McFit_Kundenkartei
{
    partial class Kundenverwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kundenverwaltung));
            this.textBox_Vorname = new System.Windows.Forms.TextBox();
            this.textBox_Nachname = new System.Windows.Forms.TextBox();
            this.textBox_Geburtsdatum = new System.Windows.Forms.TextBox();
            this.label_Vorname = new System.Windows.Forms.Label();
            this.label_Nachname = new System.Windows.Forms.Label();
            this.label_Geburtsdatum = new System.Windows.Forms.Label();
            this.button_Löschen = new System.Windows.Forms.Button();
            this.button_Ändern = new System.Windows.Forms.Button();
            this.button_Übernehmen = new System.Windows.Forms.Button();
            this.button_Abbrechen = new System.Windows.Forms.Button();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Mitarbeiternummer = new System.Windows.Forms.Label();
            this.label_Gehalt = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Gebuehren = new System.Windows.Forms.Label();
            this.label_BMI = new System.Windows.Forms.Label();
            this.label_Kundennummer = new System.Windows.Forms.Label();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_Kundennummer = new System.Windows.Forms.TextBox();
            this.textBox_BMI = new System.Windows.Forms.TextBox();
            this.textBox_Mitarbeiternummer = new System.Windows.Forms.TextBox();
            this.textBox_Gehalt = new System.Windows.Forms.TextBox();
            this.textBox_Gebuehren = new System.Windows.Forms.TextBox();
            this.radioButton_Mitarbeiter = new System.Windows.Forms.RadioButton();
            this.radioButton_Kunde = new System.Windows.Forms.RadioButton();
            this.listBox_Ausgabe = new System.Windows.Forms.ListBox();
            this.button_Speichern = new System.Windows.Forms.Button();
            this.saveFileList = new System.Windows.Forms.SaveFileDialog();
            this.openFileList = new System.Windows.Forms.OpenFileDialog();
            this.button_Laden = new System.Windows.Forms.Button();
            this.label_boxMitarbeiter = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Vorname
            // 
            this.textBox_Vorname.Location = new System.Drawing.Point(85, 57);
            this.textBox_Vorname.Name = "textBox_Vorname";
            this.textBox_Vorname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Vorname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Vorname.TabIndex = 0;
            this.textBox_Vorname.TextChanged += new System.EventHandler(this.textBox_Vorname_TextChanged);
            // 
            // textBox_Nachname
            // 
            this.textBox_Nachname.Location = new System.Drawing.Point(85, 101);
            this.textBox_Nachname.Name = "textBox_Nachname";
            this.textBox_Nachname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nachname.TabIndex = 1;
            // 
            // textBox_Geburtsdatum
            // 
            this.textBox_Geburtsdatum.Location = new System.Drawing.Point(85, 146);
            this.textBox_Geburtsdatum.Name = "textBox_Geburtsdatum";
            this.textBox_Geburtsdatum.Size = new System.Drawing.Size(100, 20);
            this.textBox_Geburtsdatum.TabIndex = 2;
            // 
            // label_Vorname
            // 
            this.label_Vorname.AutoSize = true;
            this.label_Vorname.Location = new System.Drawing.Point(27, 60);
            this.label_Vorname.Name = "label_Vorname";
            this.label_Vorname.Size = new System.Drawing.Size(52, 13);
            this.label_Vorname.TabIndex = 3;
            this.label_Vorname.Text = "Vorname:";
            // 
            // label_Nachname
            // 
            this.label_Nachname.AutoSize = true;
            this.label_Nachname.Location = new System.Drawing.Point(17, 104);
            this.label_Nachname.Name = "label_Nachname";
            this.label_Nachname.Size = new System.Drawing.Size(62, 13);
            this.label_Nachname.TabIndex = 4;
            this.label_Nachname.Text = "Nachname:";
            // 
            // label_Geburtsdatum
            // 
            this.label_Geburtsdatum.AutoSize = true;
            this.label_Geburtsdatum.Location = new System.Drawing.Point(3, 149);
            this.label_Geburtsdatum.Name = "label_Geburtsdatum";
            this.label_Geburtsdatum.Size = new System.Drawing.Size(76, 13);
            this.label_Geburtsdatum.TabIndex = 5;
            this.label_Geburtsdatum.Text = "Geburtsdatum:";
            // 
            // button_Löschen
            // 
            this.button_Löschen.Location = new System.Drawing.Point(99, 190);
            this.button_Löschen.Name = "button_Löschen";
            this.button_Löschen.Size = new System.Drawing.Size(75, 23);
            this.button_Löschen.TabIndex = 6;
            this.button_Löschen.Text = "Löschen";
            this.button_Löschen.UseVisualStyleBackColor = true;
            this.button_Löschen.Click += new System.EventHandler(this.button_Löschen_Click);
            // 
            // button_Ändern
            // 
            this.button_Ändern.Location = new System.Drawing.Point(180, 190);
            this.button_Ändern.Name = "button_Ändern";
            this.button_Ändern.Size = new System.Drawing.Size(75, 23);
            this.button_Ändern.TabIndex = 7;
            this.button_Ändern.Text = "Ändern";
            this.button_Ändern.UseVisualStyleBackColor = true;
            this.button_Ändern.Click += new System.EventHandler(this.button_Ändern_Click);
            // 
            // button_Übernehmen
            // 
            this.button_Übernehmen.Location = new System.Drawing.Point(261, 190);
            this.button_Übernehmen.Name = "button_Übernehmen";
            this.button_Übernehmen.Size = new System.Drawing.Size(83, 23);
            this.button_Übernehmen.TabIndex = 8;
            this.button_Übernehmen.Text = "Übernehmen";
            this.button_Übernehmen.UseVisualStyleBackColor = true;
            this.button_Übernehmen.Click += new System.EventHandler(this.button_Übernehmen_Click);
            // 
            // button_Abbrechen
            // 
            this.button_Abbrechen.Location = new System.Drawing.Point(350, 190);
            this.button_Abbrechen.Name = "button_Abbrechen";
            this.button_Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.button_Abbrechen.TabIndex = 9;
            this.button_Abbrechen.Text = "Abbrechen";
            this.button_Abbrechen.UseVisualStyleBackColor = true;
            this.button_Abbrechen.Click += new System.EventHandler(this.button_Abbrechen_Click);
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.Image")));
            this.pictureBox_Icon.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(512, 227);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Icon.TabIndex = 10;
            this.pictureBox_Icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label_Mitarbeiternummer);
            this.panel1.Controls.Add(this.label_Gehalt);
            this.panel1.Controls.Add(this.label_Status);
            this.panel1.Controls.Add(this.label_Gebuehren);
            this.panel1.Controls.Add(this.label_BMI);
            this.panel1.Controls.Add(this.label_Kundennummer);
            this.panel1.Controls.Add(this.textBox_Status);
            this.panel1.Controls.Add(this.textBox_Kundennummer);
            this.panel1.Controls.Add(this.textBox_BMI);
            this.panel1.Controls.Add(this.textBox_Mitarbeiternummer);
            this.panel1.Controls.Add(this.textBox_Gehalt);
            this.panel1.Controls.Add(this.textBox_Gebuehren);
            this.panel1.Controls.Add(this.radioButton_Mitarbeiter);
            this.panel1.Controls.Add(this.radioButton_Kunde);
            this.panel1.Controls.Add(this.button_Abbrechen);
            this.panel1.Controls.Add(this.button_Übernehmen);
            this.panel1.Controls.Add(this.label_Geburtsdatum);
            this.panel1.Controls.Add(this.button_Löschen);
            this.panel1.Controls.Add(this.label_Nachname);
            this.panel1.Controls.Add(this.button_Ändern);
            this.panel1.Controls.Add(this.label_Vorname);
            this.panel1.Controls.Add(this.textBox_Nachname);
            this.panel1.Controls.Add(this.textBox_Geburtsdatum);
            this.panel1.Controls.Add(this.textBox_Vorname);
            this.panel1.Location = new System.Drawing.Point(12, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 228);
            this.panel1.TabIndex = 11;
            // 
            // label_Mitarbeiternummer
            // 
            this.label_Mitarbeiternummer.AutoSize = true;
            this.label_Mitarbeiternummer.Location = new System.Drawing.Point(391, 41);
            this.label_Mitarbeiternummer.Name = "label_Mitarbeiternummer";
            this.label_Mitarbeiternummer.Size = new System.Drawing.Size(93, 13);
            this.label_Mitarbeiternummer.TabIndex = 28;
            this.label_Mitarbeiternummer.Text = "Mitarbeiternummer";
            // 
            // label_Gehalt
            // 
            this.label_Gehalt.AutoSize = true;
            this.label_Gehalt.Location = new System.Drawing.Point(391, 88);
            this.label_Gehalt.Name = "label_Gehalt";
            this.label_Gehalt.Size = new System.Drawing.Size(38, 13);
            this.label_Gehalt.TabIndex = 27;
            this.label_Gehalt.Text = "Gehalt";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(391, 130);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 26;
            this.label_Status.Text = "Status";
            // 
            // label_Gebuehren
            // 
            this.label_Gebuehren.AutoSize = true;
            this.label_Gebuehren.Location = new System.Drawing.Point(241, 86);
            this.label_Gebuehren.Name = "label_Gebuehren";
            this.label_Gebuehren.Size = new System.Drawing.Size(103, 13);
            this.label_Gebuehren.TabIndex = 25;
            this.label_Gebuehren.Text = "Gebühren beglichen";
            // 
            // label_BMI
            // 
            this.label_BMI.AutoSize = true;
            this.label_BMI.Location = new System.Drawing.Point(241, 125);
            this.label_BMI.Name = "label_BMI";
            this.label_BMI.Size = new System.Drawing.Size(26, 13);
            this.label_BMI.TabIndex = 24;
            this.label_BMI.Text = "BMI";
            // 
            // label_Kundennummer
            // 
            this.label_Kundennummer.AutoSize = true;
            this.label_Kundennummer.Location = new System.Drawing.Point(241, 41);
            this.label_Kundennummer.Name = "label_Kundennummer";
            this.label_Kundennummer.Size = new System.Drawing.Size(81, 13);
            this.label_Kundennummer.TabIndex = 23;
            this.label_Kundennummer.Text = "Kundennummer";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(394, 146);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(100, 20);
            this.textBox_Status.TabIndex = 22;
            // 
            // textBox_Kundennummer
            // 
            this.textBox_Kundennummer.Location = new System.Drawing.Point(244, 57);
            this.textBox_Kundennummer.Name = "textBox_Kundennummer";
            this.textBox_Kundennummer.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kundennummer.TabIndex = 21;
            // 
            // textBox_BMI
            // 
            this.textBox_BMI.Location = new System.Drawing.Point(244, 142);
            this.textBox_BMI.Name = "textBox_BMI";
            this.textBox_BMI.Size = new System.Drawing.Size(100, 20);
            this.textBox_BMI.TabIndex = 20;
            // 
            // textBox_Mitarbeiternummer
            // 
            this.textBox_Mitarbeiternummer.Location = new System.Drawing.Point(394, 57);
            this.textBox_Mitarbeiternummer.Name = "textBox_Mitarbeiternummer";
            this.textBox_Mitarbeiternummer.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mitarbeiternummer.TabIndex = 19;
            // 
            // textBox_Gehalt
            // 
            this.textBox_Gehalt.Location = new System.Drawing.Point(394, 104);
            this.textBox_Gehalt.Name = "textBox_Gehalt";
            this.textBox_Gehalt.Size = new System.Drawing.Size(100, 20);
            this.textBox_Gehalt.TabIndex = 18;
            // 
            // textBox_Gebuehren
            // 
            this.textBox_Gebuehren.Location = new System.Drawing.Point(244, 102);
            this.textBox_Gebuehren.Name = "textBox_Gebuehren";
            this.textBox_Gebuehren.Size = new System.Drawing.Size(100, 20);
            this.textBox_Gebuehren.TabIndex = 17;
            // 
            // radioButton_Mitarbeiter
            // 
            this.radioButton_Mitarbeiter.AutoSize = true;
            this.radioButton_Mitarbeiter.Location = new System.Drawing.Point(37, 26);
            this.radioButton_Mitarbeiter.Name = "radioButton_Mitarbeiter";
            this.radioButton_Mitarbeiter.Size = new System.Drawing.Size(74, 17);
            this.radioButton_Mitarbeiter.TabIndex = 14;
            this.radioButton_Mitarbeiter.TabStop = true;
            this.radioButton_Mitarbeiter.Text = "Mitarbeiter";
            this.radioButton_Mitarbeiter.UseVisualStyleBackColor = true;
            this.radioButton_Mitarbeiter.CheckedChanged += new System.EventHandler(this.radioButton_Mitarbeiter_CheckedChanged);
            // 
            // radioButton_Kunde
            // 
            this.radioButton_Kunde.AutoSize = true;
            this.radioButton_Kunde.Location = new System.Drawing.Point(37, 3);
            this.radioButton_Kunde.Name = "radioButton_Kunde";
            this.radioButton_Kunde.Size = new System.Drawing.Size(56, 17);
            this.radioButton_Kunde.TabIndex = 15;
            this.radioButton_Kunde.TabStop = true;
            this.radioButton_Kunde.Text = "Kunde";
            this.radioButton_Kunde.UseVisualStyleBackColor = true;
            this.radioButton_Kunde.CheckedChanged += new System.EventHandler(this.radioButton_Kunde_CheckedChanged);
            // 
            // listBox_Ausgabe
            // 
            this.listBox_Ausgabe.FormattingEnabled = true;
            this.listBox_Ausgabe.Location = new System.Drawing.Point(530, 64);
            this.listBox_Ausgabe.Name = "listBox_Ausgabe";
            this.listBox_Ausgabe.Size = new System.Drawing.Size(253, 407);
            this.listBox_Ausgabe.TabIndex = 12;
            this.listBox_Ausgabe.SelectedIndexChanged += new System.EventHandler(this.listBox_Ausgabe_SelectedIndexChanged);
            // 
            // button_Speichern
            // 
            this.button_Speichern.Location = new System.Drawing.Point(499, 480);
            this.button_Speichern.Name = "button_Speichern";
            this.button_Speichern.Size = new System.Drawing.Size(75, 23);
            this.button_Speichern.TabIndex = 10;
            this.button_Speichern.Text = "Speichern";
            this.button_Speichern.UseVisualStyleBackColor = true;
            this.button_Speichern.Click += new System.EventHandler(this.button_Speichern_Click);
            // 
            // button_Laden
            // 
            this.button_Laden.Location = new System.Drawing.Point(625, 481);
            this.button_Laden.Name = "button_Laden";
            this.button_Laden.Size = new System.Drawing.Size(75, 23);
            this.button_Laden.TabIndex = 13;
            this.button_Laden.Text = "Laden";
            this.button_Laden.UseVisualStyleBackColor = true;
            this.button_Laden.Click += new System.EventHandler(this.button_Laden_Click);
            // 
            // label_boxMitarbeiter
            // 
            this.label_boxMitarbeiter.AutoSize = true;
            this.label_boxMitarbeiter.BackColor = System.Drawing.Color.Transparent;
            this.label_boxMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boxMitarbeiter.Location = new System.Drawing.Point(530, 27);
            this.label_boxMitarbeiter.Margin = new System.Windows.Forms.Padding(0);
            this.label_boxMitarbeiter.Name = "label_boxMitarbeiter";
            this.label_boxMitarbeiter.Size = new System.Drawing.Size(182, 25);
            this.label_boxMitarbeiter.TabIndex = 14;
            this.label_boxMitarbeiter.Text = "Liste der Mitarbeiter";
            this.label_boxMitarbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(530, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 31);
            this.panel2.TabIndex = 15;
            // 
            // Kundenverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(795, 558);
            this.Controls.Add(this.label_boxMitarbeiter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Laden);
            this.Controls.Add(this.button_Speichern);
            this.Controls.Add(this.listBox_Ausgabe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kundenverwaltung";
            this.Text = "Kundenverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Vorname;
        private System.Windows.Forms.TextBox textBox_Nachname;
        private System.Windows.Forms.TextBox textBox_Geburtsdatum;
        private System.Windows.Forms.Label label_Vorname;
        private System.Windows.Forms.Label label_Nachname;
        private System.Windows.Forms.Label label_Geburtsdatum;
        private System.Windows.Forms.Button button_Löschen;
        private System.Windows.Forms.Button button_Ändern;
        private System.Windows.Forms.Button button_Übernehmen;
        private System.Windows.Forms.Button button_Abbrechen;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_Ausgabe;
        private System.Windows.Forms.Button button_Speichern;
        private System.Windows.Forms.SaveFileDialog saveFileList;
        private System.Windows.Forms.OpenFileDialog openFileList;
        private System.Windows.Forms.Button button_Laden;
        private System.Windows.Forms.RadioButton radioButton_Mitarbeiter;
        private System.Windows.Forms.RadioButton radioButton_Kunde;
        private System.Windows.Forms.Label label_Mitarbeiternummer;
        private System.Windows.Forms.Label label_Gehalt;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Gebuehren;
        private System.Windows.Forms.Label label_BMI;
        private System.Windows.Forms.Label label_Kundennummer;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_Kundennummer;
        private System.Windows.Forms.TextBox textBox_BMI;
        private System.Windows.Forms.TextBox textBox_Mitarbeiternummer;
        private System.Windows.Forms.TextBox textBox_Gehalt;
        private System.Windows.Forms.TextBox textBox_Gebuehren;
        private System.Windows.Forms.Label label_boxMitarbeiter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
    }
}

