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
using System.Numerics;


class Result
{
    /*
    Sample Input
    1 2 3 4 5
    
    Sample Output
    10 14
    */
    

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {    
        long min = long.MaxValue, max = long.MinValue; // atribui os valors maximo e minino para o tipo int
        long totalSum = 0;

        for (int i = 0; i < arr.Count; i++) // "for" para somar todos os elementos
        {
            totalSum += arr[i];
        }

        for (int i = 0; i < arr.Count; i++) // "for" para subtrair um elemento por vez e verificar qual das somas e a minina e qual e a maxima
        {
            long sum = totalSum - arr[i];

            if (sum > max)
            {
                max = sum;
            }

            if (sum < min)
            {
                min = sum;
            }
        }

        Console.WriteLine($"{min} {max}");   
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
