using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        public string UserName;
        public List<Tuple<DateTime, int[]>> TimeIntervals;

        public User()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(UserName + "\n");
            foreach (var item in TimeIntervals)
                sb.Append(item.ToString());
            return sb.ToString();
            //Интовый массив в любом случае не получается нормально вывести -> System.int[]
        }

        //Страшная ненужная хуйня, которую пока что жалко удалять
        #region
        /*
        public User(string userName, List<Tuple<DateTime, int[]>> timeIntervals)
        {
            UserName = userName;
            TimeIntervals = timeIntervals;
        }

        public User(string userName, DateTime dateTime, int[] timeArrays)
        {
            UserName = userName;
            TimeIntervals.Add(new Tuple<DateTime, int[]> (dateTime, timeArrays));
        }
        */

        /*
        public void ConcatDateTimes() //Объединяет все одинаковые DateTime в один и высчитывает массив пересечения в этот день
        {
            var tempTimeIntervals = new List<Tuple<DateTime, int[]>>();

            var addedDateTimes = new List<DateTime>();

            foreach (var timeInterval in TimeIntervals)
            {
                //if (!timeInterval.Item1.ToShortTimeString().Contains(addedDateTimes.ToString()))
                    
            }
        }

        private int[] FindCommonElemsInArrays(params List<int>[] elems)
        //FindCommonElemsInArrays(new List<int>() { 1, 2, 3 }, new List<int>() { 2, 3, 4 });
        {

            return new int[] { 0 };
        }
        */
        #endregion
    }
}
