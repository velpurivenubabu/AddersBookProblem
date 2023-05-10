using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Net;

namespace AddersBookProblem
{
    internal class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("Wlecom to Nlog");
        PersonDetails data = new PersonDetails();
            Console.WriteLine("Welcome to Adders book Problem");
            Console.WriteLine("Enter Number of persons You Want to Add");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int person = 0; person < number; person++)//UC5 Adding Multiple Contacts To Adders Book
            {//This loop Allows User To Enter the Multiple details
                Console.WriteLine("Enter FirstName");
                string firstName=Console.ReadLine();
                Console.WriteLine("Enter LastName");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Adders");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Zip");
                int zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PhoneNumer");
                long phoneNumber=Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();

                data.GetPersonDetails(number,firstName,lastName,address,city,state,zip,phoneNumber,email);
                data.AddingContact(firstName, lastName,address, city,state, zip,phoneNumber,email);
            }
            data.DisplayDetails();
            data.UpdatingExistingContacts(data.person);
            data.DeletingExistingContacts(data.person);
            data.DisplayMultipleAdders();

        }
    }
}