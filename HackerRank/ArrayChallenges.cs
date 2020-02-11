using System;
using System.Collections.Generic;


namespace HackerRank
{
    public class ArrayChallenges
    {

        //Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
        public static void SockMerchant(string str)
        {
            int oneNum;
            List<int> nums = new List<int>();
            string[] tokens = str.Split(",");

            foreach (string s in tokens)
            {
                    oneNum =  Int32.Parse(s);
                    nums.Add(oneNum);
            }

            int[] numArr = nums.ToArray();

           
        }








    }
}
