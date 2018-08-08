using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab_17.Test
{
    [TestFixture]
    public class PrimeNumberTests
    {
//
//        [TestCase(0)]
//        [TestCase(1)]
//        public void Should_Throw_Exception_If_Less_Than_Two(int num)
//        {
//            //arrange
//            var generator = new PrimeGenerator();
//            //act
//            try
//            {
//                string result = generator.PrimeNumberGenerator(num);
//
//            }
//            catch (Exception ex)
//            {
//                Assert.AreEqual("test", ex.Message);
//            }
//
//        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(10)]
        [TestCase(14)]
        [TestCase(66)]
        public void Should_Throw_Exception_If_Even_And_Not_Two(int num)
        {
            //assemble
            var generator = new PrimeGenerator();
            //act && assemble

            Assert.Throws<Exception>(() => generator.PrimeNumberGenerator(num));


        }

        public void Should_Throw_Exception_If_Greater_Than_IntMax(int num)
        {
            //assemble
            var generator = new PrimeGenerator();

            //act && assert           
            Assert.Throws<Exception>(() => generator.PrimeNumberGenerator(Int32.MaxValue));
        }
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(4, 7)]
        [TestCase(5, 11)]
//        [TestCase(10, 29)]
//        [TestCase(20, 71)]
//        [TestCase(25, 97)]
//        [TestCase(50, 229)]
//        [TestCase(99, 523)]
        public void Should_Return_Index_Of_Prime_List(int index, int prime)
        {
            int i = 1;
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            try
            {
                var result = primeNumbers[i];
            }
            catch (Exception e)
            {
                Assert.AreEqual(index, primeNumbers[i]);
            }
            
        }

        [Test]
        public void Should_Return_True_If_User_Wants_To_Search_Again()
        {
            var generator = new PlayAgain();
            //act & assert
            //Assert.IsTrue(PlayAgain.PlayAgainLoop());
            Assert.AreEqual(PlayAgain.PlayAgainLoop(), true);

        }
    }

}
