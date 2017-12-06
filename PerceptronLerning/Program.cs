using PerceptronLerning.BackPropagation;
using PerceptronLerning.HebbRule;
using PerceptronLerning.KohonenMaps;
using PerceptronLerning.KohonenWTA;
using PerceptronLerning.OneLayer;
using System;

namespace PerceptronLerning
{
    class Program
    {
        static void Main(string[] args)
        {
            //var neuronTest = new NeuronHandler();
            //neuronTest.run();

            //var oneLayerTest = new OneLayerHandler();
            //oneLayerTest.run();

            //var backPropagationTest = new BackPropagationHandler();
            //backPropagationTest.run();

            //var hebbRuleTest = new HebbRuleHandler();
            //hebbRuleTest.run();

            var kohonenMapTest = new KohonenMapsHandler();
            kohonenMapTest.run();

            //var kohoenWtaTest = new KohoenWtaHandler();
            //kohoenWtaTest.run();

            Console.ReadKey();
        }
    }
}
