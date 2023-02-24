using System;
namespace OOP
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }
        public override string Flying()
        {
            throw new NotImplementedException();
        }

        public override string Move()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            throw new NotImplementedException();
        }

        public override string Swiming()
        {
            throw new NotImplementedException();
        }
    }
}