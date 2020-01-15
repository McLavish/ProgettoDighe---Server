using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigheDBTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Database.DatabaseInstance.CreateDatabaseIfNotExists();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Operatore operatore = new Operatore(txtUsername.Text);
            var result = operatore.Login(txtPassword.Text);
            if (result)
            {
                new Server(operatore.Username).Show();
                Hide();
                return;
            } else
            {
                MessageBox.Show("Username o password non validi");
            }
        }

        private void BtnRegisterShow_Click(object sender, EventArgs e)
        {
            groupLog.Hide();
            groupReg.Show();
        }

        private void btnRegister_click(object sender, EventArgs e)
        {
            Operatore operatore = new Operatore(txtUsernameReg.Text, txtNome.Text, txtCognome.Text, dataNascita.Value);
            var result = operatore.Register(txtPassword.Text);
            if (result)
            {
                MessageBox.Show("Ti sei registrato correttamente");
                new Server(operatore.Username).Show();
                Hide();
                return;
            }
            else
            {
                MessageBox.Show("Username già presente");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
