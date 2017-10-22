using System;
using System.Collections.Generic;

namespace PerceptronLerning
{
    class UniversalNeuron
    {
        private double _eta;
        private double _learningCoefficient;

        private double[] _weight { get; set; }
        private List<LetterData> _letterInput;
        private LetterDataTextFileReader dictionaryInput;
        int countOfletterArray = 35;
        int _letterIndex;
        char _letter;


        public UniversalNeuron(List<LetterData> letterInput, double learningCoefficien, int letterIndex, char letter )
        {
            _letterInput = letterInput;
            _learningCoefficient = learningCoefficien;
            dictionaryInput = new LetterDataTextFileReader();
            _letterIndex = letterIndex;
            _letter = letter;
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
                double y = 0;

                foreach (var letter in _letterInput)
                {
                    for (int j = 0; j < 35; j++)
                            y += letter.LetterPattern[j] * _weight[j];
     
                    if (letter.LetterResult[_letterIndex] != calculateValue(y))
                    {
                        error = letter.LetterResult[_letterIndex] - calculateValue(y);
                      
                            for (int k = 0; k < 35; k++)
                                _weight[ k] = _weight[ k] + _learningCoefficient * error * letter.LetterPattern[ k];

                        _eta = _eta - error;
                        errorCount++;
                    }
                }
                if (errorCount == 0)
                {
                    Console.WriteLine($"Number of needed iterations is {i + 1}");
                    
                        for (int k = 0; k < 35; k++)
                            Console.WriteLine($"Weight {k} = {_weight[k]}");
                    Console.WriteLine($"Eta = {_eta}");
                    break;
                }
            }
            testMethod(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterTestData.txt");
        }

        private double calculateValue(double sum)
        {
            return (sum > _eta) ? 1 : 0;
        }

        private void drawWeight()
        {
            _weight = new double[countOfletterArray];
            var randomNumber = new Random();
            for (int i = 0; i < 35; i++)
                    _weight[i] = -10 + randomNumber.NextDouble() * 20;

            for (int i = 0; i < 35; i++)
                    Console.WriteLine($"Weight {i} = {_weight[i]}");
        }

        private void testMethod(string path)
        {
            double result = 0;
            List<double[]> testLetter = dictionaryInput.ConverTextForTestDataArray(path);
            for (int i = 0; i < testLetter.Count; i++)
            {
                    for (int k = 0; k < 35; k++)
                        result += testLetter[i][k] * _weight[ k];

                Console.WriteLine($"Is this letter {_letter} = {calculateValue(result)}");
            }

        }
    }
}
