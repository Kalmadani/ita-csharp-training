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
        public string DoTheFizzBuzz(int valueToCheck) 
          
        {
            string result = string.Empty;

            if(valueToCheck % 5 == 0){
                result = "Buzz"; 
            }
             if (valueToCheck % 3 == 0) {
                result = "Fizz";
            }
             if (valueToCheck % 15 == 0) {
                result = "fizzBuzz";

            }

             if (valueToCheck % 5 != 0 && valueToCheck % 3 != 0 && valueToCheck % 15 != 0 )
             {
                 result = valueToCheck.ToString();
                 
             }
            

            return result;           
        }
        
    }
}
