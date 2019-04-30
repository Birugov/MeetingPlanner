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
    public partial class ChoosingDesktopForm : Form
    {
        public ChoosingDesktopForm()
        {
            InitializeComponent();
        }

        private void AdminButton(object sender, EventArgs e)
        {
            this.Hide();
            var adminForm = new AdminForm();
            adminForm.Closed += (s, args) => this.Close();
            adminForm.Show();
        }

        private void UserButton(object sender, EventArgs e)
        {
            this.Hide();
            var userForm = new UserForm();
            userForm.Closed += (s, args) => this.Close();
            userForm.Show();
            this.Hide();
        }
    }
}
