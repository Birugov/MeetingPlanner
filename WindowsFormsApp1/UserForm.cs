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
        public UserForm()
        {
            InitializeComponent();
        }

        private void SendDataBtn(object sender, EventArgs e)
        {
            MessageBox.Show("Данные скопированы в буффер обмена");
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var day = dateTimePicker.Value.Day;
            var month = dateTimePicker.Value.Month;
            MessageBox.Show(day + " " + month);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
