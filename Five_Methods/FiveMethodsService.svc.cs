﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
            return $"<{tag}>{text}</{tag}>";
        }

        public string PrimeNumber(int userNum)
        {
            int x = 0; // each number between 0 and the number the user input
            int factors = 0;  // the amount of numbers that divide into the the user input number
            do
            {
                if (userNum % x == 0)
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
            return $"{userInput.Reverse()}";

            //return (string)userInput.Reverse();
        }

        public string SortNumbers(int[] numbers, string sortType)
        {
            StringBuilder output = new StringBuilder("Your numbers in order: ");

            switch (sortType)
            {
                case "ASC":
                    {
                        output.Insert(15, " ascending ");
                        Array.Sort(numbers);
                        foreach (int i in numbers)
                        {
                            output.Append($"\n{i}");
                        }
                        break;
                    }

                case "DESC":
                    {
                        output.Insert(15, " descending ");

                        Array.Sort(numbers);
                        Array.Reverse(numbers);

                        foreach (int i in numbers)
                        {
                            output.Append($"\n{i}");
                        }
                        break;
                    }
                default:
                    break;
            }
            
            return output.ToString();
        }

        public int SumDigits(string userNum)
        {
            int[] digits = new int[userNum.Length];
            int i = 0;
            int answer = 0;

            foreach (char digit in userNum)
            {
                digits[i] = (int)digit;
            }

            foreach (int digit in digits)
            {
                answer += digit;
            }

            return answer;
        }
    }
}
