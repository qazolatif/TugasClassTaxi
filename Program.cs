using System;
namespace TugasClassTaxi
{
    class Program 
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            
            taxi.DriverName = "Toni";
            taxi.OnDuty = true;
            taxi.NumPassenger = 30;
            
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
            
            Console.ReadKey();
        }
    }
}
