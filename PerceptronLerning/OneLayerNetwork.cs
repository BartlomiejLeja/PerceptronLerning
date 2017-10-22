using System.Collections.Generic;

namespace PerceptronLerning
{
    class OneLayerNetwork
    {
        private List<UniversalNeuron> NeuronLayer;
        
        public OneLayerNetwork(List<LetterData> letterInput,double learningCoefficien)
        {
            char[] letters ={'A', 'B' ,'C','D','E','F','G','H','I','J','a','b','c','d','e','f','g','h','i','j'};
            NeuronLayer = new List<UniversalNeuron>();
            for (int i = 0; i < letterInput.Count; i++)
            {
                NeuronLayer.Add(new UniversalNeuron(letterInput, learningCoefficien, i,letters[i]));
            }
            CreateOneLayerNetwork();
        }

        private void CreateOneLayerNetwork()
        {
            foreach (var universalNeuron in NeuronLayer)
            {
                universalNeuron.PerceptronLearning();
            }
        }
    }
}
