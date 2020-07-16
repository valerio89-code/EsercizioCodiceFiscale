namespace EsercizioCodiceFiscale
{
    partial class CodiceFiscale
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
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_Maschio = new System.Windows.Forms.RadioButton();
            this.rbtn_Femmina = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbx_comune = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.lbl_codice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(94, 45);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(213, 29);
            this.tbx_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 29);
            this.textBox1.TabIndex = 3;
            // 
            // dataDiNascita
            // 
            this.dataDiNascita.Location = new System.Drawing.Point(193, 127);
            this.dataDiNascita.Name = "dataDiNascita";
            this.dataDiNascita.Size = new System.Drawing.Size(324, 29);
            this.dataDiNascita.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data di nascita";
            // 
            // rbtn_Maschio
            // 
            this.rbtn_Maschio.AutoSize = true;
            this.rbtn_Maschio.Location = new System.Drawing.Point(109, 208);
            this.rbtn_Maschio.Name = "rbtn_Maschio";
            this.rbtn_Maschio.Size = new System.Drawing.Size(111, 29);
            this.rbtn_Maschio.TabIndex = 6;
            this.rbtn_Maschio.TabStop = true;
            this.rbtn_Maschio.Text = "Maschio";
            this.rbtn_Maschio.UseVisualStyleBackColor = true;
            // 
            // rbtn_Femmina
            // 
            this.rbtn_Femmina.AutoSize = true;
            this.rbtn_Femmina.Location = new System.Drawing.Point(235, 208);
            this.rbtn_Femmina.Name = "rbtn_Femmina";
            this.rbtn_Femmina.Size = new System.Drawing.Size(118, 29);
            this.rbtn_Femmina.TabIndex = 7;
            this.rbtn_Femmina.TabStop = true;
            this.rbtn_Femmina.Text = "Femmina";
            this.rbtn_Femmina.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sesso";
            // 
            // cmbx_comune
            // 
            this.cmbx_comune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_comune.FormattingEnabled = true;
            this.cmbx_comune.Items.AddRange(new object[] {
            "Assemini",
            "Cagliari",
            "Genova",
            "Iglesias",
            "Milano"});
            this.cmbx_comune.Location = new System.Drawing.Point(237, 282);
            this.cmbx_comune.Name = "cmbx_comune";
            this.cmbx_comune.Size = new System.Drawing.Size(280, 32);
            this.cmbx_comune.Sorted = true;
            this.cmbx_comune.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comune di nascita";
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(33, 416);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(255, 109);
            this.btn_calcola.TabIndex = 11;
            this.btn_calcola.Text = "Calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // lbl_codice
            // 
            this.lbl_codice.AutoSize = true;
            this.lbl_codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codice.Location = new System.Drawing.Point(446, 446);
            this.lbl_codice.Name = "lbl_codice";
            this.lbl_codice.Size = new System.Drawing.Size(221, 38);
            this.lbl_codice.TabIndex = 12;
            this.lbl_codice.Text = "Codice fiscale";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_codice);
            this.panel1.Controls.Add(this.btn_calcola);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbx_comune);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbtn_Femmina);
            this.panel1.Controls.Add(this.rbtn_Maschio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataDiNascita);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbx_nome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MinimumSize = new System.Drawing.Size(700, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 758);
            this.panel1.TabIndex = 13;
            // 
            // CodiceFiscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 782);
            this.Controls.Add(this.panel1);
            this.Name = "CodiceFiscale";
            this.Text = "Calcolo codice fiscale";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dataDiNascita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn_Maschio;
        private System.Windows.Forms.RadioButton rbtn_Femmina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbx_comune;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.Label lbl_codice;
        private System.Windows.Forms.Panel panel1;
    }
}

