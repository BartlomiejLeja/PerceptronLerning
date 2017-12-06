using System;
namespace PerceptronLerning
{
    class NeuronHandler
    {
        public void run()
        {
            var reader = new LogicalDataTextFileReader();
            var input = reader.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\testData.txt");
            var neuronTest = new Neuron(input,15,0.1);
            neuronTest.PerceptronLearning();
        }
    }
}
