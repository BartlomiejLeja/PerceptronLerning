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
        double[,] resultArray;
        int test = 0;
        string[] values;
        public List<LetterData> ConvertTextForArray(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            letterList = new List<LetterData>();
            resultArray = new double[7, 5];
            
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    resultArray[test, j] = Convert.ToDouble(values[j]);
                }
                if (values.Length == 6)
                {
                    double[,] tempArray = new double[7, 5];
                    for (int j = 0; j < 7; j++)
                        for (int k = 0; k < 5; k++)
                            tempArray[j, k] = resultArray[j, k];
                    
                    letterList.Add(new LetterData(tempArray, Convert.ToDouble(values[5])));
                    test = 0;  
                }
                else
                test++;
            }
            return letterList;
        }
    }
}
