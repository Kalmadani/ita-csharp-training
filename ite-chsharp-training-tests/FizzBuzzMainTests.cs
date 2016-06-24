using System;
using ita_chsharp_training;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ite_chsharp_training_tests
{
    [TestClass]
    public class FizzBuzzMainTests
    {
        //rule number one: If the number is evenly divisble by three, reurn Fizz.
        //rule number two: If the number is evenly divisible by five, return Buzz.
        //rule number three: If the number is evenly divisble by three and five, return FizzBuzz.
        //rule number four: If it does not match any of the other rules, just return number.

        [TestMethod]
        public void When_the_number_is_one()
        
        {
            FizzBuzzMain program = new FizzBuzzMain();
            string result = program.DoTheFizzBuzz(1);
            Assert.AreEqual("1",result);
        }
        [TestMethod]

        public void When_the_number_is_two()
        {
            FizzBuzzMain program = new FizzBuzzMain();
            string result = program.DoTheFizzBuzz(2);
            Assert.AreEqual("2", result);

        }

        [TestMethod]

        public void When_the_number_is_three()
        {
            FizzBuzzMain program = new FizzBuzzMain();
            string result = program.DoTheFizzBuzz(3);
            Assert.AreEqual("Fizz", result);
        }
                    
        [TestMethod]
       
        public void When_the_number_is_five()
   
      {
        FizzBuzzMain program = new FizzBuzzMain();
            string result = program.DoTheFizzBuzz(5);
            Assert.AreEqual("Buzz",result);

    }
        [TestMethod]

        public void When_the_number_is_fifteen()
        {
            FizzBuzzMain program = new FizzBuzzMain();
            string result = program.DoTheFizzBuzz(15);
            Assert.AreEqual("fizzBuzz", result);
        }
    
    }
}
