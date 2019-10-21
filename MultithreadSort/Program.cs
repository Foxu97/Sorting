using System;

namespace MultithreadSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 1000000;
            int[] originalArray = new int[100000];
            Random randNum = new Random();
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = randNum.Next(min, max);
            }

            Console.WriteLine("Sortowanie " + originalArray.Length + " elementow z zakresu " + min + " - " + max);



            int[] copiedArr = (int[])originalArray.Clone();
            int[] copiedArr0 = (int[])originalArray.Clone();
            int[] copiedArr1 = (int[])originalArray.Clone();
            int[] copiedArr2 = (int[])originalArray.Clone();

            string bubbleSortedElapsedTime = Sorting.Bubblesort(copiedArr);
            Console.WriteLine(bubbleSortedElapsedTime);

            string insertSortedElapsedTime = Sorting.Insertsort(copiedArr0);
            Console.WriteLine(insertSortedElapsedTime);

            string shellSortElapsedTime = Sorting.Shellsort(copiedArr1);
            Console.WriteLine(shellSortElapsedTime);





            Console.ReadKey();
        }
    }
}
