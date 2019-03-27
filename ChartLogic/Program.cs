using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Rows = RowFromFileList.ReadFile();
            List<Punkt> Punkty = new List<Punkt>();
            foreach (string row in Rows)
            {
                string[] cols = new string[4];
                cols = row.Split();
                Punkt punkt = new Punkt(Decimal.Parse(cols[0], CultureInfo.InvariantCulture), Decimal.Parse(cols[1], CultureInfo.InvariantCulture), Decimal.Parse(cols[2], CultureInfo.InvariantCulture));
                Punkty.Add(punkt);
            }
        }

        public static List<Punkt> Download()
        {
            List<string> Rows = RowFromFileList.ReadFile();
            List<Punkt> Punkty = new List<Punkt>();
            foreach (string row in Rows)
            {
                string[] cols = new string[4];
                cols = row.Split();
                Punkt punkt = new Punkt(Decimal.Parse(cols[0], CultureInfo.InvariantCulture), Decimal.Parse(cols[1], CultureInfo.InvariantCulture), Decimal.Parse(cols[2], CultureInfo.InvariantCulture));
                Punkty.Add(punkt);
            }
            return Punkty;
        }
    }
}
