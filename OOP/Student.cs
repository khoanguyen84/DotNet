using System;

namespace OOP
{
    class Student
    {
        // fields (chỉ được sử dụng bên trong class) -> private
        // properties -> public/protected
        // contructor(s) -> truyền những giá trị cần/bắt buộc khi tạo đối tượng
        // methods -> hành động

        // code convension
        // 1. fields
        private string studentCode;
        private string mobile;
        // 2. properties
        public string Fullname { set; get; }
        public int Age { get; set; }

        // 3. Constructors
        public Student()
        {

        }
        public Student(string code, int age, string mobile)
        {
            studentCode = code;
            Age = age;
            this.mobile = mobile;
        }
        
        // 4. Methods
        public string StudentCode
        {
            get => studentCode;
            set => studentCode = value;
        }
        // public string StudentCode 
        // {
        //     get { return this.studentCode; }
        //     set { this.studentCode = value; }
        // }
        // public string GetStudentCode()
        // {
        //     return this.studentCode;
        // }

        // public void SetStudentCode(string NewCode)
        // {
        //     this.studentCode = NewCode;
        // }

        public string Greeting(){
            return $"Tôi tên là {this.Fullname}, năm nay tôi {this.Age} tuổi.";
        }

        public string GetMobile()
        {
            return EncodeMobile(this.mobile);
        }

        private string EncodeMobile(string phoneNumber)
        {
            return $"{phoneNumber.Substring(0, 7)}XXX";
        }
    }
}