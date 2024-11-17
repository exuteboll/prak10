using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В одномерном массиве из 8 целых чисел с явной инициализацией обнулить значения трех элементов, начиная с индекса, равного 1.
            //int[] omas = new int[8];
            //Random r = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = r.Next(0, 99);
            //    Console.WriteLine($"{omas[i]}");

            //}
            //Console.WriteLine("Новый массив");

            //Console.WriteLine($"{omas[0]}");
            //for (int i = 1; i <= 3; i++)
            //{

            //    omas[i] = 0;
            //    Console.WriteLine($"{omas[i]}");

            //}

            //for (int i = 4; i < omas.Length; i++)
            //{

            //    Console.WriteLine($"{omas[i]}");

            //}
            //Console.ReadKey();

            // Задача 2. Изменить размер одномерного массива.
            //int[] omas = new int[8];
            //Random r = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = r.Next(0, 99);
            //    Console.WriteLine($"{omas[i]}");

            //}
            //Console.WriteLine("mas2");
            //Array.Resize(ref omas, 10);
            //for (int i = 0; i < omas.Length; i++)
            //{
               
            //    Console.WriteLine($"{omas[i]}");

            //}
            //Console.ReadKey();

            // Задача 3. Найти индекс первого отрицательного элемента одномерного массива, заполненного случайным образом в диапазоне от -5 до 5.
            //int[] omas = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = r.Next(-5, 6);
            //    Console.WriteLine($"omas{i} = {omas[i]}");

            //}
            //int y = Array.FindIndex(omas, x => x < 0);
            //Console.WriteLine(y != -1 ? $"Индекс первого отрицательного элемента: индекс массимва ={y} {omas[y]}": "");
            //Console.ReadKey();
        }
    }
}
