using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeTracker
{
    class Health
    {
        private object date;
        private int calories;
        private double weight;

        public Health(object date, string calories, string weight)
        {
            Date = date;
            Calories = checkCalories(calories);
            Weight = checkWeight(weight);
        }

        public object Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }

        public int Calories
        {
            get { return calories; }
            set
            {
                calories = checkCalories(value.ToString());
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                weight = checkWeight(value.ToString());
            }
        }

        public static int checkCalories(string caloriesInput)
        {
            int checkCals;
            bool tryCheckCals = int.TryParse(caloriesInput, out checkCals);

            if (!tryCheckCals)
            {
                MessageBox.Show("Invalid calorie input");
            }

            return checkCals;
        }

        public static double checkWeight(string weightInput)
        {
            double checkWt;
            bool tryCheckWt = double.TryParse(weightInput, out checkWt);

            if (!tryCheckWt)
            {
                MessageBox.Show("Invalid weight input");
            }

            return checkWt;
        }
    }
}
