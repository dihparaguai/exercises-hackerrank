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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
    int sumDiagonalE = 0, sumDiagonalD = 0, difference = 0, length = arr.Count;
    
    // Diagonal Esquerda para Direita
    for (int i = 0; i < length; i++)
    {
        // todas as posicoes lin e con iguais, serao somadas
        sumDiagonalE += arr[i][i]; // [0][0], [1][1], [2][2]
    }

    // Diagonal Direita para Esquerda
    // "for" com "dois indice" e "uma condicao"
    for (int i = 0, j = length - 1; i < length; i++, j--) // atribui a "j" a ultima posicao
    {
        // todas as posicoes da diagonal direita ja somadas
        sumDiagonalD += arr[i][j];  //[0][2] , [1][1], [2][0]
    }

    difference = Math.Abs(sumDiagonalD - sumDiagonalE); // funcao que retorna um valor positivo apos a soma
    return difference;        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
