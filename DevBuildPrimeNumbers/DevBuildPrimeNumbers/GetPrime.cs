using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildPrimeNumbers
{
    public class GetPrime
    {
        public int Number { get; set; } 

        public GetPrime(int number)
        {
            Number = number;
        }

        public GetPrime()
        {

        }

        //Is a given number prime
        public bool IsPrime(int value)
        {
 
            if (value % 2 == 0 && value != 2)
            {
                return false;
            }
            else if (value % 3 == 0 && value != 3)
            {
                return false;
            }
            else if (value % 5 == 0 && value != 5)
            {
                return false;
            }
            else if (value % 6 == 0)
            {
                return false;
            }
            else if (value % 7 == 0 && value != 7)
            {
                return false;
            }
            else if (value % 11 == 0 && value != 11)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }

        //Generate list of prime numbers
        public List<int> PrimeNumberList()
        {
            List<int> primeList = new List<int>();
            
            for (int i = 0; i <= 1000; i++)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                }
            }
            return primeList; 
        }


        //Get the users prime number 
        public void GetPrimeNumber(int index)
        {
            var test = PrimeNumberList();
            Console.WriteLine(test[index]); 
       
        }

    }
}
