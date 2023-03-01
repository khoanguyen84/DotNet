using System;
namespace StudentManage
{
    class StudentService
    {
        private Student[] students = new Student[2]{
            new Student(1, "Khoa Nguyễn", "CGH1", "TP Huế", DateTime.Parse("10/10/2000"), "123", 123),
            new Student(2, "Phước Nguyễn", "CGH2", "TP Huế", DateTime.Parse("10/10/2000"), "123", 123)
        };

        public CreateStudentResult CreateStudent(Student student)
        {
            try
            {
                student.ID = FindLatestId() + 1;
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
                return new CreateStudentResult()
                {
                    Sucess = true,
                    Message = "Student has been created success"
                };
            }
            catch (Exception ex)
            {
                return new CreateStudentResult()
                {
                    Sucess = false,
                    Message = "Something went wrong, please contact administrator!"
                };
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine("#ID\tFullname\t\tDateofBirth\t\tClass\t\tNative\t\tPhoneNo\t\tMobile");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Display());
            }
        }

        public void SearchStudent(string keyword)
        {
            Console.WriteLine("#ID\tFullname\t\tDateofBirth\t\tClass\t\tNative\t\tPhoneNo\t\tMobile");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].FullName.ToLower().Contains(keyword.ToLower())
                    || students[i].Class.ToLower().Contains(keyword.ToLower())
                )
                {
                    Console.WriteLine(students[i].Display());
                }
            }
        }

        private int FindLatestId()
        {
            int max = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if(students[i].ID > max)
                {
                    max = students[i].ID;
                }
            }
            return max;
        }
    }
}