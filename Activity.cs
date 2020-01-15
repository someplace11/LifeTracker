using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeTracker
{
    class Activity
    {
        private object date;
        private string activity;
        private double hours;
        private string note;

        public Activity(object date, string activity, string hours, string note)
        {
            Date = date;
            Activities = activity;
            Hours = ConvertHours(hours);
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

        public string Activities
        {
            get { return activity; }
            set
            {
                activity = value;
            }
        }

        public double Hours
        {
            get { return hours; }
            set
            {
                hours = ConvertHours(value.ToString());
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

        public static double ConvertHours(string hoursInput)
        {
            double checkHours;
            bool tryCheckHours = double.TryParse(hoursInput, out checkHours);

            if (!tryCheckHours)
            {
                MessageBox.Show("Invalid hour input");
            }

            return checkHours;
        }
    }
}
