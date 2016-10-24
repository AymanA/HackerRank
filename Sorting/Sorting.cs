using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Sorting
{
    class Sorting
    {
        #region AllSorting techniques

        //public static void displayElements(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //        Console.Write(arr[i] + " ");
        //    Console.WriteLine();
        //}

        //sorting starting from the end to the start 
        //static void insertionSort(int[] array)
        //{

        //    int temp;

        //    for (int i = array.Length -1; i >0; i--)
        //    {
        //        for (int d = i; d > 0; d--)
        //        {
        //            if (array[d] < array[d - 1])
        //            {
        //                temp = array[d];
        //                array[d] = array[d - 1];
        //                array[d - 1] = temp;
        //                displayElements(array);
        //            }
        //        }
        //    }
        //}


        //sorting in sequence
        //static void insertionSort(int[] array)
        //{

        //    int temp;

        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        for (int d = i; d > 0; d--)
        //        {
        //            if (array[d] < array[d - 1])
        //            {
        //                temp = array[d];
        //                array[d] = array[d - 1];
        //                array[d - 1] = temp;
        //                displayElements(array);
        //            }
        //        }
        //    }
        //}

        #endregion


        #region Insertion_Sort - Part 1

        //void PrintArray(int[] a)
        //{
        //    foreach (int n in a)
        //    {
        //        Console.Write("{0} ", n);
        //    }
        //    Console.WriteLine();
        //}





        //static void insertionSort(int[] array)
        //{

        //    int temp = array[array.Length - 1];
        //    int i = array.Length - 2;

        //    while (i>=0 && array[i]>temp)
        //    {
        //        array[i + 1] = array[i];
        //        i--;
        //        displayElements(array);
        //    }

        //    array[i + 1] = temp;
        //    displayElements(array);
        //}

        //public static void displayElements(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine();
        //}
        ////    }
        ///* Tail starts here */
        //static void Main(String[] args) {

        //        int _ar_size;
        //        _ar_size = Convert.ToInt32(Console.ReadLine());
        //        int[] _ar = new int[_ar_size];
        //        String elements = Console.ReadLine();
        //        String[] split_elements = elements.Split(' ');
        //        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        //        {
        //            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        //        }

        //        insertionSort(_ar);
        //    }





        #endregion


        #region Insertion_Sort-Part2


        //public static void displayElements(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //        Console.Write(arr[i] + " ");
        //    Console.WriteLine();
        //}

        //static void insertionSort(int[] array)
        //{

        //    int temp;

        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        for (int d = 0; d < i; d++)
        //        {
        //            if (array[i] < array[d])
        //            {
                       
        //                temp = array[d];
        //                array[d] = array[i];
        //                array[i] = temp;
                        

        //            }
                
        //        }
        //        displayElements(array);
        //    }
        //}

        //static void Main(String[] args)
        //{

        //    int _ar_size;
        //    _ar_size = Convert.ToInt32(Console.ReadLine());
        //    int[] _ar = new int[_ar_size];
        //    String elements = Console.ReadLine();
        //    String[] split_elements = elements.Split(' ');
        //    for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        //    {
        //        _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        //    }

        //    insertionSort(_ar);
        //}
    

    #endregion


}
}
