using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PerceptronLerning.KohonenMaps
{
    class KohonenMapLetterDataTextFileReader
    {
        string[] values;
        double[] testArray;
        public void ConverTextForTestDataArray(string path, List<double[]> patterns, List<string> labels  )
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(' ');
                testArray = new double[values.Length-1];
                labels.Add(values[0]);
                for (int j = 0; j < testArray.Length; j++)
                {
                    testArray[j] = Convert.ToDouble(values[j+1]);
                }
                patterns.Add(testArray);
            }
        }
    }
}
