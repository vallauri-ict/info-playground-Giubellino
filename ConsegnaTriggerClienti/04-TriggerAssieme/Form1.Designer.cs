namespace _04_TriggerAssieme
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
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoAggiornamenti = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRicaricaTabelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.AllowUserToAddRows = false;
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(15, 30);
            this.dgvClienti.MultiSelect = false;
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.RowHeadersVisible = false;
            this.dgvClienti.Size = new System.Drawing.Size(443, 150);
            this.dgvClienti.TabIndex = 0;
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(504, 30);
            this.dgvStoricoCancellazioni.MultiSelect = false;
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(586, 150);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoAggiornamenti
            // 
            this.dgvStoricoAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamenti.Location = new System.Drawing.Point(504, 240);
            this.dgvStoricoAggiornamenti.MultiSelect = false;
            this.dgvStoricoAggiornamenti.Name = "dgvStoricoAggiornamenti";
            this.dgvStoricoAggiornamenti.Size = new System.Drawing.Size(586, 150);
            this.dgvStoricoAggiornamenti.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 47);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Aggiorna i dati della riga selezionata";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(358, 186);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(100, 44);
            this.btnElimina.TabIndex = 4;
            this.btnElimina.Text = "Elimina riga selezionata";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tabella Clienti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Storico Cancellazioni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Storico Aggiornameni";
            // 
            // btnRicaricaTabelle
            // 
            this.btnRicaricaTabelle.Location = new System.Drawing.Point(182, 308);
            this.btnRicaricaTabelle.Name = "btnRicaricaTabelle";
            this.btnRicaricaTabelle.Size = new System.Drawing.Size(100, 44);
            this.btnRicaricaTabelle.TabIndex = 8;
            this.btnRicaricaTabelle.Text = "Ricarica Tabelle";
            this.btnRicaricaTabelle.UseVisualStyleBackColor = true;
            this.btnRicaricaTabelle.Click += new System.EventHandler(this.btnRicaricaTabelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 429);
            this.Controls.Add(this.btnRicaricaTabelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStoricoAggiornamenti);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvClienti);
            this.Name = "Form1";
            this.Text = "Prova Trigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamenti;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRicaricaTabelle;
    }
}