﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CalculateBtn(object sender, EventArgs e)
        {
            var filePath = filePathTextBox.Text;
            filePath = "data.txt";

            /*
            var userLines = File.ReadAllLines(filePath);
            foreach (var userLine in userLines)
            {
                
            }
            */

            MessageBox.Show("Оптимальное время встречи: Пятница с 17:30 до 18:00");
        }
    }
}
