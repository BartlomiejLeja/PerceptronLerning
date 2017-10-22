using System;
using System.Collections.Generic;

namespace PerceptronLerning
{
    class OneLayerNetwork
    {
        private List<UniversalNeuron> NeuronLayer;
        private string _path;
        
        public OneLayerNetwork(List<LetterData> letterInput, int numerOfNeurons)
        {
            NeuronLayer = new List<UniversalNeuron>();
            for(int i=0;i<numerOfNeurons;i++)
            {
                NeuronLayer.Add(new UniversalNeuron(letterInput, 0.5));
            }
            CreateOneLayerNetwork();
        }

        private void CreateOneLayerNetwork()
        {
            foreach(var universalNeuron in NeuronLayer)
            {
                universalNeuron.PerceptronLearning();
            }
        }
    }
}
