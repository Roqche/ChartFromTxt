using System.Collections.Generic;
using System.IO;

namespace ChartLogic
{
    public class RowFromFileList
    {
        public static List<string> ReadFile()
        {
            List<string> Rows = new List<string>();
            string file_name = @"C:\Users\Bart\Downloads\PTFE.TXT";
            string[] lines = File.ReadAllLines(file_name);
            int row = 1;
            foreach (string line in lines)
            {
                row++;
                if (line.Trim().Equals("Measured values"))
                {
                    break;
                }
            }

            for (int i = row; i < lines.Length; i++)
            {
                Rows.Add(lines[i]);
            }

            return Rows;
        }
    }
}
