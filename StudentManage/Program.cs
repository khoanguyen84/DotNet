using System;
using System.Text;
namespace StudentManage
{
    class Program
    {
        private static StudentService studentService = new StudentService();
        
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            BuildMenu();
        }

        public static void BuildMenu()
        {
            int selected = 0;
            do
            {
                Console.WriteLine("-----------Student Manage----------------");
                Console.WriteLine("1. Insert New Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Search Students");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choise: ");
                int.TryParse(Console.ReadLine(), out selected);
                while (selected == 0 || selected >= 5)
                {
                    Console.WriteLine("Invalid number, please try again");
                    Console.Write("Enter your choise: ");
                    int.TryParse(Console.ReadLine(), out selected);
                }
                switch (selected)
                {
                    case (int)Helper.Code.Create: 
                    {
                        Create();
                        break;
                    }
                    case (int)Helper.Code.List: 
                    {
                        Iterator();
                        break;
                    }
                    case (int)Helper.Code.Search: 
                    {
                        Search();
                        break;
                    }
                    case (int)Helper.Code.Exit: 
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            while (selected > 0 && selected < 5);
        }

        public static void Create()
        {
            Console.WriteLine("Input student information");
            Console.Write("Enter Fullname: ");
            string fullname = Console.ReadLine();
            Console.Write("Enter Date of birth: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Class: ");
            string className = Console.ReadLine();
            Console.Write("Enter Native: ");
            string native = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            string phoneNo = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            int mobile = int.Parse(Console.ReadLine());

            Student student = new Student(){
                FullName = fullname,
                DateofBirth = dob,
                Class = className,
                Native = native,
                PhoneNo = phoneNo,
                Mobile = mobile
            };
            CreateStudentResult result =  studentService.CreateStudent(student);

            Console.WriteLine(result.Message);
        }

        public static void Iterator()
        {
            studentService.ShowStudents();
        }

        public static void Search()
        {
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();
            studentService.SearchStudent(keyword);
        }
    }
}