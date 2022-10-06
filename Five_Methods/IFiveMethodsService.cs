using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Five_Methods
{
    [ServiceContract]
    public interface IFiveMethodsService
    {
        /// <summary>
        /// Check to see if the number input by user is a prime number
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns> A string that states if the number is a prime number or not </returns>
        [OperationContract]
        bool PrimeNumber (int userNum);

        /// <summary>
        /// Take the individual digits of the number the user input and adds them together.
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns> An integer of the sum of the digits </returns>
        [OperationContract]
        int SumDigits (string userNum);

        /// <summary>
        /// Take the string from the user, reverse the word, and display it back to the user
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns> A string of the word the user entered in reverse </returns>
        [OperationContract]
        string ReverseString (string userInput);

        /// <summary>
        /// Take the input from user, set the tag as an HTML Tag, and set the text to go in between the tags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="text"></param>
        /// <returns> Return an HTML Tag with the text between </returns>
        [OperationContract]
        string HtmlTags (string tag, string text);

        /// <summary>
        /// Take five number from the user, and take which way they would like is sorted and display the appropriate list.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns> The input array in an ascending or descending order </returns>
        [OperationContract]
        string SortNumbers(int[] numbers, string sortType);
    }    
}
