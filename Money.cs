using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeTracker
{
    class Money
    {
        private object date;
        private double moneySpent;
        private string note;

        public Money(object date, string moneySpent, string note)
        {
            Date = date;
            MoneySpent = checkMoneySpent(moneySpent);
            Note = note;
        }

        public object Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }

        public double MoneySpent
        {
            get { return moneySpent; }
            set
            {
                moneySpent = checkMoneySpent(value.ToString());
            }
        }

        public string Note
        {
            get { return note; }
            set
            {
                note = value;
            }
        }

        public static double checkMoneySpent(string moneyInput)
        {
            double checkMoney;
            bool tryCheckMoney = double.TryParse(moneyInput, out checkMoney);

            if (!tryCheckMoney)
            {
                MessageBox.Show("Invalid money input");
            }

            return checkMoney;
        }
    }
}
