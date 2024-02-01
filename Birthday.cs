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
Sample Input 0
5
1 2 1 3 2
3 2

Sample Output 0
2

Function Description:
Complete the birthday function in the editor below.

birthday has the following parameter(s):
int s[n]: the numbers on each of the squares of chocolate
int d: Ron's birth day
int m: Ron's birth month

Returns:
int: the number of ways the bar can be divided
*/
class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int count = s.Count - m + 1; // armazena o contador até a ultima posicao possivel
        int sum = 0; // armazena a soma das posicoes de 0 ate "m"
        int square = 0; // armazena a soma de quadrados de chocolate
        for (int j = 0 ; j < count ; j++) // comecando da posicao 0 ate a posicao final menos "m"
        {
            for (int i = j ; i < j+m ; i++) // soma o valor da posicao 0 ate a posicao "m"
            {
                sum = sum + s[i];
            }
            if (sum == d) // verifica se a soma de 0 ate "m" e igual a "d"
            {
                square++;
            }
            sum = 0; // zera a soma para iniciar novamente as somas da proxima posicao
        }
        return square;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
