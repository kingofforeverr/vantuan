using System;

namespace SimpleCal
{
    class Program
    {
        static double a, b;
        static char toanTu;

        static void Nhap()
        {
            Console.Write("a=");
            // a = double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(),out a);


            Console.Write("b=");
            // b = double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(),out b);


            Console.Write("Toan tu (+, -, *, /): ");
            toanTu = Console.ReadKey().KeyChar;
            Console.WriteLine();  
        }

        static void ThucHien()
        {
            double result;
            switch (toanTu)
            {
                case '+':
                    result = a + b;
                    InKQ(result);
                    break;
                case '-':
                    result = a - b;
                    InKQ(result);
                    break;
                case '*':
                    result = a * b;
                    InKQ(result);
                    break;
                case '/':
                    if (b != 0)
                    {
                        result = a / b;
                        InKQ(result);
                    }
                    else
                    {
                        Console.WriteLine("Loi: Khong the chia cho 0!");
                    }
                    break;
                default:
                    Console.WriteLine("Toan tu khong hop le.");
                    break;
            }
        }
        static void InKQ(double result)
        {
            Console.WriteLine($"Ket qua: {a} {toanTu} {b} = {result}");
        }
         static void Main(string[] args)
        {
            char choice;
            do
            {
                Nhap();
                ThucHien();
                Console.Write("Tiep tuc: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (choice != 'T' && choice != 't');
        }
    }    
}
