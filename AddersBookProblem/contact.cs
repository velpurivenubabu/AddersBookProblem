using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class ContactOptions
    {
        public static Dictionary<string, ManipulateContact> MultiAddressBook = new Dictionary<string, ManipulateContact>();


        ManipulateContact manipulate = new ManipulateContact();
        public void AddContact(string BookName)
        {
            Console.Write($"how many contacts do you want to add: ");
            int num = Convert.ToInt32(Console.ReadLine());

            ManipulateContact manipulateAppend = new ManipulateContact();
            for (int i = 1; i <= num; i++)
            {
                bool Duplicate = false;
                Console.Write("enter name: ");
                string Name = Console.ReadLine();
                Console.Write("enter address: ");
                string Address = Console.ReadLine();
                Console.Write("enter city: ");
                string City = Console.ReadLine();
                Console.Write("enter state: ");
                string State = Console.ReadLine();
                Console.Write("enter zip code: ");
                string ZipCode = Console.ReadLine();
                Console.Write("enter phone number: ");
                string PhoneNumber = Console.ReadLine();
                Console.Write("enter email id: ");
                string Email = Console.ReadLine();
                ContactDetails detail = new ContactDetails();
                foreach (var contact in manipulate.AddressBookList)
                {
                    if (contact.Name.Contains(Name))
                    {
                        Duplicate = true;
                    }
                }

                if (!Duplicate)
                {
                    manipulate.AddingContact(
                      detail.Name = Name,
                      detail.Address = Address,
                      detail.City = City,
                      detail.State = State,
                      detail.ZipCode = ZipCode,
                      detail.PhoneNumber = PhoneNumber,
                      detail.Email = Email
                      );

                    manipulateAppend.AddingContact(
                      detail.Name = Name,
                      detail.Address = Address,
                      detail.City = City,
                      detail.State = State,
                      detail.ZipCode = ZipCode,
                      detail.PhoneNumber = PhoneNumber,
                      detail.Email = Email
                      );
                    Console.WriteLine($"{Name}'s Contact is added______");
                }
                else
                {
                    Console.WriteLine("contact name already exists");
                    num++;
                }
            }
            MultiAddressBook.Add(BookName, manipulateAppend);
        }

        public void EditContact()
        {
            Console.Write("enter name you want edit: ");
            string Name = Console.ReadLine();
            manipulate.EditingContact(Name);
        }
        public void DeleteContact()
        {
            Console.Write("enter name you want delete: ");
            string Name = Console.ReadLine();
            manipulate.DeletingContact(Name);
        }

        public void SearchInState()
        {
            Console.Write("enter city/state name you want search in: ");
            string City = Console.ReadLine();
            manipulate.SearchingInState(City);
        }
    }
}


