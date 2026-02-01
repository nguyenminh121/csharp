using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithArray
{
    internal class Program
    {
        static void bai01()
        {
            Console.Write("Nhap so luong phan tu n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }

            Console.WriteLine("Tong phan tu trong mang la: " + sum);
        }
        static void bai02()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int avg = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                avg += a[i];
            }
            int max = a.Max();
            int min = a.Min();
            avg = avg / n;
            Console.WriteLine("Gia tri lon nhat trong mang la: " + max);
            Console.WriteLine("Gia tri nho nhat trong mang la: " + min);
            Console.WriteLine("Gia tri trung binh trong mang la: " + avg);
        }
        static void bai03()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int k = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] == k)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Phan tu " + k + " xuat hien " + count + " lan trong mang.");
            }
            else
            {
                Console.WriteLine("Phan tu " + k + " khong xuat hien trong mang.");
            }
        }
        static void bai04()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int k = Convert.ToInt32(Console.ReadLine());
            int pos = -1;
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] == k && pos == -1)
                {
                    pos = i;
                }
            }
            Console.WriteLine("Vi tri dau tien cua phan tu " + k + " trong mang la: " + pos);
        }
        static void bai05()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int k = Convert.ToInt32(Console.ReadLine());
            int pos = -1;
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] == k)
                {
                    pos = i;
                }
            }
            Console.WriteLine("Vi tri cuoi cung cua phan tu " + k + " trong mang la: " + pos);
        }
        static void bai06()
        {
            Console.Write("Nhap so phan tu n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.Write("Nhap so k can tim: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a[{i}]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == k)
                {
                    count++;
                }
            }
            Console.WriteLine($"Phan tu {k} xuat hien {count} lan.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("15 Bai thuc hanh ve Mang trong C#");
            bai06();
        }
    }
}