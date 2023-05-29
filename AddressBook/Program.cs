namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");

            AddressBook addressBook = new AddressBook();

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Contacts contact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);

            addressBook.AddContact(contact);

            Console.WriteLine($"Added contact: {contact.FirstName} {contact.LastName}");

            Console.WriteLine("Do you want to edit a contact? (yes/no)");
            string editInput = Console.ReadLine();

            if (editInput.ToLower() == "yes")
            {
                Console.Write("Enter First Name of contact to edit: ");
                string firstNameToEdit = Console.ReadLine();

                Console.Write("Enter Last Name of contact to edit: ");
                string lastNameToEdit = Console.ReadLine();

                Console.WriteLine("Enter new contact details:");

                Console.Write("Enter First Name: ");
                firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                lastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                address = Console.ReadLine();

                Console.Write("Enter City: ");
                city = Console.ReadLine();

                Console.Write("Enter State: ");
                state = Console.ReadLine();

                Console.Write("Enter Zip Code: ");
                zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                phoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                email = Console.ReadLine();

                Contacts newContact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);

                addressBook.EditContact(firstNameToEdit, lastNameToEdit, newContact);

                Console.WriteLine($"Edited contact: {newContact.FirstName} {newContact.LastName}");
            }

        }
    }
}