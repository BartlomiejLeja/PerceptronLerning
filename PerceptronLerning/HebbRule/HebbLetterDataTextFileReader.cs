using System;
using System.IO;
using System.Text;

namespace PerceptronLerning.HebbRule
{
    class HebbLetterDataTextFileReader
    {
        private double[][] testLetterArray;
        string[] values;
        double[] testArray;
        int countOfLetterArray = 35;
        public double[][] ConverTextForTestDataArray(string path)
        {
            testLetterArray = new double[20][];
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(' ');
                testArray = new double[countOfLetterArray];
                for (int j = 0; j < countOfLetterArray; j++)
                {
                    testArray[j] = Convert.ToDouble(values[j]);
                }
                testLetterArray[i] = testArray;
            }
            return testLetterArray;
        }
    }
}
