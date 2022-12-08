using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildUsedCarLot
{
    //Used Cars have mileage already so lets add this 
    public class UsedCar : Car
    {
        public double mileage { get; set; }

        //Constructor to take in all of the arguments from Usedcar and Car 

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return $"{make} {model} {year} ${price} (used) {mileage} miles "; 
        }
    }


}
