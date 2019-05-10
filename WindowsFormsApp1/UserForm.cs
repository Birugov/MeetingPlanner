using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {
        public static DateTime CalendarDate;
        public static List<String> TimeArray = new List<string>();
        public static string userLine = string.Empty;

        public UserForm()
        {
            InitializeComponent();
            //var userInfo = new Info();

        }

        private void SendDataBtn(object sender, EventArgs e)
        {

            //MessageBox.Show("Данные скопированы в буффер обмена");

            var sb = new StringBuilder();
            foreach (var Time in TimeArray)
                sb.Append(Time + "\n");

            MessageBox.Show(sb.ToString());

            userLine.Insert(0, userNameTextBox.Text + "_");
            MessageBox.Show(userLine.ToString());

            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalendarDate = dateTimePicker.Value;
            MessageBox.Show(CalendarDate.ToShortDateString());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            userLine += string.Format("{4}/{0}:{1}-{2}:{3}", fromHoursTimePicker.Text, fromMinutesTimePicker.Text,
                toHoursTimePicker.Text, toMinutesTimePicker.Text, CalendarDate.ToShortDateString());
            TimeArray.Add(string.Format("{4}/{0}:{1}-{2}:{3}", fromHoursTimePicker.Text, fromMinutesTimePicker.Text,
                toHoursTimePicker.Text, toMinutesTimePicker.Text, CalendarDate.ToShortDateString()));

            fromHoursTimePicker.Text = String.Empty;
            fromMinutesTimePicker.Text = String.Empty;
            toHoursTimePicker.Text = String.Empty;
            toMinutesTimePicker.Text = String.Empty;
        }
    }
}