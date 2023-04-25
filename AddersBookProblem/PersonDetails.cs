﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AddersBookProblem
{
    public class PersonDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; internal set; }
        List<PersonDetails> person=new List<PersonDetails>();
        int count = 0;
        public  void GetPersonDetails(int num, string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
            
        {
            count++;
            PersonDetails contacts=new PersonDetails() {firstName=firstName, lastName = lastName, address = address, city=city, state= state, zip= zip, phoneNumber= phoneNumber, email= email };
            person.Add(contacts);
            if (count == num)
            {
                foreach (PersonDetails contact in person)//Here i am displaying the stored details
                {
                    Console.WriteLine("Firstname: " + contact.firstName + " Lastname: " + contact.lastName + " Adders: " + contact.address + " city: " + contact.city + " State: " + contact.state + " Zip: " + contact.zip + " Phonenumber: " + contact.phoneNumber + " Email: " + contact.email);
                }
            }
            
        }

        

    }

}









