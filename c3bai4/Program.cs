using System;

namespace Triangle
{
    public class Triangle
    {
        public int a ;
        public int b ;
        public int c ;

        public Triangle() { }

        ~Triangle() { }

        public void Nhap()
        {
            #nullable disable
            Console.WriteLine("Nhap canh a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap canh b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap canh c:");
            c = int.Parse(Console.ReadLine());
            #nullable restore
        }

        public void Xuat()
        {
            Console.WriteLine($"Canh a: {a}, Canh b: {b}, Canh c: {c}");
        }

        public bool KiemTraTamGiac()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public void Tinh()
        {
            if (!KiemTraTamGiac())
            {
                Console.WriteLine("Khong hop le");
                return;
            }
            int chuvi = a + b + c;
            double p = chuvi / 2.0;
            double DienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Chu vi: {chuvi}");
            Console.WriteLine($"Dien tich: {DienTich}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            while (true)
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1. Nhap cac canh a, b, c");
                Console.WriteLine("2. Tinh chu vi và dien tich");
                Console.WriteLine("3. Xuat gia tri a, b, c");
                Console.WriteLine("0. Thoat");
                #nullable disable
                int choice = int.Parse(Console.ReadLine());
                #nullable restore

                switch (choice)
                {
                    case 1:
                        triangle.Nhap();
                        break;
                    case 2:
                        triangle.Tinh();
                        break;
                    case 3:
                        triangle.Xuat();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}