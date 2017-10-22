using System;
using System.Collections.Generic;

namespace PerceptronLerning
{
    class UniversalNeuron
    {
        private double _eta;
        private double _learningCoefficient;

        private double[,] _weight { get; set; }
        private List<LetterData> _letterInput;
        private LetterDataTextFileReader dictionaryInput; 


        public UniversalNeuron(List<LetterData> letterInput,  double learningCoefficien)
        {
             _letterInput = letterInput;
            _learningCoefficient = learningCoefficien;
            dictionaryInput = new LetterDataTextFileReader();
        }

        public void PerceptronLearning()
        {
            drawWeight();
            var errorCount = 0;
            double error = 0;
            var iterationCount = 2000;
            for (int i = 0; i < iterationCount; i++)
            {
                errorCount = 0;
                double y=0;

                foreach (var letter in _letterInput)
                {
                    for (int j = 0; j < 7; j++)
                        for (int k = 0; k < 5; k++)
                        {
                             y += letter.LetterPattern[j, k] * _weight[j, k];
                        }
                    
                    if (letter.LetterResult != calculateValue(y))
                    {
                        error = letter.LetterResult - calculateValue(y);
                        for (int j = 0; j < 7; j++)
                            for (int k = 0; k < 5; k++)
                                _weight[j, k] = _weight[j, k] + _learningCoefficient * error * letter.LetterPattern[j, k];
                      
                        _eta = _eta - error;
                        errorCount++;
                    }
                }
                if (errorCount == 0)
                {
                    Console.WriteLine($"Number of needed iterations is {i + 1}");
                    for (int j = 0; j < 7; j++)
                        for (int k = 0; k < 5; k++)
                            Console.WriteLine($"Weight {j},{k} = {_weight[j, k]}");
                    Console.WriteLine($"Eta = {_eta}");
                    break;
                }
            }
            testMethod(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterLearningData.txt");
        }

        private double calculateValue(double sum)
        {
            return (sum > _eta) ? 1 : 0;
        }

        private void drawWeight()
        {
            _weight = new double[7,5];
            var randomNumber = new Random();
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)
                    _weight[i,j] = -10 + randomNumber.NextDouble() * 20;

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)
                    Console.WriteLine($"Weight {i},{j} = {_weight[i, j]}");
        }

        private void testMethod(string path)
        {
            double result = 0;
            List<LetterData> testLetter = dictionaryInput.ConvertTextForArray(path);
            for (int i = 0; i < testLetter.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                    for (int k = 0; k < 5; k++)
                        result += testLetter[i].LetterPattern[j, k] * _weight[j, k];

                Console.WriteLine($"Is this leeter A = {calculateValue(result)}");
            }

        }
    }
}
