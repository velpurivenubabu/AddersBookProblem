using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AddressBookSystem
{
    internal class ManipulateContact
    {

        public List<ContactDetails> AddressBookList = new List<ContactDetails>();
        //Dictionary<string , ContactOptions> AddressBookList = new Dictionary<string, ContactOptions>();
        //Dictionary<string, ContactOptions> AddressBookList;


        public void AddingContact
            (
            string Name,
            string Address,
            string City,
            string State,
            string ZipCode,
            string PhoneNumber,
            string Email
            )
        {

            AddressBookList.Add
                (new ContactDetails()
                {
                    Name = Name,
                    Address = Address,
                    City = City,
                    State = State,
                    ZipCode = ZipCode,
                    PhoneNumber = PhoneNumber,
                    Email = Email
                });
        }


        public void EditingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.Name.Contains(Name))
                {
                    /*Console.Write("plz provide new ");
                    contact.Address = Console.ReadLine();
                    Console.Write("plz provide new ");
                    contact.City = Console.ReadLine();
                    Console.Write("plz provide new ");
                    contact.State = Console.ReadLine();
                    Console.Write("plz provide new ");
                    contact.ZipCode = Console.ReadLine();*/
                    Console.Write("enter new phone number: ");
                    contact.PhoneNumber = Console.ReadLine();
                    Console.Write("enter new email id: ");
                    contact.Email = Console.ReadLine();
                    Console.WriteLine($"{Name}'s Contact is edited______");
                    break;
                }
            }
        }

        public void DeletingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.Name.Contains(Name))
                {
                    AddressBookList.Remove(contact);
                    Console.WriteLine($"{Name}'s Contact is deleted______");
                    break;
                }
            }
        }




        public void SearchingInState(String City)
        {
            List<ContactDetails> CityBookList = new List<ContactDetails>();
            CityBookList = AddressBookList.FindAll(x => x.City.Contains(City) || x.State.Contains(City));

            foreach (var contact in CityBookList)
            {
                Console.Write($"{contact.Name}, ");
            }
            int Count = CityBookList.Count;
            Console.Write($"\ntotal people: {Count}\n ");
        }




        public void SortingAddressBook()
        {
            IComparer<ContactDetails> comparer = new SortingClass();
            AddressBookList.Sort(comparer);
        }
    }





    public class SortingClass : IComparer<ContactDetails>
    {
        public int Compare(ContactDetails x, ContactDetails y)
        {
            int NewName = x.Name.CompareTo(y.Name);
            return NewName;
        }
    
}