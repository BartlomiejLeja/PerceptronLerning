using PerceptronLerning.HebbRule;
using PerceptronLerning.KohonenMaps;
using PerceptronLerning.KohonenWTA;
using System;

namespace PerceptronLerning
{
    class Program
    {
        static void Main(string[] args)
        {
            // var dictionaryInput = new LetterDataTextFileReader();
            // //var letterInput = dictionaryInput.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterLearningData.txt");

            // var floatLetterInput = dictionaryInput.ConvertTextForFloatArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterLearningData.txt");
            // //var test = new LogicalDataTextFileReader();
            // //var input =test.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\testData.txt");
            // //var test1 = new Neuron(input,15,0.1);
            // //test1.PerceptronLearning();

            // //var oneLayerNetworkTest = new OneLayerNetwork(letterInput,0.5);

            // var net = new BackpropagationNeuralNetwork(new int[] { 35, 35, 35, 20 }); //intiilize network 3 input (0 0 0) 2 hidden layers with 25 neurons 1 output (1)

            //Itterate 5000 times and train each possible output
            //5000*8 = 40000 traning operations
            //for (int i = 0; i < 5000; i++)
            //{
            //    for (int j = 0; j < floatLetterInput.Count; j++)
            //    {
            //        net.FeedForward(floatLetterInput[j].LetterPattern);
            //        net.BackProp(floatLetterInput[j].LetterResult);
            //    }

            //}


            //net.TestMethod(new float[] { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 }, 'A');
            //net.TestMethod(new float[] { 1, 1, 1, 1, 0, 1, 0 ,0, 0, 1, 1, 0, 0 ,0 ,1, 1 ,1 ,1 ,1 ,0, 1 ,0, 0 ,0 ,1 ,1 ,0 ,0, 0, 1, 1, 1, 1, 1, 0 }, 'B');


            //var test = new HebbRuleHandler();
            //test.HebbRuleShower();

           KohonenMap KohonenMap = new KohonenMap(35, 5, @"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\kohonenMapLearningData.txt");

            //KohoenWtaHandler test = new KohoenWtaHandler();

            //test.run();

            Console.ReadKey();
        }
    }
}
