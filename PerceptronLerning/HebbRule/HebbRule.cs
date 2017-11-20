﻿using System;

namespace PerceptronLerning.HebbRule
{
    class HebbRule
    {
        private double[] _weight { get; set; }
        private double a;
        private double s;
        private double c = 1;

        void adjustWeight(double [] input)
        {
            for(int i=0;i<input.Length;i++)
            {
                s += input[i] * _weight[i];
            }
            a = (a > 0) ? 1 : 0;
            for(int i=0;i< _weight.Length;i++)
            {
                _weight[i] = _weight[i] + (c * a) * input[i];
            }
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
                foreach (var w in _weight)
                {
                    textForOutput += $"{(int)w} ";
                }
                Console.WriteLine(textForOutput);
                textForOutput = String.Empty;
            }

        }

       public void test(double [] testInput)
        {
            double testResult=0;
            for (int i = 0; i < testInput.Length; i++)
            {
                 testResult += testInput[i] * _weight[i]; 
            }
            testResult = (testResult > 0) ? 1 : 0;
            Console.WriteLine($"{testResult}");
        }

        private void drawWeight()
        {
            _weight = new double[35];
            var randomNumber = new Random();
            for (int i = 0; i < 35; i++)
                _weight[i] = -10 + randomNumber.NextDouble() * 20;
        }
    }
}
