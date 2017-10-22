using System;

namespace PerceptronLerning
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryInput = new LetterDataTextFileReader();
            var letterInput = dictionaryInput.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterLearningData.txt");

            var oneLayerNetworkTest = new OneLayerNetwork(letterInput,1);
           
            Console.ReadKey();
        }
    }
}
