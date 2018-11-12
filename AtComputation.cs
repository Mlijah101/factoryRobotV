using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AtComputation
    {
        public static int[,] plotPath(int count, int[] midPoint, LinkedList<Path> distLst, int[,] matrx)
        {

            if (distLst.Count() > 0)
            {
                // Start Plotting one direction at a time ..
                if (count == 0)
                {
                    //Console.WriteLine(" count ==0 if statement 0");
                    int followCoordinate = 0;
                    //int followCoordinate1 = 0;

                    if (String.Equals((String)distLst.First().direction, (String)"N"))
                    { // N-> +Y 

                        for (int one = 1; one <= distLst.First().distance; one++)
                        {
                            matrx[midPoint[0], midPoint[1] + one] = 1;
                            followCoordinate = one;
                        }
                        midPoint[0] = midPoint[0];
                        midPoint[1] = midPoint[1] + followCoordinate;
                        count++;

                        distLst.RemoveFirst();
                        distLst.RemoveFirst();
                        if (distLst.Count() >= 1)
                        {
                            plotPath(count, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }

                    }
                    if (String.Equals(distLst.First(), (String)"S"))
                    { // S -> -Y
                        for (int two = 1; two <= distLst.First().distance; two++)
                        {
                            matrx[midPoint[0], midPoint[1] - two] = 1;
                            followCoordinate = two;
                        }
                        midPoint[0] = midPoint[0];
                        midPoint[1] = midPoint[1] - followCoordinate;
                        count++;

                        if (distLst.Count() >= 1)
                        {
                            distLst.RemoveFirst();
                            distLst.RemoveFirst();

                            plotPath(count, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }

                    }
                    if (String.Equals((String)distLst.First().direction, (String)"E"))
                    { // E -> +X

                        for (int three = 1; three <= distLst.First().distance; three++)
                        {
                            matrx[midPoint[0] + three, midPoint[0]] = 1;
                            followCoordinate = three;
                        }
                        midPoint[0] = midPoint[0] + followCoordinate;
                        midPoint[1] = midPoint[1];
                        count++;

                        if (distLst.Count() >= 1)
                        {
                            distLst.RemoveFirst();

                            plotPath(count, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }

                    }
                    if (String.Equals((String)distLst.First().direction, (String)"W"))
                    { // W -> -X
                        for (int four = 1; four <= distLst.First().distance; four++)
                        {
                            matrx[midPoint[0] - four, midPoint[1]] = 1;
                            followCoordinate = four;
                        }
                        midPoint[0] = midPoint[0] - followCoordinate;
                        midPoint[1] = midPoint[1];
                        count++;

                        distLst.RemoveFirst();
                        //lst.RemoveFirst();
                        if (distLst.Count() >= 1)
                        {
                            plotPath(count, midPoint, distLst, matrx);
                        }
                        else if (distLst.Count() == 0)
                        {
                            return matrx;
                        }
                        // take away last known direction, return function if #sizeOf Direction > 0 ..
                        // middlePoint changes
                        // Size of distance also changes
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////


                if (count > 0 && distLst.Count() > 0)
                {

                    //int followCoordinate = 0;
                    int followCoordinate1 = 0;
                    int iteration = 1;

                    if (String.Equals((String)distLst.First().direction, (String)"N"))
                    { // N-> +Y 
                        for (int one = 1; one <= distLst.First().distance; one++)
                        {
                            matrx[midPoint[0], midPoint[1] + one] = 1;
                            followCoordinate1 = one;
                        }
                        midPoint[0] = midPoint[0];
                        midPoint[1] = midPoint[1] + followCoordinate1;
                        iteration++;
                        distLst.RemoveFirst();
                        //lst.RemoveFirst();
                        if (distLst.Count() >= 1)
                        {
                            plotPath(iteration, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }
                        // take away last known direction, return function if #sizeOf Direction > 0 ..
                        // middlePoint changes
                        // Size of distance also changes
                    }
                    if (String.Equals((String)distLst.First().direction, (String)"S"))
                    { // S -> -Y
                        for (int two = 1; two <= distLst.First().distance; two++)
                        {
                            matrx[midPoint[0], midPoint[1] - two] = 1;
                            followCoordinate1 = two;
                        }
                        midPoint[0] = midPoint[0];
                        midPoint[1] = midPoint[1] - followCoordinate1;
                        iteration++;
                        distLst.RemoveFirst();
                        //lst.RemoveFirst();
                        if (distLst.Count() >= 1)
                        {
                            plotPath(iteration, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }
                        // take away last known direction, return function if #sizeOf Direction > 0 ..
                        // middlePoint changes
                        // Size of distance also changes

                    }
                    if (String.Equals((String)distLst.First().direction, (String)"E"))
                    { // E -> +X

                        for (int three = 1; three <= distLst.First().distance; three++)
                        {
                            matrx[midPoint[0] + three, midPoint[1]] = 1;
                            followCoordinate1 = three;
                        }
                        midPoint[0] = midPoint[0] + followCoordinate1;
                        midPoint[1] = midPoint[1];
                        iteration++;
                        distLst.RemoveFirst();
 
                        if (distLst.Count() >= 1)
                        {
                            plotPath(iteration, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }
                       
                    }
                    if (String.Equals(distLst.First().direction, (String)"W"))
                    { // W -> -X

                        for (int four = 1; four <= distLst.First().distance; four++)
                        {
                            matrx[(midPoint[0] - four), midPoint[1]] = 1;
                            followCoordinate1 = four;
                        }
                        midPoint[0] = midPoint[0] - followCoordinate1;
                        midPoint[1] = midPoint[1];
                        iteration++;
                        //direction = reducedDirection(direction);
                        //distance = reducedDistance(distance);
                        distLst.RemoveFirst();
                        //lst.RemoveFirst();
                        if (distLst.Count() >= 1)
                        {
                            plotPath(iteration, midPoint, distLst, matrx);
                        }
                        if (distLst.Count() == 0)
                        {
                            return matrx;
                        }
                        // take away last known direction, return function if #sizeOf Direction > 0 ..
                        // middlePoint changes
                        // Size of distance also changes
                    }


                    // take away last known direction, return function if #sizeOf Direction > 0 ..
                    // middlePoint changes
                    // Size of distance also changes
                    //return plotPath(midPoint, direction, distance, matrx);
                } // count > 0



            } // close if distance==0  
            if (distLst.Count() == 0)
            {
                return matrx;
            }

            return matrx;
        }
    }
}
