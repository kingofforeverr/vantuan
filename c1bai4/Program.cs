// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int n;
//         Console.WriteLine("Nhap so doi bong: ");
//         n = int.Parse(Console.ReadLine());

//         int[,] A = new int[n,n];

//         // Nhập dữ liệu
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 A[i,j] = int.Parse(Console.ReadLine());
//             }
//         }

//         // a) Tính và in ra các đội có điểm lớn nhất
//         int[] points = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if (i != j)
//                 {
//                     points[i] += A[i,j];
//                 }
//             }
//         }

//         int maxPoints = 0;
//         for (int i = 0; i < n; i++)
//         {
//             if (points[i] > maxPoints)
//             {
//                 maxPoints = points[i];
//             }
//         }

//         Console.Write("doi co diem so lon nhat: ");
//         for (int i = 0; i < n; i++)
//         {
//             if (points[i] == maxPoints)
//             {
//                 Console.Write("doi " + (i + 1));
//             }
//         }

//         // b) In ra các đội có số trận thắng nhiều hơn thua
//         Console.WriteLine("doi co so tran thang nhieu hon tran thua: ");
//         for (int i = 0; i < n; i++)
//         {
//             int wins = 0, losses = 0;
//             for (int j = 0; j < n; j++)
//             {
//                 if (i != j)
//                 {
//                     if (A[i,j] == 3) wins++;
//                     else if (A[i,j] == 0) losses++;
//                 }
//             }

//             if (wins > losses)
//             {
//                 Console.WriteLine("doi " + (i + 1));
//             }
//         }

//         // c) In ra các đội không thua trận nào
//         Console.WriteLine("doi khong thua tran nao: ");
//         for (int i = 0; i < n; i++)
//         {
//             bool undefeated = true;
//             for (int j = 0; j < n; j++)
//             {
//                 if (i != j && A[i,j] == 0)
//                 {
//                     undefeated = false;
//                     break;
//                 }
//             }

//             if (undefeated)
//             {
//                 Console.WriteLine("doi " + (i + 1));
//             }
//         }
//     }
// }
