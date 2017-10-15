using System;

namespace PerceptronLerning
{
    class Program
    {
        static void Main(string[] args)
        {
           var textReader = new TextFileReader();
           var input = textReader.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\testData.txt");

            var neuron = new Neuron(input,2);
            neuron.PerceptronLearning();
      
            Console.ReadKey();
        }
    }
}
