using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ita_chsharp_training
{
    public class FizzBuzzMain
    {
        public string DoTheFizzBuzz(int number)
        {

            if (number % 15 == 0)
            {
                return "fizzBuzz";
            }

            if(number % 3 == 0){
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            


            //implement other rules here
            
            
            
            return number.ToString();

        }


        
    }
}
