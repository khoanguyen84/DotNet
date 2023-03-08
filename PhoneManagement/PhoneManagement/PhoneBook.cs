using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement
{
    internal class PhoneBook : IPhoneBook
    {
        private SortedList<string, Phone> Contacts = new SortedList<string, Phone>()
        {
            { "Vũ", new Phone()
                        { 
                            Name = "Vũ", 
                            PhoneNumbers = new List<string>{ "0935216417" }
                        } 
            },
            { "Pháp", new Phone()
                        {
                            Name = "Pháp",
                            PhoneNumbers = new List<string>{ "0935363738", "012332145" }
                        }
            },
            { "Tài", new Phone()
                        {
                            Name = "Tài",
                            PhoneNumbers = new List<string>{ "0935363738", "012332145" }
                        }
            }
        };
        
        public bool InsertPhone(string name, string phone)
        {
            try
            {
                int position = -1;
                for (int i = 0; i < Contacts.Values.Count; i++)
                {
                    if (Contacts.Values[i].Name == name)
                    {
                        position = i;
                        break;
                    }
                }
                //Name is exists
                if (position != -1)
                {
                    Contacts.Values[position].PhoneNumbers.Add(phone);
                }
                else //not exists
                {
                    Phone newContact = new Phone()
                    {
                        Name = name,
                        PhoneNumbers = new List<string> { phone }
                    };
                    Contacts.Add(name, newContact);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemovePhone(string name)
        {
            try
            {
                return Contacts.Remove(name);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SearchPhone(string keyword)
        {
            Console.WriteLine("Name\t\tPhone numbers");
            foreach (Phone contact in Contacts.Values)
            {
                if(contact.Name.ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine($"{contact.Name}\t\t{string.Join(',', contact.PhoneNumbers)}");
                }
            }
        }

        public void Sort()
        {
            Console.WriteLine("Name\t\tPhone numbers");
            foreach(Phone contact in Contacts.Values)
            {
                Console.WriteLine($"{contact.Name}\t\t{string.Join(',', contact.PhoneNumbers)}");
            }    
        }

        public bool UpdatePhone(string name, string newPhone)
        {
            try
            {
                Phone contact = null;
                foreach(Phone phone in Contacts.Values)
                {
                    if(phone.Name.Equals(name))
                    {
                        contact = phone;
                        break;
                    }    
                }    
                if(contact != null)
                {
                    contact.PhoneNumbers = new List<string>() { newPhone };
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
