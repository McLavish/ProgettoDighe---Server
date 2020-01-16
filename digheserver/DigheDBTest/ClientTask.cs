using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigheDBTest
{
    class ClientTask
    {
        private RouterGSM router;
        private DateTime lastAlert;
        private DataGridView gridMisurazioni;
        private DataGridView gridAllarmi;

        public ClientTask(RouterGSM router, DataGridView gridMisurazioni, DataGridView gridAllarmi)
        {
            this.router = router;
            this.gridMisurazioni = gridMisurazioni;
            this.gridAllarmi = gridAllarmi;
        }

        public void Start()
        {
            var timer = new System.Timers.Timer();
            timer.Interval = 1 * 1000;//30 * 60 * 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            List<string> messages = router.ReadMessages().Split('\n').ToList();

            List<Message> messaggiLetti = new List<Message>();

            messages.ForEach(new Action<string>((line) =>
            {
                Message message = Message.Parse(line);

                messaggiLetti.Add(message);
            }));

            router.DeleteAll(messaggiLetti);

            foreach (Message message in messaggiLetti)
            {
                Misurazione misurazione = new Misurazione(message.Number, Convert.ToInt32(message.Text), message.Date);
                Diga diga = new Diga(message.Number);
                diga.LoadData();
                misurazione.Insert();
                gridMisurazioni.Rows.Add(diga.Nome, misurazione.misurazione, misurazione.Data);
                if (misurazione.misurazione > diga.LivelloArancio || misurazione.misurazione > diga.LivelloRosso)
                {
                    Allarme allarme = new Allarme(misurazione.IDMisurazione, misurazione.misurazione > diga.LivelloRosso);
                    allarme.Insert();
                    gridAllarmi.Rows.Add(diga.Nome, misurazione.misurazione, misurazione.Data, misurazione.misurazione > diga.LivelloRosso);
                    lastAlert = DateTime.Now;
                    if (misurazione.misurazione > diga.LivelloRosso) // IF allarme rosso
                    {
                        ((System.Timers.Timer)sender).Interval = 10 * 60 * 1000;
                    } else // SE allarme arancione
                    {
                        ((System.Timers.Timer)sender).Interval = 15 * 60 * 1000;
                    }
                }
                if (lastAlert != null && (DateTime.Now - lastAlert).TotalMinutes > 45) // Se sono passati 45 minuti dall'ultimo allarme
                {
                    ((System.Timers.Timer)sender).Interval = 30 * 60 * 1000;
                }
            }

            //if ((lastRead - DateTime.Now).TotalMinutes > 60)
            //{
            //    // BOH
            //}
        }
    }
}
