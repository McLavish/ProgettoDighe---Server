using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Message
    {
        public string Number;
        public DateTime Date;
        public string Text;

        public Message(string number, DateTime date, string text)
        {
            this.Number = number;
            this.Date = date;
            this.Text = text;
        }

        public static Message Parse(string text)
        {
            string number = text.Split(',')[2].Substring(1, 15).Trim();
            DateTime date = DateTime.Parse(text.Split(',')[4].Substring(1) + " " + text.Split(',')[5].Substring(1, 8));
            string message = text.Split(',')[5].Substring(15).Trim();
            return new Message(number, date, message);
        }

        public override string ToString()
        {
            return $"Number: {Number}, Date: {Date}, Text: {Text}";
        }
    }
}
