using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement
{
    internal interface IPhoneBook
    {
        bool InsertPhone(string name, string phone);
        bool RemovePhone(string name);
        bool UpdatePhone(string name, string newPhone);
        void SearchPhone(string keyword);
        void Sort();
    }
}
