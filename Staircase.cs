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
        Sample Input
        6 
        
        Sample Output
             #
            ##
           ###
          ####
         #####
        ######
    */

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        string cerquilha;
        string espaco;
        for (int i = 1; i <= n ; i++)
        {
            cerquilha = string.Empty.PadLeft(i, '#'); // cria cerquilhas
            espaco = string.Empty.PadLeft((n-i), ' '); // cria espacos
            Console.WriteLine($"{espaco}{cerquilha}"); // junta cerquilhas e espaços
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
