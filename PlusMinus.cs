using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
double pos = 0, neg = 0, zer = 0, count = arr.Count;
       
       for (int i = 0 ; i < count ; i++)
       {
           switch (arr[i])
           {
               case > 0 : pos ++;
               break;
               
               case < 0 : neg --;
               break;
               
               default : zer ++;
               break;
           }
       }
        pos = Math.Abs(pos/count);
        neg = Math.Abs(neg/count);
        zer = Math.Abs(zer/count);
          
        Console.WriteLine($"{pos.ToString("N6")}\n{neg.ToString("N6")}\n{zer.ToString("N6")}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
