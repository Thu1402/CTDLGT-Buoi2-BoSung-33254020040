using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi2_BoSung_33254020040.bai2
{

    using System;

    public class Program
    {
        // Chèn value vào vị trí index trong mảng
        static void Insert(int[] data, ref int count, int index, int value)
        {
            // Kiểm tra chỉ số chèn từ 0 đến count
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            // Kiểm tra mảng có trống không
            if (count == data.Length)
            {
                throw new InvalidOperationException("Mảng đã đầy!");
            }

            // Dịch các phần tử sang phải, bắt đầu từ cuối mảng
            for (int i = count; i > index; i--)
            {
                data[i] = data[i - 1];
            }

            // Gán giá trị mới vào vị trí cần chèn
            data[index] = value;

            // Tăng số phần tử hợp lệ sau khi chèn
            count++;
        }

        // Xóa phần tử tại vị trí index
        static void RemoveAt(int[] data, ref int count, int index)
        {
            // Kiểm tra chỉ số xóa: từ 0 đến count - 1
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            // Dịch các phần tử bên phải sang trái để lấp chỗ trống
            for (int i = index; i < count - 1; i++)
            {
                data[i] = data[i + 1];
            }

            // Giảm số phần tử hợp lệ sau khi xóa
            count--;
        }

        // In các phần tử hợp lệ của mảng
        static void PrintArray(int[] data, int count)
        {
            Console.Write("[");
            for (int i = 0; i < count; i++)
            {
                Console.Write(data[i]);
                if (i < count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        static void Main333(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Mảng có 8 ô, nhưng chỉ có 5 phần tử hợp lệ
            int[] data = new int[8] { 4, 7, 2, 9, 5, 0, 0, 0 };
            int count = 5;

            Console.WriteLine("Mảng ban đầu:");
            PrintArray(data, count);

            // Chèn 99 tại index 2
            Insert(data, ref count, 2, 99);
            Console.WriteLine("Sau khi chèn 99 tại index 2:");
            PrintArray(data, count);

            // Xóa phần tử tại index 1
            RemoveAt(data, ref count, 1);
            Console.WriteLine("Sau khi xóa tại index 1:");
            PrintArray(data, count);

            Console.WriteLine("Chèn tại đầu");
            Insert(data, ref count, 0, 10);
            PrintArray(data, count);

            Console.WriteLine("Chèn tại cuối");
            Insert(data, ref count, count, 20);
            PrintArray(data, count);

            Console.WriteLine("Xóa phần tử đầu");
            RemoveAt(data, ref count, 0);
            PrintArray(data, count);

            Console.WriteLine("Xóa phần tử cuối");
            RemoveAt(data, ref count, count - 1);
            PrintArray(data, count);
        }
    }

}
