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

                usersList.Add(user);
                MessageBox.Show(FindIntersections(usersList).ToString());
            }
            
        }

        private DateTime FindIntersections(List<User> usersList)
        {
            var year = new int[365][];

            foreach (var user in usersList)
            {
                var i = 0;
                foreach (var interval in user.TimeIntervals)
                {
                    year[interval.Item1.DayOfYear] = new int[24];
                    for (int j = 0; j < interval.Item2.Length; j++)
                    {
                        year[interval.Item1.DayOfYear][interval.Item2[j]]++;
                    }
                    i++;
                }
            }

            var bestDay = 0;
            var bestTime = 0;
            for (var m = 0; m < year.Length; m++)
            {
                var max = 0;
                if (year[m] != null)
                {
                    for (var k = 0; k < year[m].Length; k++)
                    {
                        if (year[m][k] > max)
                        {
                            bestTime = k;
                            bestDay = m;
                            max = year[m][k];
                        }

                    }
                }
            }

            return MakeDateTime(bestDay, bestTime);
        }

        private DateTime MakeDateTime(int Day, int Hour)
        {
            var day = 0;
            var month = 0;
            int i = 1;
            while (Day>29)
            {
                if (i == 1)
                    Day -= 31;
                if (i == 2)
                    Day -= 28;
                if (i == 3)
                    Day -= 31;
                if (i == 4)
                    Day -= 30;
                if (i == 5)
                    Day -= 31;
                if (i == 6)
                    Day -= 30;
                if (i == 7)
                    Day -= 31;
                if (i == 8)
                    Day -= 31;
                if (i == 9)
                    Day -= 30;
                if (i == 10)
                    Day -= 31;
                if (i == 11)
                    Day -= 30;
                if (i == 12)
                    Day -= 31;
                i++;
            }
            day = Day;
            month = i;
                return new DateTime(2019, month, day, Hour, 00, 00);
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
