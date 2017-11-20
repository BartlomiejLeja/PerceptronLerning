using System;

namespace PerceptronLerning
{
    class BackpropagationNeuralNetwork
    {
        int[] layer; //layer information
        Layer[] layers; //layers in the network

        /// <summary>
        /// Constructor setting up layers
        /// </summary>
        /// <param name="layer">Layers of this network</param>
        public BackpropagationNeuralNetwork(int[] layer)
        {
            //deep copy layers
            this.layer = new int[layer.Length];
            for (int i = 0; i < layer.Length; i++)
                this.layer[i] = layer[i];

            //creates neural layers
            layers = new Layer[layer.Length - 1];

            for (int i = 0; i < layers.Length; i++)
            {
                layers[i] = new Layer(layer[i], layer[i + 1]);
            }
        }

        /// <summary>
        /// High level feedforward for this network
        /// </summary>
        /// <param name="inputs">Inputs to be feed forwared</param>
        /// <returns></returns>
        public float[] FeedForward(float[] inputs)
        {
            //feed forward
            layers[0].FeedForward(inputs);
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].FeedForward(layers[i - 1].outputs);
            }

            return layers[layers.Length - 1].outputs; //return output of last layer
        }

        public void TestMethod(float[] inputs,char letter)
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            int index = 0;
            for(int i=0;i<letters.Length;i++)
            {
                if (letters[i] == letter) index = i;
            }
            var result =FeedForward(inputs);
            Console.WriteLine($"This is {letter} letter {result[index]}");
        }
        /// <summary>
        /// High level back porpagation
        /// Note: It is expexted the one feed forward was done before this back prop.
        /// </summary>
        /// <param name="expected">The expected output form the last feedforward</param>
        public void BackProp(float[] expected)
        {
            // run over all layers backwards
            for (int i = layers.Length - 1; i >= 0; i--)
            {
                if (i == layers.Length - 1)
                {
                    layers[i].BackPropOutput(expected); //back prop output
                }
                else
                {
                    layers[i].BackPropHidden(layers[i + 1].gamma, layers[i + 1].weights); //back prop hidden
                }
            }

            //Update weights
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].UpdateWeights();
            }
        }
    }
}
