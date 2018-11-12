using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String readLine = "";
            readLine = Console.ReadLine();

            // Test Case Entered integer Value: ...
            
            Logic myLogic = new Logic();

            if (myLogic.isInt(readLine))
            {      // Only integer entered
                LinkedList<String> resultPrint = new LinkedList<String>();
               // Console.WriteLine("Program: readLine 23 "+ readLine);
   
                int j = int.Parse(readLine);
                int i = 0;
                while (i < j)
                {
                    String inputString = "";
                    inputString = Console.ReadLine();
                    resultPrint.AddLast(myLogic.processMethod(inputString));
                    i++;
                }

                myLogic.printerMethod(resultPrint);
                Console.ReadLine();
            }

            // Not Test Integer Case Entered, but Directions and Values 
            if (!myLogic.isInt(readLine))
            {       // Direction and Integer Values Entered
                Console.WriteLine(myLogic.processMethod(readLine));
                Console.ReadLine();

            }

        }
        //----------------------------------Close Of main Method <<-- :
    }
}
