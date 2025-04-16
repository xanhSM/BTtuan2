using System;
using System.Text;

namespace LAB01
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Config Console Output được Tiếng Việt
    //        Console.OutputEncoding = Encoding.UTF8;

    //        // 1. Khai báo biến
    //        int x1, x2, y1, y2;

    //        // 2. Nhập giá trị
    //        Console.WriteLine("Nhập điểm A(x1, y1):");
    //        Console.Write("- x1: ");
    //        x1 = int.Parse(Console.ReadLine());
    //        Console.Write("- y1: ");
    //        y1 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Nhập điểm B(x2, y2):");
    //        Console.Write("- x2: ");
    //        x2 = int.Parse(Console.ReadLine());
    //        Console.Write("- y2: ");
    //        y2 = int.Parse(Console.ReadLine());

    //        // 3. Tính khoảng cách
    //        double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    //        // 4. Hiển thị kết quả
    //        Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) = {khoangCach}");
    //    }
    //}




    // Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn[tuổi] tuổi!". 

    //class bai1
    //{
    //    static void Main(int[] args)
    //    {
    //        // Config Console Output được Tiếng Việt
    //        Console.OutputEncoding = Encoding.UTF8;
    //        // 1. Khai báo biến
    //        string ten;
    //        int tuoi;
    //        // 2. Nhập giá trị
    //        Console.Write("Nhập tên của bạn: ");
    //        ten = Console.ReadLine();
    //        Console.Write("Nhập tuổi của bạn: ");
    //        tuoi = int.Parse(Console.ReadLine());
    //        // 3. Hiển thị kết quả
    //        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    //    }
    //}
    // Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
    //class bai2
    //{
    //    static void Main(float[] args)
    //    {
    //        // Config Console Output được Tiếng Việt
    //        Console.OutputEncoding = Encoding.UTF8;
    //        // 1. Khai báo biến
    //        double chieuDai, chieuRong;
    //        // 2. Nhập giá trị
    //        Console.Write("Nhập chiều dài: ");
    //        chieuDai = double.Parse(Console.ReadLine());
    //        Console.Write("Nhập chiều rộng: ");
    //        chieuRong = double.Parse(Console.ReadLine());
    //        // 3. Tính diện tích
    //        double dienTich = chieuDai * chieuRong;
    //        // 4. Hiển thị kết quả
    //        Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
    //    }
    //}
    //Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
    //class bai3
    //{
    //    static void Main(float[] args)
    //    {
    //        // Config Console Output được Tiếng Việt
    //        Console.OutputEncoding = Encoding.UTF8;
    //        // 1. Khai báo biến
    //        double doC;
    //        // 2. Nhập giá trị
    //        Console.Write("Nhập nhiệt độ (độ C): ");
    //        doC = double.Parse(Console.ReadLine());
    //        // 3. Chuyển đổi sang độ F
    //        double F = (doC * 9 / 5) + 32;
    //        // 4. Hiển thị kết quả
    //        Console.WriteLine($"Nhiệt độ {doC} độ C tương đương với {F} độ F.");
    //    }
    //}
    //Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
 class bai4
    {
        static void Main(int[] args)
        {
            // Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            // 1. Khai báo biến
            int soNguyen;
            // 2. Nhập giá trị
            Console.Write("Nhập một số nguyên: ");
            soNguyen = int.Parse(Console.ReadLine());
            // 3. Kiểm tra số chẵn hay lẻ
            if (soNguyen % 2 == 0)
            {
                Console.WriteLine($"{soNguyen} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{soNguyen} là số lẻ.");
            }
        }
    }
    //Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
 class bai5
    {
        static void Main(float[] args)
        {
            // Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            // 1. Khai báo biến
            int so1, so2;
            // 2. Nhập giá trị
            Console.Write("Nhập số thứ nhất: ");
            so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            so2 = int.Parse(Console.ReadLine());
            // 3. Tính tổng và tích
            int tong = so1 + so2;
            int tich = so1 * so2;
            // 4. Hiển thị kết quả
            Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
            Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");
        }
    }
    //Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
    class bai6
    {
        static void Main(float[] args)
        {
            // Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            // 1. Khai báo biến
            int so;
            // 2. Nhập giá trị
            Console.Write("Nhập một số: ");
            so = int.Parse(Console.ReadLine());
            // 3. Kiểm tra số dương, âm hay không
            if (so > 0)
            {
                Console.WriteLine($"{so} là số dương.");
            }
            else if (so < 0)
            {
                Console.WriteLine($"{so} là số âm.");
            }
            else
            {
                Console.WriteLine($"{so} là số không.");
            }
        }
    }

    //Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
    class bai7
    {
        static void Main(int[] args)
        {
            // Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            // 1. Khai báo biến
            int nam;
            // 2. Nhập giá trị
            Console.Write("Nhập một năm: ");
            nam = int.Parse(Console.ReadLine());
            // 3. Kiểm tra năm nhuận
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine($"{nam} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{nam} không phải là năm nhuận.");
            }
        }
    }
}