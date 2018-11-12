
//037 264 1830
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Logic
    {
        public bool isInt(String entereValue)
        {
            int num;
            if (int.TryParse(entereValue, out num))
            {
                return true;
            }
            return false;
        }

        public void printerMethod(LinkedList<String> resultPrint)
        {
            foreach (String c in resultPrint)
                Console.WriteLine(c);

        }

        public String processMethod(String readLine)
        {
            String returnString = "";
            Char[] inputClone = readLine.ToCharArray();
            int countAlpha = 0;
            int countQuoma = 0;

            for (int j = 0; j < inputClone.Length; j++)    //Alphabet Counts in Input 
            {
                if (Char.Equals(inputClone[j], 'N'))
                    countAlpha++;
                if (Char.Equals(inputClone[j], 'E'))
                    countAlpha++;
                if (Char.Equals(inputClone[j], 'W'))
                    countAlpha++;
                if (Char.Equals(inputClone[j], 'S'))
                    countAlpha++;
                if (Char.Equals(inputClone[j], ','))
                    countQuoma++;
            }

            if (countQuoma == 0)
            {                         //Qouma count in Entered String  = 0
                if (countAlpha == 1)
                {
                    for (int i = 1; i < inputClone.Length; i++)
                    {
                        //if (!Char.IsDigit(inputClone[i]))
                       // {
                       // }
                       // Console.WriteLine("Logic: Line 58 " + readLine);
                        String trim = readLine.Substring(1, readLine.Length - 1);
                        return trim;

                        //Console.ReadLine();
                    }
                }
            }
            //-------------------------------------------------------------------------Another Case for countQuoma : 

            if (countQuoma > 0)
            {                          //Qouma count in Entered String  > 0               
                if (countAlpha > 1)
                {

                    LinkedList<String> directionList = new LinkedList<String>();
                    LinkedList<int> distList = new LinkedList<int>();

                    //New List Path Element 
                    LinkedList<Path> pathInformation = new LinkedList<Path>();
                    //Path done = new Path();// { dist, direct};
                    var bits = readLine.Split(',');

                    //New Path Class use LinkedList<Path> :
                    for (int j=0; j < bits.Length; j++) {
                        Path done = new Path();
                        int dist = Distance.getDistance(bits[j]);
                        String direct = DirectionClass.getDirection(bits[j]);
                        directionList.AddLast(direct);
                        
                        done.direction = direct;
                        done.distance = dist;
                        //Console.WriteLine("Logic Line 91 : "+direct);
                        pathInformation.AddLast(done);

                    }
                    //Console.WriteLine("Logic Line 93 : " + pathInformation.Count);
                    int totalDistance = Distance.getTotalDistance(pathInformation);
                   // Console.WriteLine("Logic Line 95 : " + totalDistance);

                    // ... matrice of (x , y) ::
                    int[,] matrcBlock = new int[totalDistance * 2, totalDistance * 2];

                    for (int r = 0; r < (totalDistance * 2); r++)          // Creation of Matrice Block 
                    {
                        for (int s = 0; s < (totalDistance * 2); s++)
                        {
                            matrcBlock[r, s] = 0;
                        }
                    }

                    int[] midPoint = new int[2];
                    midPoint[0] = totalDistance;
                    midPoint[1] = totalDistance;
                
                    matrcBlock = AtComputation.plotPath(0, midPoint, pathInformation, matrcBlock);

                    int count = 0;

                    for (int t = 0; t < totalDistance * 2; t++)   //Final Matrices Counts
                    {
                        for (int q = 0; q < totalDistance * 2; q++)
                        {
                            if (matrcBlock[t, q] == 1)
                            {
                                count++;
                            }
                        }
                    }

                    returnString += "\n" + count;
                    int rightTurns = 0;

                    rightTurns = Turns.getRightTurns(0, directionList);
                   // Console.WriteLine(" Line 134 : pathInformation.count : "+pathInformation.Count());

                    if (rightTurns > 0)
                    {
                        returnString += "\n";
                        returnString += "Right Turns : " + rightTurns;
                    }
                    return returnString;
                }
            }
            return returnString;
        }

    }
}

