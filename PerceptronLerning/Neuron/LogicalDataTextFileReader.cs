using System;
using System.IO;
using System.Text;

namespace PerceptronLerning
{
    class LogicalDataTextFileReader
    {
        double[,] resultArray;
        public double[,] ConvertTextForArray(string path)
        {
          string[] lines = File.ReadAllLines(path, Encoding.UTF8);
          resultArray = new double[lines.Length, 3];

          for(int i=0; i< lines.Length;i++)
            {
                string[] values = lines[i].Split(' ');
                resultArray[i, 0] = Convert.ToDouble( values[0]);
                resultArray[i, 1] = Convert.ToDouble(values[1]);
                resultArray[i, 2] = Convert.ToDouble(values[2]);
            }
            return resultArray;
        }
    }
}
