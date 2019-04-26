using System;
using System.Collections.Generic;
using System.Globalization;
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
            int[,] array2 = new int[3, 3] {{1, 4, 3}, {9, 3, 6}, {15, 8, 15}};
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
            int[] array3 = new int[5];
            Console.WriteLine("Enter your array:");
            for (int i = 0; i < 5; i++)
            {
                array3[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Received array:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3.Length - 1 - i; j++)
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
                Console.Write(array3[i] + " ");
            }
        }

        public static void B6_P4_6_Pyatnashki()
        {
            Console.WriteLine("Source array:");
            int[,] arrayForPyatnashki=SourceArrayForPyatnashki();
            Console.WriteLine("Use wasd for moving 0");
            while (true)
            {
                MoveArrayForPyatnashki(arrayForPyatnashki);
                Console.WriteLine("Current array:");
                printArray(MoveArrayForPyatnashki(arrayForPyatnashki));
            }
        }

        //метод который создает массив с уникальными значениями от 0 до 8
        private static int[,] SourceArrayForPyatnashki()
        {
            var nums = Enumerable.Range(0, 9).ToArray();
            var rand = new Random();
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rand.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }

            int count = 0;
            for (int i = 0; i < Convert.ToInt32(Math.Sqrt(nums.Length)); ++i)
            {
                for (int j = 0; j < Convert.ToInt32(Math.Sqrt(nums.Length)); j++)
                {
                    Console.Write(nums[count]);
                    count++;
                }
                Console.WriteLine();
            }

            int[,] array4 = new int[3, 3];
            count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array4[i, j] = nums[count];
                    count++;
                }
            }
            return array4;
        }
        //метод перемещения пустого значени(0)
        private static int[,] MoveArrayForPyatnashki(int[,] array4)
        {
            int[,] array5 = array4;
            int[] position0 = new int[2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array5[i, j] == 0)
                    {
                        position0[0] = i;
                        position0[1] = j;
                    }
                }
            }

            switch (Console.ReadLine())
            {
                case "w":
                {
                    if (position0[0] > 0)
                    {
                        int tmp = array5[position0[0] - 1, position0[1]];
                        array5[position0[0] - 1, position0[1]] = 0;
                        array5[position0[0], position0[1]] = tmp;
                    }
                    break;
                }
                case "s":
                {
                    if (position0[0] < 2)
                    {
                        int tmp = array5[position0[0] + 1, position0[1]];
                        array5[position0[0] + 1, position0[1]] = 0;
                        array5[position0[0], position0[1]] = tmp;
                    }
                    break;
                }
                case "a":
                {
                    if (position0[1] > 0)
                    {
                        int tmp = array5[position0[0], position0[1] - 1];
                        array5[position0[0], position0[1] - 1] = 0;
                        array5[position0[0], position0[1]] = tmp;
                    }
                    break;
                }
                case "d":
                {
                    if (position0[1] < 2)
                    {
                        int tmp = array5[position0[0], position0[1] + 1];
                        array5[position0[0], position0[1] + 1] = 0;
                        array5[position0[0], position0[1]] = tmp;
                    }
                    break;
                }
            }
            return array5;
        }
        //метод вывода полученного массива
        private static int[,] printArray(int[,] array6)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array6[i, j]}");
                }
                Console.WriteLine();
            }
            return array6;
        }

        public static void B6_P5_6_CutString()
        {
            Console.WriteLine("Enter the sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence.Remove(13,(sentence.Length-13))+"...");


           // int numberOfLetters = sentence.Length;
            //if (numberOfLetters > 13)
            //{
              //  for (int i = 0; i < 13; i++)
                //{
                  //  Console.Write(sentence[i]);
                //}
                //Console.Write("...");
            //}
        }

        public static void B6_P6_6_ReplaceInPoem()
        {
            Console.WriteLine("Enter the poem line by line separating the lines using semicolon(;)");
            string poem = Console.ReadLine();
            string[] linesOfPoem = poem.Split(';');
            for (int i = 0; i < linesOfPoem.Length; i++)
            {
                linesOfPoem[i] = linesOfPoem[i].Replace('о', 'а');
                linesOfPoem[i] = linesOfPoem[i].Replace("л", "ль");
                linesOfPoem[i] = linesOfPoem[i].Replace("ть", "т");
                linesOfPoem[i] = linesOfPoem[i].Replace('О', 'А');
                linesOfPoem[i] = linesOfPoem[i].Replace("Л", "Ль");
                linesOfPoem[i] = linesOfPoem[i].Replace("Ть", "Т");
                Console.WriteLine(linesOfPoem[i]);
            }


        }
    }
}