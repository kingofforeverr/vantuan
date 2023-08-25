using System;
using System.Linq;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            // int n = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out int n);
            double[] A = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                // A[i] = double.Parse(Console.ReadLine());
                double.TryParse(Console.ReadLine(), out A[i]);
            }

            // a) Tổng giá trị tuyệt đối các phần tử âm của mảng
            // double tong = A.Where(x => x < 0).Sum(x => Math.Abs(x));
            double tong = A.Where(x => x <0).Sum(x => Math.Abs(x));
            
            // double tich = A.Where(x => x < 0).Aggregate(1.0, (acc, value) => acc * value);

            // b) Tích của các phần tử nằm giữa phần tử tối đa và phần tử tối thiểu của mảng
            double max = A.Max();
            double min = A.Min();
            int idxMax = Array.IndexOf(A, max);
            int idxMin = Array.IndexOf(A, min);
            double tich = 1;

            if (Math.Abs(idxMax - idxMin) > 1)
            {
                if (idxMax > idxMin)
                {
                    for (int i = idxMin + 1; i < idxMax; i++)
                    {
                        tich *= A[i];
                    }
                }
                else
                {
                    for (int i = idxMax + 1; i < idxMin; i++)
                    {
                        tich *= A[i];
                    }
                }
            }
            else
            {
                tich = 0;  // không có phần tử nào giữa min và max
            }

            // c) Sắp xếp các phần tử của mảng theo thứ tự tăng dần
            double[] A_tang = (double[])A.Clone();
            Array.Sort(A_tang);

            // d) Lấy phần nguyên của các phần tử là số thực, sau đó sắp xếp tất cả các phần tử chẵn đứng trước (bên trái), còn các phần tử lẻ đứng sau (bên phải)
            int[] A_biendoi = A.Select(x => (int)x).ToArray();
            A_biendoi = A_biendoi.OrderByDescending(x => x % 2 == 0).ThenBy(x => x).ToArray();
            


            // Output
            Console.WriteLine($"Tong = {tong}");
            Console.WriteLine($"Tich = {tich}");
            Console.WriteLine("A_tang = " + string.Join(", ", A_tang));
            Console.WriteLine("A_biendoi = " + string.Join(", ", A_biendoi));
            Console.WriteLine(string.Join(", ", A));

        }
    }
}

