using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Distance
    {
        public static int getTotalDistance(LinkedList<Path> list)
        {
            int Sum = 0;
            Path dat = new Path();
            for(int i=0; i<list.Count;i++)
            {
                dat = list.ElementAt<Path>(i);
               // Console.WriteLine("Line 18 distance Path Elements : "+dat.distance);
                Sum = Sum + dat.distance;
            }
            return Sum;
        }




        public static int getDistance(String inputBits)
        {
  
               String dist = inputBits;
               int trim = int.Parse(dist.Substring(1, inputBits.Length - 1));  // input  { N2,W5,S6 } 

            return trim;

        }
    }
}
