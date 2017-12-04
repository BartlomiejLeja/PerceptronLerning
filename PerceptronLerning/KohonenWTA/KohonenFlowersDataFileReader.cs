using System;
using System.IO;
using System.Text;

namespace PerceptronLerning.KohonenWTA
{
    public class KohonenFlowersDataFileReader
    {
        private double[][] testFlowersArray;
        string[] values;
        double[] testArray;
        int countOfFlowersArray = 4;
        public double[][] ConverTextForTestDataArray(string path)
        {
            testFlowersArray = new double[150][];
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(' ');
                testArray = new double[countOfFlowersArray];
                for (int j = 0; j < countOfFlowersArray; j++)
                {
                    testArray[j] = Convert.ToDouble(values[j]);
                }
                testFlowersArray[i] = testArray;
            }
            return testFlowersArray;
        }
    }
}

