using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // middle element of the list
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10};

            List<int> Firstlist_middleElements = FindMiddleElements(list1);
            List<int> Secondlist_middleElements = FindMiddleElements(list2);

            Console.WriteLine("The middle elemet of the first list is : " + string.Join(" ", Firstlist_middleElements));
            Console.ReadLine();
            Console.WriteLine("The middle elemet of the second list is : " + string.Join(" ", Secondlist_middleElements));
            Console.ReadLine();
            


            // Largest int in the list

            List<int> list3 = new List<int>() { 5, 6, 100, 3, 9, 10 };
            int large_number = LargestNumber(list3); ;
            Console.WriteLine($"The largest number in the list is {large_number}");
            Console.ReadLine();



        }




        static List<T> FindMiddleElements<T>(List<T> list)
        {
            List<T> middleElements = new List<T>();

            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                

                if (list.Count % 2 == 0)
                {
                    // Even-sized list
                    middleElements.Add(list[(list.Count/2) - 1]);
                    middleElements.Add(list[list.Count / 2]);
                }
                else
                {
                    // Odd-sized list
                    middleElements.Add(list[list.Count / 2]);
                }
            }

            return middleElements;
        }


        static int LargestNumber(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("The list is empty. Cannot find the largest number.");
            }

            int largestNumber = int.MinValue;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }
            }

            return largestNumber;
        }
    }
}
