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
    public partial class Form1 : Form
    {
        private const string CONNECTION_STRING = @"Server=(local); Initial Catalog = Dighe; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Message.Parse(@"+CMGL: 35,""REC UNREAD"","" + 393347220441"",,""19 / 12 / 19, 09:50:11 + 04""Jtitirduit"));
            //RouterGSM router = new RouterGSM(routerPort);
            //router.Open();
            //new ClientTask("123", router).Start();
        }

        private void LoadData()
        {

        }
    }
}
