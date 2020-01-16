using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class ClientTask
    {
        private string ClientNumber;
        private RouterGSM router;
        private DateTime lastRead;

        public ClientTask(string ClientNumber, RouterGSM router)
        {
            this.ClientNumber = ClientNumber;
            this.router = router;
        }

        public void Start()
        {
            //Task.Run(new Action(() =>
            //{
            Timer timer = new Timer(new TimerCallback((state) =>
            {
                string messages = router.ReadMessages();

                List<Message> messaggiletti = new List<Message>();

                messages.Split('\n').ToList().ForEach(new Action<string>((line) =>
                {
                    Message message = Message.Parse(line);

                    messaggiletti.Add(message);

                    //if (message.Number == ClientNumber)
                    //{
                    //    lastRead = DateTime.Now;
                    //    Console.WriteLine(message);
                    //}
                }));

                messaggiletti.Sort((msg1, msg2) => msg1.Date.CompareTo(msg2.Date));



                if ((lastRead - DateTime.Now).TotalMinutes > 60)
                {
                    // BOH
                }

                Console.WriteLine(messages);
            }), null, 0, 60000);
            // }));
        }
    }
}
