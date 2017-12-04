using System;


namespace PerceptronLerning.KohonenWTA
{
    public class WTAKohonenNeuron
    {
        KohonenFlowersDataFileReader reader = new KohonenFlowersDataFileReader();
        public double[][] inputs;
        private int inputSize = 4;
       public double[] weights;
     //  public double output;
     

        public WTAKohonenNeuron()
        {
            inputs = reader.ConverTextForTestDataArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\KohonenWTAData.txt");
            weights = new double[4];
            drawWeights();
        }

        private void drawWeights()
        {
            var randomNumber = new Random();
            double sum = 0;
            for (int i = 0; i < inputSize; i++)
            {
                
                weights[i] =  randomNumber.NextDouble() ;
                sum += Math.Pow(weights[i], 2);
            }
            for (int i = 0; i < inputSize; i++)
            {
                weights[i] = weights[i] / Math.Sqrt(sum);
            }
        }

        public void adjustWeights(int index, int it)
        {
            for (int i = 0; i < 4; i++)
            {
                weights[i] = weights[i] + LearningRate(it) * (inputs[index][i] - weights[i]);
            }
        }

        private double LearningRate(int it)
        {
            return Math.Exp(-it / 1000) * 0.1;
        }

        public double calculateValue(int index)
        {
           double  output = 0;

            for (int i = 0; i < inputSize; i++)
            {
                output += weights[i] * inputs[index][i];
            }
            return output;
        }
    }
}
