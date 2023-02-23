using System;

namespace OOP
{
    class Staff : Person 
    {
        public string Certificate { get; set; }
        public Staff(string name, bool gender, string certificate) : base(name, gender)
        {
            Certificate = certificate;
        }

        public override string Slogen()
        {
            return $"{base.Slogen()}\n2 + 2 = 4";
        }
    }
}