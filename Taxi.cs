using System;
namespace TugasClassTaxi
{
    public class Taxi
    {
        public string DriverName {get; set;}
        public bool OnDuty {get; set;}
        public int NumPassenger {get; set;}
    
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            switch (OnDuty)
            {
                case true:
                     Console.WriteLine("On Duty: Yes");
                     break;
            
                default:
                     Console.WriteLine("On Duty: No");
                     break;
            }
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }
    
        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }
        
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
