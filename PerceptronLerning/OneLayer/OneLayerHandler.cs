using System;
namespace PerceptronLerning.OneLayer
{
    public class OneLayerHandler
    {
        public void run()
        {
            var dictionaryInput = new LetterDataTextFileReader();
            var letterInput = dictionaryInput.ConvertTextForArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\letterLearningData.txt");
            var oneLayerNetworkTest = new OneLayerNetwork(letterInput, 0.5);
        }
    }
}
