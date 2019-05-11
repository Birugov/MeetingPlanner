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
        public static string userLine = string.Empty;

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
            userLine += string.Format("{4}/{0}:{1}-{2}:{3}||", fromHoursTimePicker.Value, fromMinutesTimePicker.Value,
                toHoursTimePicker.Value, toHoursTimePicker.Value, dateTimePicker.Value.ToShortDateString());

            fromHoursTimePicker.Value = 0;
            fromMinutesTimePicker.Value = 0;
            toHoursTimePicker.Value = 0;
            toMinutesTimePicker.Value = 0;
        }
    }
}