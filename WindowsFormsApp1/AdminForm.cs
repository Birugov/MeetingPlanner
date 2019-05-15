using System;
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

            var usersList = new List<User>();
            
            var userLines = File.ReadAllLines(filePath);
            //Пример строки: 
            //Никита_15.05.2019/8:00-10:00|15.05.2019/14:00-15:00|15.05.2019/18:00-19:00|15.05.2019/5:00-13:00|
            //TODO: Добавить Exeption при вводе имени на русском
            foreach (var userLine in userLines)
            {
                var user = new User();
                user.TimeIntervals = new List<Tuple<DateTime, int[]>>();

                var tempUserLine = new StringBuilder();
                tempUserLine.Append(userLine);
                user.UserName = userLine.Split('_')[0];
                tempUserLine = tempUserLine.Remove(0, user.UserName.Length + 1); //Удаление имени из строки
                tempUserLine.Remove(tempUserLine.Length - 1, 1); //Удаление "||" в конце строки

                var timeIntervals = tempUserLine.ToString().Split('|');
                foreach (var timeInterval in timeIntervals)
                {
                    //Примерно так выглядит timeInterval на данном этапе
                    //15.05.2019/8:00-10:00

                    user.TimeIntervals.Add(new Tuple<DateTime, int[]>(Convert.ToDateTime(timeInterval.Split('/')[0]), 
                        CreateArrayFromTimeInterval(timeInterval.Split('/')[1])));
                }

                MessageBox.Show(user.ToString());
                usersList.Add(user);
            }
            
        }

        private int[] CreateArrayFromTimeInterval(string timeInterval)
        {
            /*
                Создание массива по промежутку времени в виде строки
                Например, Строка вида "8:00-10:00" превратится в массив []
            */
            var hoursIntervals = timeInterval.Split('-');
            int hourFrom = Convert.ToInt32(hoursIntervals[0].Split(':')[0]); //Тупо забейте
            int hourTo = Convert.ToInt32(hoursIntervals[1].Split(':')[0]);
            var arr = new int[hourTo - hourFrom];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = hourFrom + i;
            return arr;
        }
    }
}
