namespace DigheDBTest
{
    partial class Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegisterShow = new System.Windows.Forms.Button();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.groupReg = new System.Windows.Forms.GroupBox();
            this.dataNascita = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsernameReg = new System.Windows.Forms.TextBox();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupLog.SuspendLayout();
            this.groupReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "admin";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(177, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnRegisterShow
            // 
            this.btnRegisterShow.BackColor = System.Drawing.Color.White;
            this.btnRegisterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterShow.Location = new System.Drawing.Point(84, 89);
            this.btnRegisterShow.Name = "btnRegisterShow";
            this.btnRegisterShow.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterShow.TabIndex = 5;
            this.btnRegisterShow.Text = "Register";
            this.btnRegisterShow.UseVisualStyleBackColor = false;
            this.btnRegisterShow.Click += new System.EventHandler(this.BtnRegisterShow_Click);
            // 
            // groupLog
            // 
            this.groupLog.Controls.Add(this.label1);
            this.groupLog.Controls.Add(this.btnRegisterShow);
            this.groupLog.Controls.Add(this.txtUsername);
            this.groupLog.Controls.Add(this.btnLogin);
            this.groupLog.Controls.Add(this.txtPassword);
            this.groupLog.Controls.Add(this.label2);
            this.groupLog.Location = new System.Drawing.Point(223, 101);
            this.groupLog.Name = "groupLog";
            this.groupLog.Size = new System.Drawing.Size(305, 134);
            this.groupLog.TabIndex = 6;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "groupBox1";
            // 
            // groupReg
            // 
            this.groupReg.Controls.Add(this.dataNascita);
            this.groupReg.Controls.Add(this.label7);
            this.groupReg.Controls.Add(this.label6);
            this.groupReg.Controls.Add(this.txtCognome);
            this.groupReg.Controls.Add(this.label5);
            this.groupReg.Controls.Add(this.txtNome);
            this.groupReg.Controls.Add(this.label3);
            this.groupReg.Controls.Add(this.btnRegister);
            this.groupReg.Controls.Add(this.txtUsernameReg);
            this.groupReg.Controls.Add(this.txtPasswordReg);
            this.groupReg.Controls.Add(this.label4);
            this.groupReg.Location = new System.Drawing.Point(195, 42);
            this.groupReg.Name = "groupReg";
            this.groupReg.Size = new System.Drawing.Size(358, 265);
            this.groupReg.TabIndex = 7;
            this.groupReg.TabStop = false;
            this.groupReg.Text = "groupBox2";
            this.groupReg.Visible = false;
            // 
            // dataNascita
            // 
            this.dataNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascita.Location = new System.Drawing.Point(95, 193);
            this.dataNascita.Name = "dataNascita";
            this.dataNascita.Size = new System.Drawing.Size(237, 20);
            this.dataNascita.TabIndex = 18;
            this.dataNascita.Value = new System.DateTime(1965, 2, 9, 10, 10, 10, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data nascita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(95, 152);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(166, 20);
            this.txtCognome.TabIndex = 14;
            this.txtCognome.Text = "Lino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 20);
            this.txtNome.TabIndex = 12;
            this.txtNome.Text = "Topo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(128, 236);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_click);
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.Location = new System.Drawing.Point(95, 35);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(166, 20);
            this.txtUsernameReg.TabIndex = 6;
            this.txtUsernameReg.Text = "admin";
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Location = new System.Drawing.Point(95, 72);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.Size = new System.Drawing.Size(166, 20);
            this.txtPasswordReg.TabIndex = 8;
            this.txtPasswordReg.Text = "admin";
            this.txtPasswordReg.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupReg);
            this.Controls.Add(this.groupLog);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupLog.ResumeLayout(false);
            this.groupLog.PerformLayout();
            this.groupReg.ResumeLayout(false);
            this.groupReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegisterShow;
        private System.Windows.Forms.GroupBox groupLog;
        private System.Windows.Forms.GroupBox groupReg;
        private System.Windows.Forms.DateTimePicker dataNascita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUsernameReg;
        private System.Windows.Forms.TextBox txtPasswordReg;
        private System.Windows.Forms.Label label4;
    }
}