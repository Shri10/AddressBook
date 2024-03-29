﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(string name, AddressBook addressBook)
        {
            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = addressBook;
            }
            else
            {
                Console.WriteLine($"An address book with the name {name} already exists.");
            }
        }

        public AddressBook GetAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }
            else
            {
                Console.WriteLine($"No address book found with the name {name}");
                return null;
            }
        }

    }
}
