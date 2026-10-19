
using System;

namespace CTDLGT_Buoi2_BoSung_33254020040.bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>();

            Console.WriteLine("=== THEM CAC SO TU 1 DEN 10 ===");

            for (int i = 1; i <= 10; i++)
            {
                arr.Add(i);

                Console.WriteLine(
                    $"Them {i}: Count = {arr.Count}, " +
                    $"Capacity = {arr.Capacity}");
            }

            // In cac phan tu
            Console.WriteLine("\n=== CAC PHAN TU ===");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // Doc phan tu qua indexer
            Console.WriteLine("\n\narr[2] = " + arr[2]);

            // Cap nhat phan tu
            arr[2] = 100;

            Console.WriteLine("Sau khi sua arr[2] = 100:");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // Kiem tra index khong hop le
            Console.WriteLine("\n\n=== KIEM TRA INDEX ===");

            try
            {
                Console.WriteLine(arr[-1]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index am: khong hop le!");
            }

            try
            {
                Console.WriteLine(arr[arr.Count]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index bang Count: khong hop le!");
            }

            Console.ReadKey();
        }
    }
}
