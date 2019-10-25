namespace RegisztracioAlkalmazas
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
            this.nev = new System.Windows.Forms.Label();
            this.szulDatum = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.kedvencHobbi = new System.Windows.Forms.Label();
            this.ujHobbi = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxSzulDatum = new System.Windows.Forms.TextBox();
            this.textBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.radioButtonFerfi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(14, 31);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 0;
            this.nev.Text = "Név:";
            this.nev.Click += new System.EventHandler(this.label1_Click);
            // 
            // szulDatum
            // 
            this.szulDatum.AutoSize = true;
            this.szulDatum.Location = new System.Drawing.Point(12, 67);
            this.szulDatum.Name = "szulDatum";
            this.szulDatum.Size = new System.Drawing.Size(65, 13);
            this.szulDatum.TabIndex = 1;
            this.szulDatum.Text = "Szül. dátum:";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Location = new System.Drawing.Point(12, 103);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(32, 13);
            this.nem.TabIndex = 2;
            this.nem.Text = "Nem:";
            // 
            // kedvencHobbi
            // 
            this.kedvencHobbi.AutoSize = true;
            this.kedvencHobbi.Location = new System.Drawing.Point(236, 28);
            this.kedvencHobbi.Name = "kedvencHobbi";
            this.kedvencHobbi.Size = new System.Drawing.Size(82, 13);
            this.kedvencHobbi.TabIndex = 3;
            this.kedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // ujHobbi
            // 
            this.ujHobbi.AutoSize = true;
            this.ujHobbi.Location = new System.Drawing.Point(183, 170);
            this.ujHobbi.Name = "ujHobbi";
            this.ujHobbi.Size = new System.Drawing.Size(49, 13);
            this.ujHobbi.TabIndex = 4;
            this.ujHobbi.Text = "Új hobbi:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(80, 28);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(85, 20);
            this.textBoxNev.TabIndex = 5;
            // 
            // textBoxSzulDatum
            // 
            this.textBoxSzulDatum.Location = new System.Drawing.Point(80, 64);
            this.textBoxSzulDatum.Name = "textBoxSzulDatum";
            this.textBoxSzulDatum.Size = new System.Drawing.Size(85, 20);
            this.textBoxSzulDatum.TabIndex = 6;
            // 
            // textBoxUjHobbi
            // 
            this.textBoxUjHobbi.Location = new System.Drawing.Point(239, 170);
            this.textBoxUjHobbi.Name = "textBoxUjHobbi";
            this.textBoxUjHobbi.Size = new System.Drawing.Size(87, 20);
            this.textBoxUjHobbi.TabIndex = 7;
            // 
            // radioButtonFerfi
            // 
            this.radioButtonFerfi.AutoSize = true;
            this.radioButtonFerfi.Location = new System.Drawing.Point(80, 99);
            this.radioButtonFerfi.Name = "radioButtonFerfi";
            this.radioButtonFerfi.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFerfi.TabIndex = 9;
            this.radioButtonFerfi.TabStop = true;
            this.radioButtonFerfi.Text = "Férfi";
            this.radioButtonFerfi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(80, 126);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 10;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Nő";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(250, 196);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 11;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(184, 234);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 12;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(265, 234);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltes.TabIndex = 13;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.listBoxHobbik.Location = new System.Drawing.Point(239, 48);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(86, 108);
            this.listBoxHobbik.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 269);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonFerfi);
            this.Controls.Add(this.textBoxUjHobbi);
            this.Controls.Add(this.textBoxSzulDatum);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.ujHobbi);
            this.Controls.Add(this.kedvencHobbi);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.szulDatum);
            this.Controls.Add(this.nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szulDatum;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.Label kedvencHobbi;
        private System.Windows.Forms.Label ujHobbi;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxSzulDatum;
        private System.Windows.Forms.TextBox textBoxUjHobbi;
        private System.Windows.Forms.RadioButton radioButtonFerfi;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.ListBox listBoxHobbik;
    }
}

