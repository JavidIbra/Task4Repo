using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
   public class Motored_Vehicle
    {
        public string Model { get; set; }
        public string Make;
        public DateTime Year;
        public string Color { get; set; }
        public int MotorSize { get; set; }
        public double FuelTankSize { get; set; }
        public double FuelUsedPerKm { get; set; }
        public byte PassangerCount { get; set; }
        public int HorsePower { get; set; }
        public string Transmission { get; set; }
        public int FuelAmount { get; set; }
  

        public Motored_Vehicle()
        {
        }
        public Motored_Vehicle(string model, string make, DateTime year)
        {
            this.Model = model;
            this.Make = make;
            this.Year = year;
        }

        public void GetInfo()
        {
          
            Console.WriteLine($"gosterilen parametrlere uygun modeli: {this.Model} , istehsalci: {this.Make} , tarixi: {this.Year}");

        }

        public  virtual void GetDetailedInfo()
        {
            Console.WriteLine($"gosterilen parametrlere uygun " +
                $"modeli: {this.Model} , " +
                $" istehsalci: {this.Make} ," +
                $" tarixi: {this.Year} ,"  +
                $" Rengi: {this.Color} ," +
                $" muherrikin hecmi: {this.MotorSize} ," +
                $" Yanacaq ceninin tutumu: {this.FuelTankSize} ," +
                $" Muherrikin 1 km e serf etdiyi yanacaq: {this.FuelUsedPerKm} ," +
                $" Oturacaq sayi: {this.PassangerCount} ," +
                $" At gucu: {this.HorsePower} ," +
                $" Transmissiya: {this.Transmission}");

        }

    }
}
