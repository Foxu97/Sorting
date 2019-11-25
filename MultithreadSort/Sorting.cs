using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MultithreadSort
{
    static class Sorting
    {
        private static Stopwatch stopWatch = new Stopwatch();
        private static String elapsedTime; 
        public static void Bubblesort()
        {
            int min = 0;
            int max = 1000000;
            int[] originalArray = new int[100000];
            Random randNum = new Random();
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = randNum.Next(min, max);
            }



            int temp = 0;
            stopWatch.Start();
            for (int write = 0; write < originalArray.Length; write++)
            {
                for (int sort = 0; sort < originalArray.Length - 1; sort++)
                {
                    if (originalArray[sort] > originalArray[sort + 1])
                    {
                        temp = originalArray[sort + 1];
                        originalArray[sort + 1] = originalArray[sort];
                        originalArray[sort] = temp;
                    }
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            elapsedTime = String.Format("BubbleSort: {0:00}h:{1:00}m:{2:00}s.{3:00}ms",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Bubble sort elapsed time " + elapsedTime);

            stopWatch.Reset();
            //return elapsedTime;
        }
        public static String Insertsort(int[] arr) {
            stopWatch.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            elapsedTime = String.Format("InsertSort: {0:00}h:{1:00}m:{2:00}s.{3:00}ms",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            //Console.WriteLine("Insert sort elapsed time " + elapsedTime);
            stopWatch.Reset();
            return elapsedTime;
        }
        public static String Shellsort(int[] arr)
        {
            stopWatch.Start();
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            elapsedTime = String.Format("ShellSort: {0:00}h:{1:00}m:{2:00}s.{3:00}ms",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            stopWatch.Reset();
            return elapsedTime;
        }

        public static String getElapsedTime()
        {
            return elapsedTime;
        }
    }
}
