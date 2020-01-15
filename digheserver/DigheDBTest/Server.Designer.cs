namespace DigheDBTest
{
    partial class Server
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
            this.components = new System.ComponentModel.Container();
            this.routerPort = new System.IO.Ports.SerialPort(this.components);
            this.gridMisurazioni = new System.Windows.Forms.DataGridView();
            this.digaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misurazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridAllarmi = new System.Windows.Forms.DataGridView();
            this.DigaName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misurazione2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rosso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.gridDighe = new System.Windows.Forms.DataGridView();
            this.IDDiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Citta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivelloArancio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivelloRosso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMisurazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllarmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDighe)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMisurazioni
            // 
            this.gridMisurazioni.AllowUserToAddRows = false;
            this.gridMisurazioni.AllowUserToDeleteRows = false;
            this.gridMisurazioni.AllowUserToResizeRows = false;
            this.gridMisurazioni.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridMisurazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMisurazioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.digaName,
            this.Misurazione,
            this.Data});
            this.gridMisurazioni.Location = new System.Drawing.Point(12, 259);
            this.gridMisurazioni.Name = "gridMisurazioni";
            this.gridMisurazioni.ReadOnly = true;
            this.gridMisurazioni.RowHeadersVisible = false;
            this.gridMisurazioni.Size = new System.Drawing.Size(305, 150);
            this.gridMisurazioni.TabIndex = 0;
            // 
            // digaName
            // 
            this.digaName.HeaderText = "Nome Diga";
            this.digaName.Name = "digaName";
            this.digaName.ReadOnly = true;
            // 
            // Misurazione
            // 
            this.Misurazione.HeaderText = "Misurazione";
            this.Misurazione.Name = "Misurazione";
            this.Misurazione.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Misurazioni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Allarmi";
            // 
            // gridAllarmi
            // 
            this.gridAllarmi.AllowUserToAddRows = false;
            this.gridAllarmi.AllowUserToDeleteRows = false;
            this.gridAllarmi.AllowUserToResizeRows = false;
            this.gridAllarmi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridAllarmi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllarmi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DigaName2,
            this.Misurazione2,
            this.Data2,
            this.Rosso});
            this.gridAllarmi.Location = new System.Drawing.Point(420, 259);
            this.gridAllarmi.Name = "gridAllarmi";
            this.gridAllarmi.ReadOnly = true;
            this.gridAllarmi.RowHeadersVisible = false;
            this.gridAllarmi.Size = new System.Drawing.Size(403, 150);
            this.gridAllarmi.TabIndex = 2;
            // 
            // DigaName2
            // 
            this.DigaName2.HeaderText = "Nome diga";
            this.DigaName2.Name = "DigaName2";
            this.DigaName2.ReadOnly = true;
            // 
            // Misurazione2
            // 
            this.Misurazione2.HeaderText = "Misurazione";
            this.Misurazione2.Name = "Misurazione2";
            this.Misurazione2.ReadOnly = true;
            // 
            // Data2
            // 
            this.Data2.HeaderText = "Data";
            this.Data2.Name = "Data2";
            this.Data2.ReadOnly = true;
            // 
            // Rosso
            // 
            this.Rosso.HeaderText = "Allarme rosso";
            this.Rosso.Name = "Rosso";
            this.Rosso.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista dighe";
            // 
            // gridDighe
            // 
            this.gridDighe.AllowUserToAddRows = false;
            this.gridDighe.AllowUserToDeleteRows = false;
            this.gridDighe.AllowUserToResizeRows = false;
            this.gridDighe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridDighe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDighe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDiga,
            this.Nome,
            this.Citta,
            this.LivelloArancio,
            this.LivelloRosso});
            this.gridDighe.Location = new System.Drawing.Point(12, 45);
            this.gridDighe.Name = "gridDighe";
            this.gridDighe.RowHeadersVisible = false;
            this.gridDighe.Size = new System.Drawing.Size(503, 150);
            this.gridDighe.TabIndex = 4;
            // 
            // IDDiga
            // 
            this.IDDiga.HeaderText = "Numero";
            this.IDDiga.Name = "IDDiga";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Citta
            // 
            this.Citta.HeaderText = "Città";
            this.Citta.Name = "Citta";
            this.Citta.ReadOnly = true;
            // 
            // LivelloArancio
            // 
            this.LivelloArancio.HeaderText = "Livello Arancio";
            this.LivelloArancio.Name = "LivelloArancio";
            this.LivelloArancio.ReadOnly = true;
            // 
            // LivelloRosso
            // 
            this.LivelloRosso.HeaderText = "Livello Rosso";
            this.LivelloRosso.Name = "LivelloRosso";
            this.LivelloRosso.ReadOnly = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridDighe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridAllarmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMisurazioni);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMisurazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllarmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDighe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort routerPort;
        private System.Windows.Forms.DataGridView gridMisurazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridAllarmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridDighe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citta;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivelloArancio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivelloRosso;
        private System.Windows.Forms.DataGridViewTextBoxColumn digaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misurazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn DigaName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misurazione2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rosso;
    }
}