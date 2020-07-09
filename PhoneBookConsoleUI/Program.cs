using System;

namespace PhoneBookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to your phonebook!");
            Console.WriteLine("Let's create your first contact.");
            string userResponse;

            do
            {
                Contact c = new Contact();

                Console.WriteLine("Please enter the contacts first name: ");
                c.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter the contacts last name: ");
                c.LastName = Console.ReadLine();

                Console.WriteLine("Please enter the contacts phone number: ");
                c.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Do you want to create another contact?");
                userResponse = Console.ReadLine();

                PhoneBook.ContactList.Add(c);

            } while (userResponse.ToLower() == "yes");

            Console.WriteLine("Here are the contacts you've have so far:");

            User.ReadAllContacts();
            
        }
    }
}
