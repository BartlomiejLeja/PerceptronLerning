using System;
using System.Collections.Generic;

namespace PerceptronLerning.KohonenMaps
{
    class KohonenMap
    {
        private KohonenNeuron[,] outputs;  // Collection of weights.
        private int iteration;      // Current iteration.
        private int length;        // Side length of output grid.
        private int dimensions;    // Number of input dimensions.
        private Random rnd = new Random();
        private List<string> labels = new List<string>();
        private List<double[]> patterns = new List<double[]>();
        private KohonenMapLetterDataTextFileReader kohonenDataReader = new KohonenMapLetterDataTextFileReader();

        public KohonenMap(int dimensions, int length, string file)
        {
            this.length = length;
            this.dimensions = dimensions;
            Initialise();
            kohonenDataReader.ConverTextForTestDataArray(file, patterns, labels);
            NormalisePatterns();
            Train(0.0000001);
            DumpCoordinates();
        }
        private void Initialise()
        {
            outputs = new KohonenNeuron[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    outputs[i, j] = new KohonenNeuron(i, j, length);
                    outputs[i, j].Weights = new double[dimensions];
                    for (int k = 0; k < dimensions; k++)
                    {
                        outputs[i, j].Weights[k] = rnd.NextDouble();
                    }
                }
            }
        }

        private void NormalisePatterns()
        {
            for (int j = 0; j < dimensions; j++)
            {
                double sum = 0;
                for (int i = 0; i < patterns.Count; i++)
                {
                    sum += patterns[i][j];
                }
                double average = sum / patterns.Count;
                for (int i = 0; i < patterns.Count; i++)
                {
                    patterns[i][j] = patterns[i][j] / average;
                }
            }
        }
        private void Train(double maxError)
        {
            double currentError = double.MaxValue;
            while (currentError > maxError)
            {
                currentError = 0;
                List<double[]> TrainingSet = new List<double[]>();
                foreach (double[] pattern in patterns)
                {
                    TrainingSet.Add(pattern);
                }
                for (int i = 0; i < patterns.Count; i++)
                {
                    double[] pattern = TrainingSet[rnd.Next(patterns.Count - i)];
                    currentError += TrainPattern(pattern);
                    TrainingSet.Remove(pattern);
                }
                Console.WriteLine(currentError.ToString("0.0000000"));
            }
        }
        private double TrainPattern(double[] pattern)
        {
            double error = 0;
            KohonenNeuron winner = Winner(pattern);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    error += outputs[i, j].UpdateWeights(pattern, winner, iteration);
                }
            }
            iteration++;
            return Math.Abs(error / (length * length));
        }
        private void DumpCoordinates()
        {
            for (int i = 0; i < patterns.Count; i++)
            {
                KohonenNeuron n = Winner(patterns[i]);
                Console.WriteLine($"{ labels[i]}, { n.X}, { n.Y}");
            }
        }
        
        private KohonenNeuron Winner(double[] pattern)
        {
        KohonenNeuron winner = null;
        double min = double.MaxValue;
        for (int i = 0; i < length; i++)
            for (int j = 0; j < length; j++)
            {
                double d = Distance(pattern, outputs[i, j].Weights);
                if (d < min)
                {
                    min = d;
                    winner = outputs[i, j];
                }
            }
        return winner;
        }
        private double Distance(double[] vector1, double[] vector2)
         {
        double value = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            value += Math.Pow((vector1[i] - vector2[i]), 2);
        }
        return Math.Sqrt(value);
        }

    }
}

