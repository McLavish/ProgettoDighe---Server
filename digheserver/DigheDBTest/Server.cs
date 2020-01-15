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
    public partial class Server : Form
    {
        private RouterGSM router;
        private string username;

        public Server(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            router = new RouterGSM(routerPort);
            router.Open();
            SendLevels();
            ClientTask task = new ClientTask(router, gridMisurazioni, gridAllarmi);
            task.Start();
            MessageBox.Show("Il programma si è avviato correttamente, sei loggato come " + username);
        }

        private void SendLevels()
        {
            List<Diga> dighe = Diga.ElencoDighe();
            foreach (Diga diga in dighe)
            {
                router.SendMessage(diga.IDDiga, diga.LivelloArancio + "," + diga.LivelloRosso);
                gridDighe.Rows.Add(diga.IDDiga, diga.Nome, diga.Citta, diga.LivelloArancio, diga.LivelloRosso);
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
