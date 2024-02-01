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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> countMinsMaxs = new List<int> {0, 0};
        int minScore = scores[0];
        int maxScore = scores[0];
        
        foreach (int score in scores) // para cada score, verifica quantas vezes ele foi menor ou maior que a ultima atualizacao de menor e maior
        {
            if (score < minScore)
            {
                countMinsMaxs[1] = countMinsMaxs[1]+1;
                minScore = score;
            }
            if (score > maxScore)
            {
                countMinsMaxs[0] = countMinsMaxs[0]+1;
                maxScore = score;
            }
        }
        return countMinsMaxs;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
