using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class RouterGSM
    {
        private SerialPort SerialPort;

        public RouterGSM(SerialPort SerialPort)
        {
            this.SerialPort = SerialPort;
        }

        public void Open()
        {

            SerialPort.Open();
        }

        public string ReadMessages()
        {
            lock (SerialPort)
            {
                SerialPort.WriteLine(@"AT+CMGF=1" + (char)13);
                //Thread.Sleep(1000);
                //SerialPort.ReadExisting();
                SerialPort.WriteLine(@"AT+CMGL=""rec unread""" + (char)13);// ""REC READ""" + (char)13);//=""REC UNREAD""" + (char)13);
                // SerialPort.ReadTimeout = 10000;
                Thread.Sleep(1000); // Serve???
                return SerialPort.ReadExisting();
                // Parsare il messaggio, se l'indice è 35 eliminare il 1° messaggio
            }
        }

        public void SendMessage(string number, string text)
        {
            lock (SerialPort)
            {
                SerialPort.WriteLine($"AT+CMGS={number.Trim().Replace(" ", String.Empty).Replace("-", String.Empty)}\r");

                //se non lo metto esplode perchè è troppo veloce
                Thread.Sleep(500);

                //char 26 = ctrl + z
                SerialPort.WriteLine(text + (char)26);
            }
        }

        public void DeleteAll(List<Message> listaMessaggi)
        {
            lock (SerialPort)
            {
                foreach (Message message in listaMessaggi)
                    SerialPort.WriteLine($"AT+CMGD={message.MessageID}\r");
            }
        }
    }
}
