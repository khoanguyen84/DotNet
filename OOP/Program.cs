using System;
using System.Text;
namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Student vu = new Student("ABCDE", 18, "0935737475");
            vu.Fullname = "Vũ";
            // vu.StudentCode = "ABCDE";
            // vu.SetStudentCode("1221");
            // Console.Write(vu.GetStudentCode());
            // vu.Age = 18;
            Console.WriteLine(vu.Greeting());

            // Console.WriteLine(Helper.GetArea(10, 20));
            // Helper helper = new Helper();
            // Console.WriteLine(helper.Alert("Success"));
            Console.WriteLine(Helper.Alert("Success"));


            // Staff phap = new Staff("Phước", true, "B1");
            // Console.WriteLine(phap.Slogen());

            Person person = new Person("Bình", true);
            Console.WriteLine(person.ToString());


        }
    }
}