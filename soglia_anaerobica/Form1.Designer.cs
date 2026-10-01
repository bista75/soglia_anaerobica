namespace soglia_anaerobica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_n1 = new System.Windows.Forms.Button();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_eta = new System.Windows.Forms.TextBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(12, 65);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(150, 41);
            this.btn_n1.TabIndex = 0;
            this.btn_n1.Text = "Calcola soglia anaerobica";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(9, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(67, 13);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Inserisci l\'età";
            // 
            // txt_eta
            // 
            this.txt_eta.Location = new System.Drawing.Point(12, 25);
            this.txt_eta.Name = "txt_eta";
            this.txt_eta.Size = new System.Drawing.Size(100, 20);
            this.txt_eta.TabIndex = 2;
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(12, 109);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(92, 13);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Soglia anaerobica";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(12, 132);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(48, 13);
            this.lbl_n3.TabIndex = 4;
            this.lbl_n3.Text = "Risultato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 301);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.txt_eta);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_eta;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
    }
}

