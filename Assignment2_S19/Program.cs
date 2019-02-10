using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey();
        }

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int count = a.Length % d;
            while (count <= d)
            {
                int temp = a[0];                      //assigning the first element in a temporary variable
                for (int i = 0; i < a.Length - 1; i++) //shift the elements to left by 1
                {
                    a[i] = a[i + 1];
                }
                a[a.Length - 1] = temp;              // storing the element in temp array 
                count = count + 1;
            }
            return a;
            return new int[] { };
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            int min; //min is used to exchange the current lowest value in the array.

            for (int i = 0; i < prices.Length; i++)
            {
                min = i; // initializing the min to current value in the array. 

                for (int x = i + 1; x < prices.Length; x++) // comparing the min and current value to find which is smaller.

                    if (prices[x] < prices[min]) //to check the next element is smaller than min value.

                        min = x; //new min value assinged, if above conditon satisfied.


                if (min != i) //exchanging the lowest number with current number. 
                {
                    int temp = prices[i];
                    prices[i] = prices[min];
                    prices[min] = temp;
                }

            }
            //selection sort ends here.

            int sum = 0; //initializing sum to assign the sum of required elements in an array.

            {
                for (int i = 0; i < prices.Length; i++)
                {
                    sum += prices[i]; // sum up the elements till the length of the array.

                    if (sum <= k) //to sum up to K number of elements in an array.
                    {
                        continue;
                    }
                    else
                    {
                        return i;
                    }
                }
            }
            Console.ReadKey();

            return 0;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            int n1 = arr.Length;
            int n2 = brr.Length;
            int[] freq = new int[50];               //created a frequency array
            freq[0] = 1;

            int firstele = brr[0];                //storing the value of the first element from the orriginal array
            for (int i = 1; i < n2; i++)         //computing the frequency of each element from original array in accordance with the first element
            {
                int diff = brr[i] - firstele;
                freq[0 + diff]++;               //incrementing the frequency
            }

            for (int i = 0; i < n1; i++)       //computing the frequency of each element from array with missing values in accordance with the first element
            {

                int diff = arr[i] - firstele;
                freq[0 + diff]--;             //decrementing the frequency
            }

            for (int i = 0; i < freq.Length; i++)  //iterate the frequency array
            {
                if (freq[i] > 0)
                    Console.Write("{0} ", firstele + (i - 0)); //print the frequency array by computing using first element from the original array
            }

            return new int[] { };
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            return new int[] { };
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            //Console.WriteLine("Sorted Array in Ascending Order");
            int l = arr.Length; //lenght of the array.
            int minpos = 0;
            // selection sort of the given array.
            for (int i = 0; i < l; i++)
            {
                minpos = i;
                for (int x = i + 1; x < l; x++)
                    if (arr[x] < arr[minpos])
                        minpos = x;
                if (minpos != i)
                {
                    int temp = arr[i]; //exchanging the higher number with the lower number.
                    arr[i] = arr[minpos];
                    arr[minpos] = temp;
                }


              //  Console.Write("  " + arr[i]); // to print the sorted array in ascending order.
            }
            {

                int M = l / 2; //to find the median location in the sorted array.
                Console.WriteLine("\n" + "Median Value:");
                return M;
            }
            //return 0;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            arr = sortedArray(arr);                           //call the sorted array method
            var minDiff = new List<int> { arr[0], arr[1] };  //creating list of numbers with minimum difference
            var diff = absValue(arr[1], arr[0]);            //call absolute method to find the absolute values of first two elements


            for (var i = 1; i < arr.Length - 1; i++)       //iterate array to find the difference between current and next elements and compare with the previous
            {
                var diff02 = absValue(arr[i], arr[i + 1]);
                if (diff02 < diff)                        // if true assign the current and next elements to the list
                {
                    diff = diff02;
                    minDiff = new List<int>() { arr[i], arr[i + 1] };
                }
                else if (diff02 == diff)                // if true add the current and next elements to the list
                {
                    minDiff.Add(arr[i]);
                    minDiff.Add(arr[i + 1]);
                }
            }
            return minDiff.ToArray();
            return new int[] { };
        }

        static int[] sortedArray(int[] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (a = 0; a < arr.Length - i - 1; a++) //check if next value is smaller than the current value, if next value is less, perform swap
                {

                    if (arr[a] > arr[a + 1])       //perform swap     
                    {
                        int temp = arr[a];
                        arr[a] = arr[a + 1];
                        arr[a + 1] = temp;
                    }
                }
            }
            return arr;
        }


        static int absValue(int a, int b) //method to compute the absolute values
        {
            var absDiff = 0;
            if ((a <= 0 && b <= 0) || (a >= 0 && b >= 0))
                absDiff = Math.Abs(Math.Abs(a) - Math.Abs(b));
            return absDiff;


            //return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            string date = "";
            if (year >= 1919)       // year greater than or equal to 1919 call the method to computeGregorianDays
            {
                date = computeGregorianDays(year);
            }
            else
                if (year <= 1917)   // year less than or equal to 1917 call the method to computeJulianDays
            {
                date = computeJulianDays(year);
            }
            else               // year equal to 1918 call the method to compute1918
            {
                date = compute1918(year);
            }
            return date;
            return "";
        }

        static bool isJulianLeap(int year) //Following the Julian Calender check leap year or not
        {
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
        static bool isGregorianLeap(int year) //Following the Gregorian Calender check leap year or not
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            return false;
        }

        static string computeGregorianDays(int year) //method to compute days as per Gregorian calendar
        {
            int noOfDays = 0;
            int programmerDateInSeptember = 0;
            int countDaysTillAug_notLeap = 243; // till august since we need to find 256th day
            int countDaysTillAug_Leap = 244;   // till august since we need to find 256th day
            DateTime date;
            string date01;
            if (isGregorianLeap(year))
            {
                programmerDateInSeptember = 256 - countDaysTillAug_Leap;
            }
            else
            {
                programmerDateInSeptember = 256 - countDaysTillAug_notLeap;
            }
            date01 = programmerDateInSeptember.ToString() + ".09." + year.ToString();
            return date01;

        }
        static string computeJulianDays(int year)   //method to compute days as per Julian calendar
        {
            int noOfDays = 0;
            int programmerDateInSeptember = 0;
            int countDaysTillAug_notLeap = 243; // till august since we need to find 256th day
            int countDaysTillAug_Leap = 244;   // till august since we need to find 256th day
            DateTime date;
            string date02;
            if (isJulianLeap(year))
            {
                programmerDateInSeptember = 256 - countDaysTillAug_Leap;
            }
            else
            {
                programmerDateInSeptember = 256 - countDaysTillAug_notLeap;
            }
            date02 = programmerDateInSeptember.ToString() + ".09." + year.ToString();
            return date02;

        }
        static string compute1918(int year)      //method to compute days if the year was 1918 that is the year of transition
        {
            string date02;
            int programmerDateInSeptember = 0;
            int countDaysTillAug_notLeap = 230; // till august since we need to find 256th day
            //int countDaysTillAug_Leap = 231;
            programmerDateInSeptember = 256 - countDaysTillAug_notLeap;
            date02 = programmerDateInSeptember.ToString() + ".09." + year.ToString(); //computing directly since 1918 is not a leap year
            return "";

            Console.ReadKey();
            return "";
        }
    }
}
