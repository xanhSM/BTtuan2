using System;

namespace LAB2
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Hàm tính tổng các phần tử trong mảng
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến n
            int n;

            // Nhập giá trị cho biến n
            Console.Write("Nhập số phần tử n: ");
            n = int.Parse(Console.ReadLine());

            // Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];

            // Gọi hàm nhập mảng
            NhapMang(a, n);

            // Gọi hàm tính tổng và hiển thị kết quả
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");
        }
    }
    //Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
    class bai1
    {
        public static int TongChan(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    tong += a[i];
                }
            }
            return tong;
        }
    }
    // Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm tra xem một số có phải là số nguyên tố hay không,
    // hiển thị chỉ số và giá trị của những phần tử là số nguyên tố trong mảng.
    class bai2
    {
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void HienThiSoNguyenTo(int[] a, int n)
        {
            Console.WriteLine("Các số nguyên tố trong mảng:");
            for (int i = 0; i < n; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    Console.WriteLine($"Chỉ số: {i}, Giá trị: {a[i]}");
                }
            }
        }
    }
    //Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập từ bàn phím.
    class bai3
    {
        public static void DemSoAmDuong(int[] a, int n)
        {
            int demAm = 0, demDuong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    demAm++;
                }
                else if (a[i] > 0)
                {
                    demDuong++;
                }
            }
            Console.WriteLine($"Số lượng số âm: {demAm}");
            Console.WriteLine($"Số lượng số dương: {demDuong}");
        }
    }
    //Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
    class bai4
    {
        public static int TimSoLonThucHai(int[] a, int n)
        {
            if (n < 2) throw new ArgumentException("Mảng phải có ít nhất 2 phần tử.");
            int max1 = int.MinValue, max2 = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }
                else if (a[i] > max2 && a[i] != max1)
                {
                    max2 = a[i];
                }
            }
            return max2;
        }
    }
    //Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
    class bai5
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    //Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
    class bai6
    {
        public static void SapXepTangDan(float[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        float temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
