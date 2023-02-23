using System;
namespace OOP
{
    class Person
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public Person() { }
        public Person(string name, bool gender)
        {
            Name = name;
            Gender = gender;
        }

        public virtual string Slogen()
        {
            return "1 + 1 = 2";
        }

        public override string ToString()
        {
            return $"Tôi là {(Gender ? "Mr" : "Mrs")}.{Name}";
        }
    }
}