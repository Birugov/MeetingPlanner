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
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form3 form3;
        public Form1()
        {
            
            InitializeComponent();
            form2 = new Form2(this) { Visible = false }; 
            form3= new Form3(this) { Visible = false };
            this.BackColor = Color.DeepPink;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AdminButton(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;
            form3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserButton(object sender, EventArgs e)
        {
            this.Visible = false;
            form3.Visible = true;
            form2.Visible = false;
        }
    }
}
