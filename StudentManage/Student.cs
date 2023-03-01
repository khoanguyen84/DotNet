using System;
namespace StudentManage
{
    class Student : IStudent
    {
        private string fullname;
        private int id;
        private DateTime dateofBirth;
        private string native;
        private string className;
        private string phoneNo;
        private int mobile;

        public string FullName { get => fullname; set => fullname = value; }
        public int ID { get => id; set => id = value; }
        public DateTime DateofBirth { get => dateofBirth; set => dateofBirth = value; }
        public string Native { get => native; set => native = value; }
        public string Class { get => className; set => className = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public int Mobile { get => mobile; set => mobile = value; }

        public Student() {}
        public Student(int id, string fullname, string className, string native, DateTime dob, string phoneNo, int mobile)
        {
            ID = id;
            Class = className;
            FullName = fullname;
            Native = native;
            DateofBirth = dob;
            PhoneNo = phoneNo;
            Mobile = mobile;
        }
        private string FormatDob(DateTime dateOfBirth)
        {
            return dateOfBirth.ToString("MMM-dd-yyyy");
        }
        public string Display()
        {
            return $"{id}\t{fullname}\t\t{FormatDob(dateofBirth)}\t\t{className}\t\t{native}\t\t{phoneNo}\t\t{mobile}";
        }
    }
}