using System;
using System.Collections.Generic;


namespace HackerRank
{
    public class ArrayChallenges
    {

        //Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
        public static int[] LeftRotation(string str, int n)
        {
            int oneNum;
            List<int> nums = new List<int>();
            string[] tokens = str.Split(",");

            //convert list to an int array
            foreach (string s in tokens)
            {
                    oneNum =  Int32.Parse(s);
                    nums.Add(oneNum);
            }

            int[] numArr = nums.ToArray();

            //e.g [1,2,3,4,5]

           
            int[] temp = new int[]{ 1, 2, 4 };
            int trueShift = n - numArr.Length;

            return temp;



           
        }








    }
}
