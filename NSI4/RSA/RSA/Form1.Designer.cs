namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kPrywatnyLabel = new System.Windows.Forms.Label();
            this.kPublicznyLabel = new System.Windows.Forms.Label();
            this.GenKlucz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SzyfrujButton = new System.Windows.Forms.Button();
            this.DeszyfrujButton = new System.Windows.Forms.Button();
            this.zapiszklucz = new System.Windows.Forms.Button();
            this.WczytajKlucz = new System.Windows.Forms.Button();
            this.ZapiszKluczPubliczny = new System.Windows.Forms.Button();
            this.WczytajKluczPubliczny = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SzyfrowanyZapisz = new System.Windows.Forms.Button();
            this.wczytaj = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.MinimumSize = new System.Drawing.Size(340, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(340, 100);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(559, 37);
            this.textBox2.MinimumSize = new System.Drawing.Size(340, 100);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(340, 100);
            this.textBox2.TabIndex = 1;
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kPrywatnyLabel
            // 
            this.kPrywatnyLabel.AutoSize = true;
            this.kPrywatnyLabel.Location = new System.Drawing.Point(146, 9);
            this.kPrywatnyLabel.Name = "kPrywatnyLabel";
            this.kPrywatnyLabel.Size = new System.Drawing.Size(78, 13);
            this.kPrywatnyLabel.TabIndex = 2;
            this.kPrywatnyLabel.Text = "Klucz prywatny";
            this.kPrywatnyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // kPublicznyLabel
            // 
            this.kPublicznyLabel.AutoSize = true;
            this.kPublicznyLabel.Location = new System.Drawing.Point(658, 9);
            this.kPublicznyLabel.Name = "kPublicznyLabel";
            this.kPublicznyLabel.Size = new System.Drawing.Size(80, 13);
            this.kPublicznyLabel.TabIndex = 3;
            this.kPublicznyLabel.Text = "Klucz publiczny";
            this.kPublicznyLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GenKlucz
            // 
            this.GenKlucz.Location = new System.Drawing.Point(417, 37);
            this.GenKlucz.Name = "GenKlucz";
            this.GenKlucz.Size = new System.Drawing.Size(75, 23);
            this.GenKlucz.TabIndex = 4;
            this.GenKlucz.Text = "Generuj";
            this.GenKlucz.UseVisualStyleBackColor = true;
            this.GenKlucz.Click += new System.EventHandler(this.GenKlucz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekst jawny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tekst szyfrowany";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 292);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(340, 100);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(559, 292);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(340, 100);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SzyfrujButton
            // 
            this.SzyfrujButton.Location = new System.Drawing.Point(149, 414);
            this.SzyfrujButton.Name = "SzyfrujButton";
            this.SzyfrujButton.Size = new System.Drawing.Size(75, 23);
            this.SzyfrujButton.TabIndex = 9;
            this.SzyfrujButton.Text = "Szyfruj";
            this.SzyfrujButton.UseVisualStyleBackColor = true;
            this.SzyfrujButton.Click += new System.EventHandler(this.SzyfrujButton_Click);
            // 
            // DeszyfrujButton
            // 
            this.DeszyfrujButton.Location = new System.Drawing.Point(576, 414);
            this.DeszyfrujButton.Name = "DeszyfrujButton";
            this.DeszyfrujButton.Size = new System.Drawing.Size(75, 23);
            this.DeszyfrujButton.TabIndex = 10;
            this.DeszyfrujButton.Text = "Deszyfruj";
            this.DeszyfrujButton.UseVisualStyleBackColor = true;
            this.DeszyfrujButton.Click += new System.EventHandler(this.DeszyfrujButton_Click);
            // 
            // zapiszklucz
            // 
            this.zapiszklucz.Location = new System.Drawing.Point(60, 197);
            this.zapiszklucz.Name = "zapiszklucz";
            this.zapiszklucz.Size = new System.Drawing.Size(75, 23);
            this.zapiszklucz.TabIndex = 11;
            this.zapiszklucz.Text = "Zapisz";
            this.zapiszklucz.UseVisualStyleBackColor = true;
            this.zapiszklucz.Click += new System.EventHandler(this.zapiszklucz_Click);
            // 
            // WczytajKlucz
            // 
            this.WczytajKlucz.Location = new System.Drawing.Point(214, 197);
            this.WczytajKlucz.Name = "WczytajKlucz";
            this.WczytajKlucz.Size = new System.Drawing.Size(75, 23);
            this.WczytajKlucz.TabIndex = 12;
            this.WczytajKlucz.Text = "Wczytaj";
            this.WczytajKlucz.UseVisualStyleBackColor = true;
            this.WczytajKlucz.Click += new System.EventHandler(this.WczytajKlucz_Click);
            // 
            // ZapiszKluczPubliczny
            // 
            this.ZapiszKluczPubliczny.Location = new System.Drawing.Point(612, 197);
            this.ZapiszKluczPubliczny.Name = "ZapiszKluczPubliczny";
            this.ZapiszKluczPubliczny.Size = new System.Drawing.Size(75, 23);
            this.ZapiszKluczPubliczny.TabIndex = 13;
            this.ZapiszKluczPubliczny.Text = "Zapisz";
            this.ZapiszKluczPubliczny.UseVisualStyleBackColor = true;
            this.ZapiszKluczPubliczny.Click += new System.EventHandler(this.ZapiszKluczPubliczny_Click);
            // 
            // WczytajKluczPubliczny
            // 
            this.WczytajKluczPubliczny.Location = new System.Drawing.Point(776, 197);
            this.WczytajKluczPubliczny.Name = "WczytajKluczPubliczny";
            this.WczytajKluczPubliczny.Size = new System.Drawing.Size(75, 23);
            this.WczytajKluczPubliczny.TabIndex = 14;
            this.WczytajKluczPubliczny.Text = "Wczytaj";
            this.WczytajKluczPubliczny.UseVisualStyleBackColor = true;
            this.WczytajKluczPubliczny.Click += new System.EventHandler(this.WczytajKluczPubliczny_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SzyfrowanyZapisz
            // 
            this.SzyfrowanyZapisz.Location = new System.Drawing.Point(691, 414);
            this.SzyfrowanyZapisz.Name = "SzyfrowanyZapisz";
            this.SzyfrowanyZapisz.Size = new System.Drawing.Size(75, 23);
            this.SzyfrowanyZapisz.TabIndex = 16;
            this.SzyfrowanyZapisz.Text = "Zapisz";
            this.SzyfrowanyZapisz.UseVisualStyleBackColor = true;
            this.SzyfrowanyZapisz.Click += new System.EventHandler(this.SzyfrowanyZapisz_Click);
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(801, 414);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(75, 23);
            this.wczytaj.TabIndex = 17;
            this.wczytaj.Text = "Wczytaj";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(417, 113);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 18;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 574);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.wczytaj);
            this.Controls.Add(this.SzyfrowanyZapisz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WczytajKluczPubliczny);
            this.Controls.Add(this.ZapiszKluczPubliczny);
            this.Controls.Add(this.WczytajKlucz);
            this.Controls.Add(this.zapiszklucz);
            this.Controls.Add(this.DeszyfrujButton);
            this.Controls.Add(this.SzyfrujButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenKlucz);
            this.Controls.Add(this.kPublicznyLabel);
            this.Controls.Add(this.kPrywatnyLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label kPrywatnyLabel;
        private System.Windows.Forms.Label kPublicznyLabel;
        private System.Windows.Forms.Button GenKlucz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SzyfrujButton;
        private System.Windows.Forms.Button DeszyfrujButton;
        private System.Windows.Forms.Button zapiszklucz;
        private System.Windows.Forms.Button WczytajKlucz;
        private System.Windows.Forms.Button ZapiszKluczPubliczny;
        private System.Windows.Forms.Button WczytajKluczPubliczny;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SzyfrowanyZapisz;
        private System.Windows.Forms.Button wczytaj;
        private System.Windows.Forms.Button Reset;
    }
}

