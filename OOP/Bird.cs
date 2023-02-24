using System;
namespace OOP
{
    class Bird : Animal
    {
        public Bird(string name) : base(name)
        {

        }
        public override string Sound()
        {
            return "Líu lo";
        }

        public override string Move()
        {
            return "Flying";
        }

        public override string Flying()
        {
            throw new NotImplementedException();
        }

        public override string Swiming()
        {
            throw new NotImplementedException();
        }
    }
}