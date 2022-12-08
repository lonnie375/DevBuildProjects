using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildUsedCarLot
{
    //Car will store data about a car 
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }
     
       

        //No arguments Constructor that sets data members to default values 
        public Car()
        {
           
        
        }

        //Constructor with four arguments 
        public Car(string make, string model, int year, decimal price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{make} {model} {year} ${price}";
        }

    }
}
