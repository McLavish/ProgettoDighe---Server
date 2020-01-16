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
    }
}
