using System;
using System.Text;

namespace Part4
{
    internal class Program
    {
        public static void ex5()
        {
            int b = 1;
            for (int i = 1; i <= 20; i++)
            {
                b = b * i;
                Console.WriteLine(b);
            }
        }

        public static void ex2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ReadLine();
            Console.WriteLine("Nhập vào số thứ 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 3: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            max = a > b ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine("Max trong 3 số {0}, {1}, {2} là {3}", a, b, c, max);
            Console.ReadKey();
        }

        public static void ex1()
        {
            Console.WriteLine("Nhập tên:");
            string name = Console.ReadLine();

            Console.WriteLine("Nhập địa chỉ:");
            string address = Console.ReadLine();

            Console.WriteLine("Nhập số:");
            string phone = Console.ReadLine();

            Console.WriteLine(name + " , " + address + " , " + phone);
        }

        public static void ex3()
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.ReadLine();
            Console.WriteLine("Nhập vào số thứ 1: ");
            int a = int.Parse(Console.ReadLine());
            int max = a;
            String dayName;
            switch (a)
            {
                case 1:
                    dayName = "Thứ 2";
                    Console.WriteLine("Hôm nay là thứ {0}", dayName);
                    break;
                case 2:
                    dayName = "Thứ bar";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 3:
                    dayName = "Thứ tư";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 4:
                    dayName = "Thứ lăm";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 5:
                    dayName = "Thứ sáu";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 6:
                    dayName = "Thứ 7";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                case 7:
                    dayName = "Chủ nhật ";
                    Console.WriteLine($"Hôm nay là thứ {dayName}");
                    break;
                default:
                    dayName = "Sai cú pháp vui lòng nhập từ 1-7";
                    Console.WriteLine(dayName);
                    break;
            }
        }

        public static void ex4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thứ 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số bạn đã nhập là{a}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{a}*{i}={a * i}");
            }
        }

        public static void Main(string[] args)
        {

        }
    }
}