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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int maxBird = 0; // variavel que guarda o passaro mais repetido
        long maxCount = 0; // variavel que guarda a contagem do passaro mais repetido
        List <int> arrDistinct = arr.Distinct().ToList(); // lista de passaros unicos que contem no array
        
        for (int i = 0 ; i < arrDistinct.Count ; i ++) // para cada passaro unico, contar quantos aparecessem no array recebido
        {
            long count = 0;
            for (int j = 0; j < arr.Count ; j++)
            {
                if (arr[j] == arrDistinct[i])
                {
                    count ++;
                }
                if (count > maxCount) // caso a contagem seja maior que a atual, atualizar o 'maxBird'
                {
                    maxCount = count;
                    maxBird = arrDistinct[i];
                }
                else if (count == maxCount) // caso a contagem seja igual, atualizar o 'maxBird' com tipo de passaro de menor valor
                {
                    if (maxBird > arrDistinct[i])
                    {
                        maxBird = arrDistinct[i];
                    }
                }

            }
        }
        return maxBird;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
