using System;

namespace PerceptronLerning
{
    public class Neuron
    {
        private double _eta;
        private double _learningCoefficient;

        private double [] _weight { get; set; }
        private double[,] _input;
        private  int _countOfInputs;
        
        public Neuron(double[,] input, int countOfInputs,double learningCoefficien)
        {
            _input = input;
            _countOfInputs = countOfInputs;
            _learningCoefficient = learningCoefficien;
        }

        public void PerceptronLearning()
        {
            drawWeight();
            var errorCount = 0;
            double error = 0;
            var iterationCount = 2000;
            for (int i=0; i< iterationCount;i++)
            {
                errorCount = 0;

                for(int j =0;j< _input.Length/3;j++)
                {
                    var y = _input[j,0] * _weight[0] + _input[j,1] * _weight[1];
                    if (_input[j,2] != calculateValue(y))
                    {
                        error = _input[j, 2] - calculateValue(y);
                        _weight[0] = _weight[0] + _learningCoefficient * error * _input[j,0];
                        _weight[1] = _weight[1] + _learningCoefficient * error * _input[j,1];
                        _eta = _eta - error;
                        errorCount++;
                    }
                }
                if(errorCount==0)
                {
                    Console.WriteLine($"Number of needed iterations is {i + 1}");
                    Console.WriteLine($"Weight 0 = {_weight[0]} Weight 1 = {_weight[1]}");
                    Console.WriteLine($"Eta = {_eta}");
                    break;
                }
            }

            testMethod(0, 0);
            testMethod(0, 1);
            testMethod(1, 0);
            testMethod(1, 1);
        }

        private void testMethod(int p, int q)
        {
            var result = p * _weight[0] + q * _weight[1];
            Console.WriteLine($"{p} ^ {q} = {calculateValue(result)}");
        }

        private double calculateValue(double sum)
        {
            return (sum > _eta) ? 1 : 0;
        }

        private void drawWeight()
        {
            _weight = new double [2];
            var randomNumber = new Random();
            for (int i=0; i< 2; i++)
                _weight[i] = -10 + randomNumber.NextDouble() * 20;
            
            Console.WriteLine($"Weight 0 = {_weight[0]} Weight 1 = {_weight[1]}");
        }
    }
}
