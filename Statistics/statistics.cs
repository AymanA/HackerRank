using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.allSolutions.Statistics
{
    class statistics
    {
        #region Day0_Mean_Median_Mode
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter total number of elements :");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    if (n >= 10 && 2500 >= n)
        //    {
        //        int[] items = new int[n];

        //        Console.WriteLine("Enter Values in Array");
        //        for (int i = 0; i < n; i++)
        //        {
        //            Console.WriteLine("Enter Value at index " + i.ToString());
        //            int value = Convert.ToInt32(Console.ReadLine());
        //            if (value > 0)
        //                items[i] = Convert.ToInt32(value);
        //            else
        //            {
        //                throw new Exception("value should be greater than 0");
        //            }

        //        }



        //        Console.WriteLine(getMean(items));
        //        Console.WriteLine(getMedian(items));
        //        Console.WriteLine(getMode(items));

        //        Console.ReadLine();
        //    }
        //    else
        //        Console.WriteLine("Total elements should be greater than 10 And less than 2500.");
        //    Console.ReadLine();



        //}

        ///// <summary>
        ///// Average
        ///// </summary>
        //public static decimal getMean(int[] items)
        //{
        //    int count = items.Length;
        //    return ((decimal)items.Sum() / count);

        //}


        ///// <summary>
        ///// Medium / center value (after sorting list), if more than 1 than select two center values and sum it & divide it by 2
        ///// </summary>
        //public static decimal getMedian(int[] items)
        //{
        //    // Sort the array
        //    Array.Sort(items);
        //    //get the items count in array
        //    int count = items.Count();

        //    if (count % 2 != 0)
        //    {
        //        int index = (count - 1) / 2 + 1;
        //        return (decimal)items[index];
        //    }
        //    else
        //    {
        //        return (decimal)(items[(count / 2) - 1] + (items[(count / 2)])) / 2;
        //    }

        //}


        ///// <summary>
        ///// Maximum occurrence in the list (sorted), if no then all the numbers will be Mode. (In this particular problem, we will have to show minimum mode)
        ///// </summary>
        //public static int getMode(int[] items)
        //{
        //    Array.Sort(items);
        //    return items.GroupBy(n => n).OrderByDescending(m => m.Count()).ThenBy(m => m.Key).FirstOrDefault().Key;
        //}



        //static decimal Mean(int[] a)
        //{
        //   decimal test =  (decimal)a.Sum();
        //    //return (((decimal)a.Sum()) / a.Length);
        //    //return (decimal)test/a.Length;
        //    return test/a.Length;
        //}
        //static decimal Median(int[] a)
        //{
        //    Array.Sort(a);

        //    int count = a.Count();

        //    if (count % 2 != 0)
        //    {
        //        int index = (count - 1) / 2 + 1;
        //        return (decimal)a[index];
        //    }
        //    else
        //    {
        //        return (decimal)(a[(count / 2) - 1] + (a[(count / 2)])) / 2;
        //    }



        //}
        //static int Mode(int[] a)
        //{
        //    Array.Sort(a);

        //    return a.GroupBy(n => n).OrderByDescending(m => m.Count()).ThenBy(m => m.Key).FirstOrDefault().Key;
        //}
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    int n = int.Parse(Console.ReadLine());
        //    string[] numbers = Console.ReadLine().Split(' ');
        //    int[] nums = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        nums[i] = int.Parse(numbers[i]);
        //    }
        //    Console.WriteLine(Mean(nums));
        //    Console.WriteLine(Median(nums));
        //    Console.WriteLine(Mode(nums));

        //}

        #endregion


        #region Day0_Weighted_Mean
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        }

        #endregion
    }
}
/*
 11
64630 11735 14216 99233 14470 4978 73429 38120 51135 67060 54545
*/