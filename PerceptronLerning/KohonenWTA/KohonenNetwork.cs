using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronLerning.KohonenWTA
{
   
    class KohonenNetwork
    {
        public WTAKohonenNeuron [] neuronsArray = new WTAKohonenNeuron[3];
        double N;
        double Size;

        public KohonenNetwork(double n, int size)
        {
            Size = size;
            N = n;

            var neuron = new WTAKohonenNeuron();
           neuronsArray[0] = neuron;
            var neuron1 = new WTAKohonenNeuron();
            neuronsArray[1] = neuron1;
            var neuron2 = new WTAKohonenNeuron();
           neuronsArray[2] = neuron2;
        }

       public void learnNetwork()
        {
            int index_max = 0;
            double max = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    for (int k = 0; k < Size; k++)
                    {
                        var output = neuronsArray[k].calculateValue(j);
                        if (output > max)
                        {
                            max = output;
                            index_max = k;
                        }
                    }
                    neuronsArray[index_max].adjustWeights(j, i);
                    index_max = 0;
                    max = 0;
                }
            }
        }

        public void testNetwork(double[] tab,int s)
        {
            int index_max = 0;
            double max = 0;

            double[] output = new double[3];

            for (int i = 0; i < Size; i++)
            {
              
                for (int j = 0; j < 4; j++)
                {
                    output[i] += neuronsArray[i].weights[j] * tab[j];
                }
                if (output[i] > max)
                {
                    max = output[i];
                    index_max = i;
                }
              
            }

            for (int i = 0; i < Size; i++)
            {
                if (i == index_max)
                {
                    output[i] = 1;
                }
                else
                {
                    output[i] = 0;
                }
                Console.WriteLine($"{i + 1} {output[i]}" );
            }
        }


    }
}
