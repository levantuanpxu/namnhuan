using System;

namespace kt_nam_nhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int years;
            Console.Write("Nhập năm muốn kiểm tra : ");
            years = Convert.ToInt32(Console.ReadLine());

            if (years % 400 == 0 && years % 100 == 0)
            {
                Console.Write("Năm {0} là năm Nhuận ", years);
            }
            else
            {
                Console.Write("Năm {0} không phải là năm Nhuận ", years);
            }


            Console.ReadLine();
        }
    }
}