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

/*
Nome do Programa: Arrays - DS
Desenvolvido por: Diego Paraguai de Carvalho 
Data de Criacao: 2024-03-07 
Objetivo: Reverse an array of integers
*/

/*
Sample Input
4
1 4 3 2

Sample Output
2 3 4 1
*/

class Result
{

    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> reverseArray(List<int> a)
    {
        // Metodo 01
        // List <int> b = new List <int> ();
        
        // for (int i = (a.Count-1) ; i > -1 ; i--)
        // {
        //     b.Add(a [i]);
        // }
        
        // return b;
        
        
        // Metodo 02;
        a.Reverse();
        return a;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> res = Result.reverseArray(arr);

        textWriter.WriteLine(String.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
