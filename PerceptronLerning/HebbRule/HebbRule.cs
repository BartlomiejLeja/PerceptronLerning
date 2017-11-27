using System;
using System.Linq;

namespace PerceptronLerning.HebbRule
{
    class HebbRule
    {
        private double[] _weight { get; set; }
        private double a;
        private double s;
        private double c = 0.1;
        private double [] cap;
        private double gamma = 0.1;

        void adjustWeight(double [] input)
        {
            for(int i=0;i<input.Length;i++)
            {
                s +=  _weight[i]* input[i];
            }
            a = (s > 0) ? 1 : -1;
            cap = new double[_weight.Length];
            for(int i=0;i< _weight.Length;i++)
            {
                cap[i] = (c * a) * input[i];
            }
            for (int i = 0; i < _weight.Length; i++)
            {
                _weight[i] = _weight[i]/**(1-gamma)*/ + cap[i];
             //   Console.Write($"{Math.Round(_weight[i], 2)} ");
            }
            s = 0;
            a = 0;
           // Console.WriteLine();
        }

        public void adjustWeights(double [][] input, int timeOfLerning)
        {
            drawWeight();
            string textForOutput = String.Empty;
            for (int i =0; i<timeOfLerning;i++)
            {
                for(int j =0;j<20;j++)
                {
                    adjustWeight(input[j]);
                
                }
                //Console.WriteLine(textForOutput);
                //textForOutput = String.Empty;
            }

        }

       public void test(double [] testInput)
        {
            double testResult=0;
            for (int i = 0; i < testInput.Length; i++)
            {
                 testResult +=  (testInput[i] * _weight[i]);
            }
            Console.WriteLine($"{testResult}");
            testResult = (testResult > 0) ? 1 : -1;
            Console.WriteLine($"{testResult}");
        }

        private void drawWeight()
        {
            _weight = new double[35];
            var randomNumber = new Random();
            for (int i = 0; i < 35; i++)
                _weight[i] = randomNumber.NextDouble() ;
        }
    }
}
