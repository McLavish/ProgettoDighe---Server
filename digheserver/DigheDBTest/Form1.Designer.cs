namespace DigheDBTest
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
            this.components = new System.ComponentModel.Container();
            this.gbxOperatori = new System.Windows.Forms.GroupBox();
            this.gbxInserimentoOperatori = new System.Windows.Forms.GroupBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgwOperatori = new System.Windows.Forms.DataGridView();
            this.routerPort = new System.IO.Ports.SerialPort(this.components);
            this.gbxOperatori.SuspendLayout();
            this.gbxInserimentoOperatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOperatori)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOperatori
            // 
            this.gbxOperatori.Controls.Add(this.gbxInserimentoOperatori);
            this.gbxOperatori.Controls.Add(this.dgwOperatori);
            this.gbxOperatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOperatori.Location = new System.Drawing.Point(21, 12);
            this.gbxOperatori.Name = "gbxOperatori";
            this.gbxOperatori.Size = new System.Drawing.Size(673, 426);
            this.gbxOperatori.TabIndex = 0;
            this.gbxOperatori.TabStop = false;
            this.gbxOperatori.Text = "Inserimento nuovi operatori";
            // 
            // gbxInserimentoOperatori
            // 
            this.gbxInserimentoOperatori.Controls.Add(this.btnInserisci);
            this.gbxInserimentoOperatori.Controls.Add(this.label3);
            this.gbxInserimentoOperatori.Controls.Add(this.label2);
            this.gbxInserimentoOperatori.Controls.Add(this.label1);
            this.gbxInserimentoOperatori.Controls.Add(this.dtpDataNascita);
            this.gbxInserimentoOperatori.Controls.Add(this.txtCognome);
            this.gbxInserimentoOperatori.Controls.Add(this.txtNome);
            this.gbxInserimentoOperatori.Location = new System.Drawing.Point(442, 41);
            this.gbxInserimentoOperatori.Name = "gbxInserimentoOperatori";
            this.gbxInserimentoOperatori.Size = new System.Drawing.Size(225, 287);
            this.gbxInserimentoOperatori.TabIndex = 4;
            this.gbxInserimentoOperatori.TabStop = false;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(53, 227);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(122, 33);
            this.btnInserisci.TabIndex = 8;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data di Nascita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascita.Location = new System.Drawing.Point(22, 191);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(177, 20);
            this.dtpDataNascita.TabIndex = 4;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(19, 115);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(177, 26);
            this.txtCognome.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 26);
            this.txtNome.TabIndex = 1;
            // 
            // dgwOperatori
            // 
            this.dgwOperatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOperatori.Location = new System.Drawing.Point(26, 25);
            this.dgwOperatori.Name = "dgwOperatori";
            this.dgwOperatori.Size = new System.Drawing.Size(410, 320);
            this.dgwOperatori.TabIndex = 0;
            // 
            // routerPort
            // 
            this.routerPort.BaudRate = 115200;
            this.routerPort.PortName = "COM7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxOperatori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxOperatori.ResumeLayout(false);
            this.gbxInserimentoOperatori.ResumeLayout(false);
            this.gbxInserimentoOperatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOperatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperatori;
        private System.Windows.Forms.DataGridView dgwOperatori;
        private System.Windows.Forms.GroupBox gbxInserimentoOperatori;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserisci;
        private System.IO.Ports.SerialPort routerPort;
    }
}

