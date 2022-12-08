using DevBuildPrimeNumbers;

namespace PrimNumber_test
{
    public class UnitTest1
    {
        //Testing numbers to see if they're prime or not.
        //Prime numbers are true 
        [Theory]
        [InlineData(11, true)]
        [InlineData(13, true)]
        [InlineData(8, false)]
        [InlineData(17, true)]
        [InlineData(16, false)]
        [InlineData(19, true)]
        public void IsThisPrime(int value, bool expected)
        {
            GetPrime c1 = new GetPrime();
            bool actual = c1.IsPrime(value); 
            Assert.Equal(expected, actual);
        }

        //Confirm Prime Numbers are in a list 
        //Is this necessary? 


    }
}