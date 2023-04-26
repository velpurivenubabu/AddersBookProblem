using System;
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
        public List<PersonDetails> person = new List<PersonDetails>();
        //int count = 0;
        public void GetPersonDetails(int num, string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)

        {
            //count++;
            PersonDetails contacts = new PersonDetails() { firstName = firstName, lastName = lastName, address = address, city = city, state = state, zip = zip, phoneNumber = phoneNumber, email = email };
            person.Add(contacts);

        }
        public void DisplayDetails()//Before updating

        {
            foreach (PersonDetails contact in person)//Here i am displaying the stored details
            {
                Console.WriteLine("Firstname: " + contact.firstName + " Lastname: " + contact.lastName + " Adders: " + contact.address + " city: " + contact.city + " State: " + contact.state + " Zip: " + contact.zip + " Phonenumber: " + contact.phoneNumber + " Email: " + contact.email);

            }

        }
        public  void UpdatingExistingContacts(List<PersonDetails> list)//Updating Existing Contacts
        {
            Console.WriteLine("Please Enter Witch Person Details You Want Update");
            string name = Console.ReadLine();
            bool isPrasent = false;
            foreach (PersonDetails contact in list)
            {
                if (contact.firstName == name)
                {
                    isPrasent = true;
                    Console.WriteLine("1.Firstname\n2.Lastname\n3.Address\n4.City\n5.State\n6.Zip\n7.Phonenumber\n8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please Enter FirstName");
                            contact.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please Enter lastName");
                            contact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please Enter Address");
                            contact.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please Enter City");
                            contact.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Please Enter State");
                            contact.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Please Enter Zip");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Please Enter PhoneNumber");
                            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Please Enter Email");
                            contact.email = Console.ReadLine();
                            break;
                    }

                }
            }

            UpdatingExistingContacts(list);//Here I am displaying Contacts After Updation 

        }
  
    }
}









