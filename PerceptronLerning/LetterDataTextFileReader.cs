using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PerceptronLerning
{
    //TODO  Make it for static 
    class LetterDataTextFileReader
    {
        List<LetterData> letterList;
        List<double[]> testLetterList;

        double[] patternArray;
        double[] resultArray;
        double[] testArray;
        string[] values;
        
        int countOfLetterArray=35;

        public List<double []> ConverTextForTestDataArray(string path)
        {
            testLetterList = new List<double[]>();
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(' ');
                testArray = new double[countOfLetterArray];
                for (int j = 0; j < countOfLetterArray; j++)
                {
                    testArray[j] = Convert.ToDouble(values[j]);
                }
                testLetterList.Add(testArray);
            }
            return testLetterList;
        }


        public List<LetterData> ConvertTextForArray(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            letterList = new List<LetterData>();
            
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(' ');
               
                if (values.Length == 35)
                {
                    patternArray = new double[countOfLetterArray];
                    for (int j = 0; j < countOfLetterArray; j++)
                    {
                        patternArray[j] = Convert.ToDouble(values[j]);
                    }
                }
                else if (values.Length == 20)
                {
                    resultArray = new double[20];
                    for (int j = 0; j < 20; j++)
                    {
                        resultArray[j] = Convert.ToDouble(values[j]);
                    }
                    letterList.Add(new LetterData(patternArray, resultArray));
                }
            }
            return letterList;
        }
    }
}
