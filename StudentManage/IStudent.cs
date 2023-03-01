using System;
namespace StudentManage
{
    interface IStudent
    {
        string FullName { get; set; }
        int ID { get; set; }
        DateTime DateofBirth { get; set; }
        string Native { get; set; }
        string Class { get; set; }
        string PhoneNo { get; set; }
        int Mobile { get; set; }
        string Display();
    }
}