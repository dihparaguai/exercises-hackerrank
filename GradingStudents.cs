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
    Sample Input 0
    73
    67
    38
    33
    
    Sample Output 0
    75
    67
    40
    33
    */

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> newGrades = new List<int>(); // nova lista com novas notas
        
        foreach (int grade in grades)
        {
            if (grade > 37 && grade % 5 > 2) // se a nota for maior que 37 e o resto da divisao por 5 for maior que 2...
            {
                newGrades.Add(grade + (5 - grade % 5)); // somar a nota atual com cinco menos o resto da divisao (diferenca para arrendonda para 5)
            }
            else
            {
                newGrades.Add(grade);
            }
        }

        return newGrades;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
