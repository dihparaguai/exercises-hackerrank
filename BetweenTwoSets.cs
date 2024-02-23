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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */


    public static int getTotalX(List<int> a, List<int> b) {
        // Lista para armazenar os multiplos de 'A' e possiveis fatores de 'B'
        List<int> fatores = new List<int>();
        // Variavel para armazenar a quantidade de fatores encontrados
        int qtdFatores = 0;
        // Loop para armazenar todos os multiplos possiveis em 'A' ate o igual ou menor elemento em 'B'
        // Começa no minimo de 'a' e termina no minimo de 'B'
        for (int i = a.Min(); i <= b.Min(); i++) 
        {
            // Variavel do numero atual como um divisor valido
            bool valido = true;
            // Loop para verificar se o numero atual e um divisor de todos os elementos em 'a'
            for (int j = 0; j < a.Count; j++) 
            {
                // Caso o resto da divisao nao seja 0, o numero atual nao e um divisor valido, entao sai do loop interno pois o numero atual ja foi invalidado
                if ((i % a[j]) != 0) 
                {
                    valido = false;
                    j = a.Count;
                }
            }

            // Se o numero atual for um divisor valido de todos os elementos em 'A', ele e adicionado a lista de fatores
            if (valido) 
            {
            fatores.Add(i);
            }
        }

        // Depois de guardar todos os possiveis multiplos de 'A', verificar se todos eles sao fatores dos valores em 'B'
        for (int i = 0; i < fatores.Count; i++) 
        {
            bool valido = true;
            // Loop para verificar se o fator atual e um divisor de todos os elementos em 'B'
            for (int j = 0; j < b.Count; j++) 
                {
                // Caso o resto da divisao nao seja 0, o numero atual nao e um fator valido, entao sai do loop interno pois o numero atual ja foi invalidado
                if ((b[j] % fatores[i]) != 0) {
                    valido = false;
                    j = b.Count;
                }
            }
            // Se o fator atual for um divisor valido de todos os elementos em 'B', a quantidade de fatores e incrementada
            if (valido) 
            {
            qtdFatores++;
            }
        }
        return qtdFatores;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
