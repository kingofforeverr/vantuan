// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         double Diem_QTH;
//         double Diem_HTTTQL;
//         double Diem_CSLT;
//         double Diem_Triet;


//         Console.Write("Ho va ten: ");
//         string hoTen = Console.ReadLine().ToUpper();

//         Console.Write("Lop : ");
//         string lop = Console.ReadLine();

//         Console.Write("Diem_QTH: ");
//         // double Diem_QTH = double.Parse(Console.ReadLine());
//         double.TryParse(Console.ReadLine(),out Diem_QTH);


//         Console.Write("Diem_HTTTQL: ");
//         double.TryParse(Console.ReadLine(),out Diem_HTTTQL);

//         Console.Write("Diem_CSLT: ");
//         double.TryParse(Console.ReadLine(),out Diem_CSLT);

//         Console.Write("Diem_Triet: ");
//         double.TryParse(Console.ReadLine(),out Diem_Triet);

//         if (Diem_QTH>=8.5)
//             Diem_QTH=4;
//         else if (Diem_QTH>=8)
//             Diem_QTH=3.5;
//         else if(Diem_QTH>=7)
//             Diem_QTH=3;
//         else if(Diem_QTH>=6.5)
//             Diem_QTH=2.5;
//         else if(Diem_QTH>=5.5)
//             Diem_QTH=2;
//         else if(Diem_QTH>=5)
//             Diem_QTH=1.5;
//         else if(Diem_QTH>=4)
//             Diem_QTH=1;
//         else
//             Diem_QTH=0;
// // htttql
//         if (Diem_HTTTQL>=8.5)
//             Diem_HTTTQL=4;
//         else if (Diem_HTTTQL>=8)
//             Diem_HTTTQL=3.5;
//         else if(Diem_HTTTQL>=7)
//             Diem_HTTTQL=3;
//         else if(Diem_HTTTQL>=6.5)
//             Diem_HTTTQL=2.5;
//         else if(Diem_HTTTQL>=5.5)
//             Diem_HTTTQL=2;
//         else if(Diem_HTTTQL>=5)
//             Diem_HTTTQL=1.5;
//         else if(Diem_HTTTQL>=4)
//             Diem_HTTTQL=1;
//         else
//             Diem_HTTTQL=0;
// // co so lap trinh

//         if (Diem_CSLT>=8.5)
//             Diem_CSLT=4;
//         else if (Diem_CSLT>=8)
//             Diem_HTTTQL=3.5;
//         else if(Diem_CSLT>=7)
//             Diem_CSLT=3;
//         else if(Diem_CSLT>=6.5)
//             Diem_CSLT=2.5;
//         else if(Diem_CSLT>=5.5)
//             Diem_CSLT=2;
//         else if(Diem_CSLT>=5)
//             Diem_CSLT=1.5;
//         else if(Diem_CSLT>=4)
//             Diem_CSLT=1;
//         else
//             Diem_CSLT=0;

// // didmer triết
//         if (Diem_Triet>=8.5)
//             Diem_Triet=4;
//         else if (Diem_Triet>=8)
//             Diem_Triet=3.5;
//         else if(Diem_Triet>=7)
//             Diem_Triet=3;
//         else if(Diem_Triet>=6.5)
//             Diem_Triet=2.5;
//         else if(Diem_Triet>=5.5)
//             Diem_Triet=2;
//         else if(Diem_Triet>=5)
//             Diem_Triet=1.5;
//         else if(Diem_Triet>=4)
//             Diem_Triet=1;
//         else
//             Diem_Triet=0;
    
      
//         double gpa = (Diem_QTH*3 + Diem_HTTTQL*3 + Diem_CSLT*3 + Diem_Triet*3) / 12;

//         string xepLoai;
//         if (gpa >= 3.6)
//             xepLoai = "Xuat sac";
//         else if ( gpa >= 3.2 && gpa<3.6)
//             xepLoai = "Gioi";
//         else if (gpa<3.2 && gpa >= 2.5)
//             xepLoai = "Kha";
//         else if (gpa<2.5 && gpa >= 2)
//             xepLoai = "Trung binh";
//         else
//             xepLoai = "Yeu";

//         Console.WriteLine($"Sinh viên: {hoTen}, Lop {lop}, Dat GPA {gpa}, Xep loai: {xepLoai}");
        
//     }
// }


// cách 2
using System;
class Program
{
    static double ConvertDiemToGPA(double diem)
    {
        if (diem >= 8.5)
            return 4;
        if (diem >= 8)
            return 3.5;
        if (diem >= 7)
            return 3;
        if (diem >= 6.5)
            return 2.5;
        if (diem >= 5.5)
            return 2;
        if (diem >= 5)
            return 1.5;
        if (diem >= 4)
            return 1;
        return 0;
    }
    static double GetDiemFromInput(string subjectName)
    {
        Console.Write($"{subjectName}: ");
        double.TryParse(Console.ReadLine(), out double diem);
        return ConvertDiemToGPA(diem);
    }
    static void Main()
    {
        Console.Write("Ho va ten: ");
        // string hoTen = Console.ReadLine().ToUpper();

        Console.Write("Lop : ");
        // string lop = Console.ReadLine();
        

        double Diem_QTH = GetDiemFromInput("Diem_QTH");
        double Diem_HTTTQL = GetDiemFromInput("Diem_HTTTQL");
        double Diem_CSLT = GetDiemFromInput("Diem_CSLT");
        double Diem_Triet = GetDiemFromInput("Diem_Triet");

        double gpa = (Diem_QTH*3 + Diem_HTTTQL*3 + Diem_CSLT*3 + Diem_Triet*3) / 12;

        // string xepLoai;
        // if (gpa >= 3.6)
        //     xepLoai = "Xuat sac";
        // else if ( gpa >= 3.2 )
        //     xepLoai = "Gioi";
        // else if ( gpa >= 2.5)
        //     xepLoai = "Kha";
        // else if ( gpa >= 2)
        //     xepLoai = "Trung binh";
        // else
        //     xepLoai = "Yeu";

        // Console.WriteLine($"Sinh viên: {hoTen}, Lop {lop}, Dat GPA {gpa}, Xep loai: {xepLoai}");
    }   
}
