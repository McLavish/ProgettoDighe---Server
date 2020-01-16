namespace DigheDBTest
{
    partial class Dighe
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
            this.btnGbxInserisci = new System.Windows.Forms.Button();
            this.gbxInserimentoOperatori = new System.Windows.Forms.GroupBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgwOperatori = new System.Windows.Forms.DataGridView();
            this.gbxInserimentoOperatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOperatori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGbxInserisci
            // 
            this.btnGbxInserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGbxInserisci.Location = new System.Drawing.Point(80, 372);
            this.btnGbxInserisci.Name = "btnGbxInserisci";
            this.btnGbxInserisci.Size = new System.Drawing.Size(160, 32);
            this.btnGbxInserisci.TabIndex = 8;
            this.btnGbxInserisci.Text = "Inserisci Operatore";
            this.btnGbxInserisci.UseVisualStyleBackColor = true;
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
            this.gbxInserimentoOperatori.Location = new System.Drawing.Point(496, 62);
            this.gbxInserimentoOperatori.Name = "gbxInserimentoOperatori";
            this.gbxInserimentoOperatori.Size = new System.Drawing.Size(225, 287);
            this.gbxInserimentoOperatori.TabIndex = 7;
            this.gbxInserimentoOperatori.TabStop = false;
            this.gbxInserimentoOperatori.Visible = false;
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
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data di Nascita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
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
            this.txtCognome.Size = new System.Drawing.Size(177, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 20);
            this.txtNome.TabIndex = 1;
            // 
            // dgwOperatori
            // 
            this.dgwOperatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOperatori.Location = new System.Drawing.Point(80, 46);
            this.dgwOperatori.Name = "dgwOperatori";
            this.dgwOperatori.Size = new System.Drawing.Size(591, 320);
            this.dgwOperatori.TabIndex = 6;
            // 
            // Dighe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGbxInserisci);
            this.Controls.Add(this.gbxInserimentoOperatori);
            this.Controls.Add(this.dgwOperatori);
            this.Name = "Dighe";
            this.Text = "Dighe";
            this.gbxInserimentoOperatori.ResumeLayout(false);
            this.gbxInserimentoOperatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOperatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGbxInserisci;
        private System.Windows.Forms.GroupBox gbxInserimentoOperatori;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgwOperatori;
    }
}