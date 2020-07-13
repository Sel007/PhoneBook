using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PhoneBookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSelection();
            MenuFunctions();
        }

        private static void MenuFunctions()
        {
            int userResponse = int.Parse(Console.ReadLine());

            switch (userResponse)
            {
                case 1:

                    Contact c = new Contact();

                    Console.Write("Enter contacts First name: ");
                    c.FirstName = Console.ReadLine();

                    Console.Write("Enter contacts Last name: ");
                    c.LastName = Console.ReadLine();

                    Console.Write("Enter contacts Phone number: ");
                    c.PhoneNumber = Console.ReadLine();

                    PhoneBook.ContactList.Add(c);

                    MenuSelection();
                    MenuFunctions();

                    break;

                case 2:
                    Console.WriteLine("Here are your contacts");
                    User.ReadAllContacts();

                    MenuSelection();
                    MenuFunctions();

                    break;

                case 3:
                    Console.WriteLine("Who would you like to update?");

                    var UserResponse = Console.ReadLine();
                    for (int j = 0; j < PhoneBook.ContactList.Count; j++)
                    {
                        if (PhoneBook.ContactList[j].FirstName == UserResponse)
                        {
                            PhoneBook.ContactList.Remove(PhoneBook.ContactList[j]);
                        }
                    }

                    Contact p = new Contact();

                    Console.Write("Enter contacts First name: ");
                    p.FirstName = Console.ReadLine();

                    Console.Write("Enter contacts Last name: ");
                    p.LastName = Console.ReadLine();

                    Console.Write("Enter contacts Phone number: ");
                    p.PhoneNumber = Console.ReadLine();

                    PhoneBook.ContactList.Add(p);

                    MenuSelection();
                    MenuFunctions();
                    break;

                case 4:
                    Console.WriteLine("Who would you like to delete?");

                    User.ReadAllContacts();
                    var userChoice = Console.ReadLine();
                    for(int i = 0; i < PhoneBook.ContactList.Count; i++)
                    {
                    if(PhoneBook.ContactList[i].FirstName == userChoice)
                    {
                        PhoneBook.ContactList.Remove(PhoneBook.ContactList[i]);
                    }
                    }

                    MenuSelection();
                    MenuFunctions();
                    break;

                case 5:
                    Console.WriteLine("Exiting phonebook");
                    break;
            }
        }

        public static void MenuSelection()
            {
                Console.WriteLine("What would you like to do in your PhoneBook?: \n \n" +
                "1.) Create new contact\n" +
                "2.) View contacts\n" +
                "3.) Update a contact\n" +
                "4.) Delete a contact\n" +
                "5.) Exit phonebook\n");
            }
    }
}
