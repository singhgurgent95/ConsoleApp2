using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program
    {
        static void Main()
        {
            // new yogesh().veerpal();
            Console.WriteLine(UsingRecursion.CalculateRecursively(2, 8));
        }
    }
    class yogesh
    {
        static int j = 0;
        public void veerpal()
        { // let's write a Trace message
            Console.WriteLine(yogesh.j++);
            int Sum = 0;
            Sum += 1;
            veerpal();

        }
    }

    class UsingRecursion
    {
        // Create an application which 
        // calculates the sum of all the numbers from n to m recursively:

        public static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateRecursively(n, m);
            }
            return sum;
        }


    }

    class CountrySide
    {
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;
        public void Run()
        {
            Village Alst = new Village("Alst", false);
            Village Schvenig = new Village("Schvenig", false);
            Village Wessig = new Village("Wessig", true);
            Alst.west = Schvenig;
            Alst.east = Wessig;
            Alst.distanceToWestVillage = 14;
            Alst.distanceToEastVillage = 19;

            Schvenig.west = Schvenig;
            Schvenig.east = Wessig;
            Schvenig.distanceToWestVillage = 14;
            Schvenig.distanceToEastVillage = 19;
            Wessig.west = Schvenig;
            Wessig.east = Wessig;
            Wessig.distanceToWestVillage = 14;
            Wessig.distanceToEastVillage = 19;
        }


        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToWestVillage;
            public int distanceToEastVillage;
            public bool isAstrildgeHere;
            
           
        }
    }
}


    


