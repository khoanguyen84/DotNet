using System;

namespace OOP
{
    // Phương thức abstract phải thuộc lớp abstract
    // trong lớp abstract có thể chưa phương thức/thuộc tính ko abstract
    // bên trong 1 lớp abstract có thể ko chưa phương thức/thuộc tính abstract nào
    // không thể tạo thể hiện/object từ abstract class
    // các lớp con kế thừa lớp abstract thì phải định nghĩa các phương thức/thuộc tính abstract
    // có thể tạo constructor(s) cho lớp abstract
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name) {
            Name = name;
        }
        public abstract string Sound();
        public abstract string Move();
        public abstract string Flying();
        public abstract string Swiming();

        public void Breath()
        {
            Console.Write("Breath");
        }
    }
}