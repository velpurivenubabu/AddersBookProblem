namespace AddersBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonDetails data = new PersonDetails();
            Console.WriteLine("Welcome to Adders book Problem");
            Console.WriteLine("Enter Number of persons You Want to Add");
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
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

            }

        }
    }
}