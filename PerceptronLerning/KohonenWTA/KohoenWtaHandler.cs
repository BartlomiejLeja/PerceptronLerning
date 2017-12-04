using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronLerning.KohonenWTA
{
    public class KohoenWtaHandler
    {
        public void run()
        {
            var KohonenWTANetwork = new KohonenNetwork(50, 3);
            KohonenWTANetwork.learnNetwork();

            double[] tab7 = new double[]
         {
               0.8,  2.7, 10.1,  10.8
         };
            double[] tab1 = new double[]
            {
                5.1, 3.5, 1.4, 0.2
            };

            double[] tab2 = new double[]
            {
               4.9, 3.0, 1.4, 0.2
            };

            double[] tab3 = new double[]
            {
               7.0,   3.2, 4.7, 1.4
            };

            double[] tab4 = new double[]
            {
               6.4, 3.2, 4.5, 1.5
            };

            double[] tab5 = new double[]
            {
               6.3, 3.3, 6.0, 2.5
            };

            double[] tab6 = new double[]
            {
               5.8,  2.7, 5.1, 1.9
            };

           
            KohonenWTANetwork.testNetwork(tab1, 4);
            Console.WriteLine();
            KohonenWTANetwork.testNetwork(tab2, 4);
            Console.WriteLine();
            KohonenWTANetwork.testNetwork(tab3, 4);
            Console.WriteLine();
            KohonenWTANetwork.testNetwork(tab4, 4);
            Console.WriteLine();
            KohonenWTANetwork.testNetwork(tab5, 4);
            Console.WriteLine();
            KohonenWTANetwork.testNetwork(tab6, 4);
            Console.WriteLine();
            KohonenWTANetwork.testNetwork(tab7, 4);
            Console.WriteLine();

        }
    }
}
