using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Five_Methods
{
    public class FiveMethodsService : IFiveMethodsService
    {
        public string HtmlTags(string tag, string text)
        {
            throw new NotImplementedException();
        }

        public string PrimeNumber(int userNum)
        {
            int x = 0; // each number between 0 and the number the user input
            int factors = 0;  // the amount of numbers that divide into the the user input number
            do
            {
                if ( userNum % x == 0 )
                {
                    factors++;
                }

            } while (x < userNum); ;

            if (factors == 2)
            {
                return $"{userNum} IS a prime number!";
            }

            return $"{userNum} IS NOT a prime number!";
        }

        public string ReverseString(string userInput)
        {
            throw new NotImplementedException();
        }

        public string SortNumbers(int[] numbers, string sortType)
        {
            throw new NotImplementedException();
        }

        public int SumDigits(string userNum)
        {
            throw new NotImplementedException();
        }
    }
}
