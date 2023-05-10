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
        public void UpdatingExistingContacts(List<PersonDetails> list)//Updating Existing Contacts
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
                    DisplayDetails();
                }
                else
                {
                    Console.WriteLine("Contact details of person not existed");
                }
            }



        }
        public void DeletingExistingContacts(List<PersonDetails> list)
        {
            Console.WriteLine("Please Enter The Person Name Witch you Want to remove");
            string name1 = Console.ReadLine();
            bool present = false;
            foreach (PersonDetails contact in list) {
                if (contact.firstName == name1)
                {
                    present = true;
                    list.Remove(contact);
                    DisplayDetails();
                    break;

                }
            }
            if (!present)
            {
                Console.WriteLine("Person not exit");
            }
        }
        //UC6 Adding Multiple Adders to Adders Book
        

            List<PersonDetails> AddressBookList = new List<PersonDetails>();

        //Dictionary<string , ContactOptions> AddressBookList = new Dictionary<string, ContactOptions>();
        //Dictionary<string, ContactOptions> AddressBookList;


        public void AddingContact
            (
            string firstName,
            string lastName,
            string address,
            string city,
            string state,
            int zip,
            long phoneNumber,
            string email
            )
        {

            AddressBookList.Add
                (new PersonDetails()
                {
                    firstName = firstName,
                    lastName = lastName,
                    address = address,
                    city = city,
                    state = state,
                    zip = zip,
                    phoneNumber = phoneNumber,
                    email = email
                }
            );
            Console.WriteLine($"{lastName} {firstName} contact is added______");

        }
        public void DisplayMultipleAdders()
        {
            foreach (PersonDetails contact in AddressBookList)
            {
                Console.WriteLine(contact.firstName);
                Console.WriteLine(contact.lastName);
                Console.WriteLine(contact.address);
                Console.WriteLine(contact.city);
                Console.WriteLine(contact.state);
                Console.WriteLine(contact.zip);
                Console.WriteLine(contact.phoneNumber);
                Console.WriteLine(contact.email);
            }

        }
    }
    

}









