using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi2_BoSung_33254020040.bai1
{
    public class bài1
    {
        static void Main22(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử n: ");
            //Cho nhập n kiểu số nguyên từ bàn phím
            int n = int.Parse(Console.ReadLine());

            //ràng buộc phạm vi phần tử n
            if (n < 1 || n > 100000)
            {
                Console.WriteLine("n phải từ 1 đến 100000");
                return;
            }

            //tạo mảng gồm n phần tử và gắn mảng đó là a
            int[] a = new int[n];

            // Nhập mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine()?? "");
            }

            // khởi tạo biến nhỏ nhất min và lớn nhất max
            int min = a[0];
            int max = a[0];

            //dùng kiểu long cho biến tổng sum
            long sum = 0;

            //gán cho đếm số phần tử âm
            int negative = 0;

            //gán cho đếm số phần tử dương
            int positive = 0;

            //gán cho đếm số phần tử bằng 0
            int zero = 0;

            // Thống kê mảng cho duyệt đúng một lần
            for (int i = 0; i < n; i++)
            {
                //sum được công tăng dần các phần tử i trong mảng a
                sum += a[i];

                //tìm giá trị nhỏ nhất và gán cho min phần tử đó
                if (a[i] < min)
                    min = a[i];

                //tìm giá trị lớn nhất và gán cho max phần tử đó
                if (a[i] > max)
                    max = a[i];

                //đếm số phần tử âm, dương và 0
                if (a[i] < 0)
                    negative++;
                else if (a[i] > 0)
                    positive++;
                else
                    zero++;
            }

            //trả về trung bình của n phần tử
            double average = (double)sum / n;

            Console.WriteLine("\n--- KET QUA THONG KE ---");
            Console.WriteLine($"Tong: {sum}");
            Console.WriteLine($"Gia tri nho nhat: {min}");
            Console.WriteLine($"Gia tri lon nhat: {max}");
            Console.WriteLine($"Trung binh cong: {average:F2}");
            Console.WriteLine($"So phan tu am: {negative}");
            Console.WriteLine($"So phan tu duong: {positive}");
            Console.WriteLine($"So phan tu bang 0: {zero}");

            // Đảo mảng với hai chỉ số left và right
            int left = 0;
            int right = n - 1;

            //điều kiện việc đảo mảng, liên tục đổi chỗ nếu left nhỏ hơn right
            while (left < right)
            {
                //lưu tạm giá trị left để không mất chỗ
                int temp = a[left];

                //đưa giá trị phải sang trái
                a[left] = a[right];
                //đưa gía trị đã lưu vào bên phải
                a[right] = temp;

                //left dịch sang phải 1 vị trí, right dịch sang trái 1 vị trí
                left++;
                right--;
            }

            // In mảng sau khi đảo
            Console.WriteLine("\n--- MẢNG SAU KHI ĐẢO ---");

            //lặp vòng in các phẩn tử ra màn hình
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("");
        }
    }

}

