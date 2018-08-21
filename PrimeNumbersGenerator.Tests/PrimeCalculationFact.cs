using Xunit;

namespace PrimeNumbersGenerator.Tests
{
    public class PrimeCalculationFact
    {
        [Fact]
        public void Next_Prime_Should_Be_11()
        {
            PrimeNumber newPrimeNumber = PrimeCalculation.NextPrime(10);
            Assert.Equal(11, newPrimeNumber.Number);
        }

        [Fact]
        public void Next_Prime_Should_Be_359()
        {
            PrimeNumber newPrimeNumber = PrimeCalculation.NextPrime(354);
            Assert.Equal(359, newPrimeNumber.Number);
        }

        [Fact]
        public void Next_Prime_Should_Be_5623()
        {
            PrimeNumber newPrimeNumber = PrimeCalculation.NextPrime(5592);
            Assert.Equal(5623, newPrimeNumber.Number);
        }

    }
}
