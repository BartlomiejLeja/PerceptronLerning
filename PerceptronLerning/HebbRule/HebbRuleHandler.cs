using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronLerning.HebbRule
{
    class HebbRuleHandler
    {
        public void HebbRuleShower()
        {
            var inputTest = new HebbLetterDataTextFileReader();
            var array = inputTest.ConverTextForTestDataArray(@"C:\Users\BartlomiejLeja\source\repos\PerceptronLerning\PerceptronLerning\HebbLetterLearningData.txt");

            var hebb = new HebbRule();
            
            hebb.adjustWeights(array, 50);
            Console.WriteLine("A");
            hebb.test(new double[] { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 });
            Console.WriteLine("B");
            hebb.test(new double[] { 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 ,0, 0, 1, 1, 1, 1, 1, 0 });
            Console.WriteLine("C");
            hebb.test(new double[] { 0 ,1 ,1 ,1 ,0 ,1 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1 ,0 });
            Console.WriteLine("D");
            hebb.test(new double[] { 1 ,1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0 });
            Console.WriteLine("E");
            hebb.test(new double[] { 1 ,1 ,1 ,1 ,1 ,1, 0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,1 ,1, 1 ,1, 0 ,1 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,1 ,1, 1, 1, 1 });
            Console.WriteLine("F");
            hebb.test(new double[] { 1 ,1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 ,0 ,1, 0, 0, 0, 0 });
            Console.WriteLine("G");
            hebb.test(new double[] { 0 ,1 ,1 ,1 ,0 ,1 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,1 ,0 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0, 1, 0, 1, 1, 1, 0 });
            Console.WriteLine("H");
            hebb.test(new double[] { 1 ,0 ,0 ,0 ,1, 1 ,0, 0 ,0, 1, 1 ,0, 0 ,0 ,1, 1 ,1, 1, 1 ,1 ,1 ,0 ,0, 0, 1,1 ,0, 0,0 ,1 ,1 ,0 ,0 ,0, 1 });
            Console.WriteLine("I");
            hebb.test(new double[] { 0, 1, 1, 1, 0 ,0 ,0, 1, 0 ,0, 0 ,0, 1 ,0,0 ,0 ,0, 1, 0 ,0 ,0 ,0, 1, 0, 0 ,0 ,0, 1, 0, 0 ,0 ,1 ,1 ,1 ,0 });
            //hebb.test(new double[] { 1 1 1 1 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 1 0 0 0 1 0 1 1 1 0 });
            //hebb.test(new double[] { 1 0 0 0 1 1 0 0 1 0 1 0 1 0 0 1 1 0 0 0 1 0 1 0 0 1 0 0 1 0 1 0 0 0 1 });
            //hebb.test(new double[] { 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 1 1 1 1 });
            //hebb.test(new double[] { 1 0 0 0 1 1 1 0 1 1 1 0 1 0 1 1 0 0 0 1 1 0 0 0 1 1 0 0 0 1 1 0 0 0 1 });
            //hebb.test(new double[] { 1 0 0 0 1 1 0 0 0 1 1 1 0 0 1 1 0 1 0 1 1 0 0 1 1 1 0 0 0 1 1 0 0 0 1 });
            //hebb.test(new double[] { 0 1 1 1 0 1 0 0 0 1 1 0 0 0 1 1 0 0 0 1 1 0 0 0 1 1 0 0 0 1 0 1 1 1 0 });
            //hebb.test(new double[] { 1 1 1 1 0 1 0 0 0 1 1 0 0 0 1 1 1 1 1 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 });
            //hebb.test(new double[] { 0 1 1 1 0 1 0 0 0 1 1 0 0 0 1 1 0 0 0 1 1 0 1 0 1 1 0 0 1 1 0 1 1 1 1 });
            //hebb.test(new double[] { 1 1 1 1 0 1 0 0 0 1 1 0 0 0 1 1 1 1 1 0 1 0 1 0 0 1 0 0 1 0 1 0 0 0 1 });
            //hebb.test(new double[] { 0 1 1 1 0 1 0 0 0 1 1 0 0 0 0 0 1 1 1 0 0 0 0 0 1 1 0 0 0 1 0 1 1 1 0 });
            //hebb.test(new double[] { 1 1 1 1 1 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1 0 0 });
            

        }
    }
}
