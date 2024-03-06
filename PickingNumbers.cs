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
Nome do Programa: Picking Numbers

Desenvolvido por: Diego Paraguai de Carvalho 

Data de Criacao: 2024-03-06 

Objetivo: Given an array of integers, find the longest subarray where the absolute difference between any two elements is less than or equal to 1.
*/


/*
Sample Input 1
6
1 2 2 3 1 2

Sample Output 1
5
*/

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        // Guardar todos os numeros distintos
        // para cada numero, verificar quantos possuem no array com diferenca ate 1
        List<int> aDist = a.Distinct().ToList();
        int countMax = 0;

        // Itera sobre a lista de numeros distintos
        for (int i = 0; i < aDist.Count; i++)
        {
            int countMenor = 0;
            int countMaior = 0;

            // Itera sobre a lista original de inteiros
            for (int j = 0; j < a.Count; j++)
            {
                // Verifica se a diferenca entre o numero distinto e o numero original e 1 ou 0
                if ((aDist[i] - a[j] == 1) || (aDist[i] - a[j] == 0))
                {
                    countMenor++;
                }
                // Verifica se a diferenca entre o numero distinto e o numero original e -1 ou 0
                else if ((aDist[i] - a[j] == -1 || aDist[i] - a[j] == 0))
                {
                    countMaior++;
                }
            }

            // Atualiza o contador maximo com o valor maximo entre countMenor e countMaior
            if (countMenor > countMax)
            {
                countMax = countMenor;
            }
            else if (countMaior > countMax)
            {
                countMax = countMaior;
            }
        }
        return countMax;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
