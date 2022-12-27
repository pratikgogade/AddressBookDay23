using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            AddressBook ab = new AddressBook("Pratik", "Gogade", "Ambe Smruti", "Mumbai", "Maharashtra", "psg241999@gmail.com", 410222, 9284664856);
            ab.DisplayContacts();
        }
    }
}