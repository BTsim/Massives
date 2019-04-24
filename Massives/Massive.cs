using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    public class Massive
    {
        public static void B6_P1_6_1DReadConsolemassive()
        {
            int[] array1 = new int[6];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + " of array");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Received array: ");

            for (int i = 0; i < array1.Length; i++)
            {

                Console.Write(array1[i]);

            }


        }

        public static void B6_P2_6_3DMassiveMaxInRow()
        {
            int[,] array2 = new int[3, 3] { { 1, 4, 3 }, { 9, 3, 6 }, { 15, 8, 15 } };
            int MaxRow = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array2[i, j] + "   ");
                    if (MaxRow < array2[i, j])
                    {
                        MaxRow = array2[i, j];
                    }

                }
                Console.Write("Max value in a row is " + MaxRow);
                Console.WriteLine();
            }
        }
        public static void B6_P3_6_1DMassiveSort()
        {
            int[] array3=new int[5];
            Console.WriteLine("Enter your array:");
            for (int i = 0; i < 5; i++)
            {
                array3[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Received array:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3.Length-1-i; j++)
                {
                    if (array3[j] > array3[j + 1])
                    {
                        int a = array3[j];
                        array3[j] = array3[j + 1];
                        array3[j + 1] = a;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i]+" ");
            }
        }
    }
}