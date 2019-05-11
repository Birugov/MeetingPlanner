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
        public static List<String> TimeArray = new List<string>();
        public static string userLine = "";

        #region
        public UserForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void SendDataBtn(object sender, EventArgs e)
        {
            userLine = userNameTextBox.Text + "_" + userLine;
            MessageBox.Show(userLine);

            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            userLine += string.Format("{4}/{0}:{1}-{2}:{3}||", fromHoursTimePicker.Text, fromMinutesTimePicker.Text,
                toHoursTimePicker.Text, toMinutesTimePicker.Text, dateTimePicker.Value.ToShortDateString());

            fromHoursTimePicker.Text = String.Empty;
            fromMinutesTimePicker.Text = String.Empty;
            toHoursTimePicker.Text = String.Empty;
            toMinutesTimePicker.Text = String.Empty;
        }
    }
}