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
    public partial class Form3 : Form
    {
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.BackColor = Color.LightPink;
        }

        private void UserCalendar(object sender, DateRangeEventArgs e)
        {
            
        }

        private void SendDataBtn(object sender, EventArgs e)
        {
            MessageBox.Show("Данные скопированы в буффер обмена");
        }
    }
}
