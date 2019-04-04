using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class CountrySide
    {
        static void Main()
        {
            new CountrySide().run();


        }

        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        // Village Maeland;
        // Village Helmholtz;
        Village Alst;
        Village Wessig;
        //  Village Badden;
        //  Village Uster;
        Village Schvenig;
        public void run()
        {
            // Maeland = new Village("Maeland", false);
            // Helmholtz = new Village("Helmholtz", false);
            Alst = new Village("Alst", false);
            Wessig = new Village("Wessig", true);
            //Badden = new Village("Badden", false);
            //Uster = new Village("Uster", false);
            Schvenig = new Village("Schvenig", false);

            Alst.west = Schvenig;
            Alst.east = Wessig;
            Alst.distanceToEastVillage = 14;
            Alst.distanceToWestVillage = 19;

            Schvenig.west = null;
            Schvenig.east = null;
            //Schvenig.distanceToNextVillage = 14;

            Wessig.west = null;
            Wessig.east = null;
            //Wessig.distanceToNextVillage = 14;
            this.travelvillage(Alst);
        }

        public void travelvillage(Village currentvillage)
        {
            if (currentvillage.isAstrildgeHere)
            {
                Console.WriteLine("Found astrildge in {}", currentvillage.VillageName);
                Console.WriteLine("Feeling Happy");
                return;
            }
            travelvillage(currentvillage.west);
            travelvillage(currentvillage.east);
        }

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
        public int distanceToEastVillage;
        public int distanceToWestVillage;
        //  public int distanceToPreviousVillage;
        public bool isAstrildgeHere;
    }
}