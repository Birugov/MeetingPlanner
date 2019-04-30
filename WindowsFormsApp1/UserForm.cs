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
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
