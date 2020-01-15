using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LifeTracker
{
    public partial class formLifeTracker : Form
    {
        public formLifeTracker()
        {
            InitializeComponent();
        }

        int count = 0;
        string nameCount;

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:/E-Documents/C#/LifeTracker/Tracker.accdb");

        private void BtnSubmitActivity_Click(object sender, EventArgs e)
        {
            NameCount(count);
            Activity nameCount = new Activity(inputDate.Value, inputActivity.Text, inputHours.Text, inputActivityNote.Text);
            // MessageBox.Show(nameCount.Date.ToString() + "\n" +nameCount.Activities + "\n" + nameCount.Hours.ToString() + "\n" + nameCount.Note);
            try
            {
                OleDbCommand cmd = con.CreateCommand();

                con.Open();

                // cmd.CommandText = "INSERT INTO T_ACTIVITY ( DateOf, Activity, Hours, Note ) VALUES ('" + inputDate.Value + "','" + inputActivity.Text + "','" + inputHours.Text + "','" + inputActivityNote.Text + "')";
                cmd.CommandText = "INSERT INTO T_ACTIVITY ( DateOf, Activity, Hours, ActNote ) VALUES('" + nameCount.Date + "','" + nameCount.Activities + "','" + nameCount.Hours + "','" + nameCount.Note + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Submitted");

                con.Close();
            }
            catch (Exception newEx)
            {
                MessageBox.Show(newEx.Message);
            }

            inputActivity.Text = "";
            inputHours.Text = "";
            inputActivityNote.Text = "";
        }

        private void BtnSubmitHealth_Click(object sender, EventArgs e)
        {
            NameCount(count);
            Health nameCount = new Health(inputDate.Value, inputCalories.Text, inputWeight.Text);

            try
            {
                OleDbCommand cmd = con.CreateCommand();

                con.Open();

                cmd.CommandText = "INSERT INTO T_HEALTH ( DateOf, Calories, Weight ) VALUES('" + nameCount.Date + "','" + nameCount.Calories + "','" + nameCount.Weight + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Submitted");

                con.Close();
            }
            catch (Exception newEx)
            {
                MessageBox.Show(newEx.Message);
            }

            inputCalories.Text = "";
            inputWeight.Text = "";
        }

        private void BtnSubmitMoney_Click(object sender, EventArgs e)
        {
            NameCount(count);
            Money nameCount = new Money(inputDate.Value, inputMoneySpent.Text, inputMoneyNote.Text);

            try
            {
                OleDbCommand cmd = con.CreateCommand();

                con.Open();

                cmd.CommandText = "INSERT INTO T_MONEY ( DateOf, MoneySpent, MonNote ) VALUES('" + nameCount.Date + "','" + nameCount.MoneySpent + "','" + nameCount.Note + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Submitted");

                con.Close();

                inputMoneySpent.Text = "";
                inputMoneyNote.Text = "";
            }
            catch (Exception newEx)
            {
                MessageBox.Show(newEx.Message);
            }
        }

        public void NameCount(int count)
        {
            nameCount = count.ToString();
            count++;
        }
    }
}
