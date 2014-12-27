using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_Days
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getDaysBtn_Click(object sender, EventArgs e)
        {
            if (monthBox.Text.Length < 1)
                MessageBox.Show("Enter a month");
            else
            {
                int month = Convert.ToInt32(monthBox.Text);
                List<DateTime> days = GetDates(2013, month);
                foreach (var item in days)
                {
                    string day = item.Month.ToString() + "/" + item.Day.ToString() + " - " + item.DayOfWeek.ToString() + "\n";
                    daysBox.Text += day;
                }
            }
        }

        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             .Select(day => new DateTime(year, month, day))
                             .Where(dt => dt.DayOfWeek != DayOfWeek.Sunday &&
                                          dt.DayOfWeek != DayOfWeek.Saturday)
                             .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daysBox.Text = "";
        }
    }
}
