using System;

namespace Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            // parameter (tham số) vs argument (đối số)
            // access_modify datatype method_name ([parameters])
            // { statements }
            // access_modify: internal, public, protected, private
            // data_type: -> void
            //          : -> data_type
            // method_name: tên phương thức
            // [parameters]: danh sách tham số, tối thiểu là 0 
            //              + mandatory (required) parameter: tham số bắt buộc
            //              + optional parameter: tham số không bắt buộc
            //              + named parameter: truyền giá trị cho parameter theo tên của parameter

            // pass_by_value: tham trị
            // pass_by_reference: tham chiếu. Sử dụng từ khóa ref khi định nghĩa và sử dụng method

            // overloading (tải bội) trong 1 lớp class được đặt trùng tên mothed khi
            //     -> khác số lượng tham số
            //     -> khác kiểu trả về


            // int number_1 = 10;
            // int number_2 = 20;
            // Swap(ref number_1, ref number_2);
            // Console.WriteLine($"number_1: {number_1}, number_2: {number_2}");
            // int n_1 = 0;
            // int n_2 = 0;
            // int result = Sum( number_1, number_2, out int n_1, out int n_2);
            // Console.WriteLine($"result: {result}");
            // Console.WriteLine($"n_1: {n_1}, n_2: {n_2}");

            // Alert("Error", "Something went wrong, please contact administror");
            // Alert("Info", "Product has been update success");
            // Alert();
            NamedParam(1, 2, 3, 4, 5);
            NamedParam(para_5: 5, para_3: 3, para_1: 1, para_4: 4, para_2: 2);
        }

        public static void Swap(ref int number_1, ref int number_2)
        {
            int number_0 = number_1;
            number_1 = number_2;
            number_2 = number_0;
            // Console.WriteLine($"number_1: {number_1}, number_2: {number_2}"); 
        }

        public static int Sum(int number_1, int number_2, out int n_1, out int n_2)
        {
            n_1 = number_1 + 10;
            n_2 = number_2 + 20;
            return number_1 + number_2;
        }
        public static int Sum(int number_1, int number_2)
        {
            return number_1 + number_2;
        }
        public static double Sum(double number_1, double number_2)
        {
            return number_1 + number_2;
        }


        public static void Alert(string type = "Info", string message = "Success")
        {
            Console.WriteLine($"{type}: {message}!");
        }

        public static void NamedParam(int para_1, int para_2, int para_3, int para_4, int para_5)
        {
            Console.WriteLine($"para_1: {para_1}\npara_2: {para_2}\npara_3: {para_3}\npara_4: {para_4}\npara_5: {para_5}");
        }
    }
}