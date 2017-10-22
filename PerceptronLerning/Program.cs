using System;

namespace PerceptronLerning
{
    class Program
    {
        static void Main(string[] args)
        {
           var textReader = new LogicalDataTextFileReader();
           var input = textReader.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\testData.txt");
            var dictionaryInput = new LetterDataTextFileReader();
            var letterInput = dictionaryInput.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterLearningData.txt");

            var univeralNeuron = new UniversalNeuron(letterInput,0.5);
             univeralNeuron.PerceptronLearning();
            var oneLayerNetworkTest = new OneLayerNetwork(letterInput, 3);

    //        var neuron = new Neuron(input,2,0.1);
       //     neuron.PerceptronLearning();
      
            Console.ReadKey();
        }
    }
}
