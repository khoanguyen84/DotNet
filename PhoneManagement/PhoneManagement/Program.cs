using System;
using System.Text;

namespace PhoneManagement
{
    class Program
    {
        private static PhoneBook phoneBook = new PhoneBook();
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            phoneBook.InsertPhone("Khoa", "0935123321");
            phoneBook.Sort();
            //phoneBook.UpdatePhone("Tài", "09359876543");
            phoneBook.Sort();
            phoneBook.SearchPhone("h");
        }
    }
}    
