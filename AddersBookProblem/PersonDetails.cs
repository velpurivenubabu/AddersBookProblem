using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AddersBookProblem
{
    internal class PersonDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int   zip { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; internal set; }
        public PersonDetails()
        {
            firstName = "Venubabu";
            lastName = "Velpuri";
            address = "P.Suravaram Village,Agiripalli Mandal";
            city = "Vijayawada";
            state = "Andrapradesh";
            zip = 521109;
            phoneNumber = 8919802540;
            email = "venu@123";
        }
        public string GetPersonDetails()
        {
            return ("Firstname: "+firstName+ " Lastname: "+ lastName+" Adders: "+ address+ " city: "+city+" State: "+ state + " Zip: " +zip+ " Phonenumber: "+ phoneNumber+" Email: " + email);
        }
        
    }
   
}
