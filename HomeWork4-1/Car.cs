using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Car : Motored_Vehicle
    {
        public bool isOn { get; set; }

        public Car(string model,string make,DateTime year) : base(model, make, year)
        {
        }


        public override void GetDetailedInfo()
        {
            base.GetDetailedInfo();
            Console.WriteLine($"FuelAmount: {this.FuelAmount}");
        }
       


        public void TurnOn()
        {
            this.isOn =true;
            Console.WriteLine("masini ise saldiq!");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine("masin sonuludur!"); 
        }
      
        public void Go(int road)
        {
           
            double CanGo;
            CanGo = road * this.FuelUsedPerKm;
            if (this.isOn==true)
            {
               
                if (CanGo > this.FuelTankSize)
                {
                    Console.WriteLine("avtomobilin yanacaq ceni az tutumludur bes etmeyecek!");
                }
                else if (CanGo == this.FuelTankSize)
                {
                    Console.WriteLine("dibe dib cataciq))");
                }
                else
                {
                    Console.WriteLine($"{road} km mesafe qet edildi!");
                }
            }
            else
            {
                Console.WriteLine("getmek ucun masini xodlamaq lazimdir!!");
            }

        }
    }
}
