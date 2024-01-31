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
0 3 4 2

Sample Output 0
YES
*/
class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        string yes = "YES", no = "NO";
        // verificar se o canguru x1, que pula v1 metros por salto vai se encontrar na mesma posicao que o canguru x2, que pula v2 metros por salto, sendo que a quantidade de saldo deve ser a mesma

        // verifica se e possivel um canguru alcancar o outro
        if (x1 == x2 && v1 == v2) // verifica se eles estao no mesmo lugar e pulam igual
        {
            return yes;
        }
        else if (x1 < x2) // verifica se x1 esta antes de x1
        {
            if (v1 > v2) // verifica se os saltos de x1 podem alcancar x2
            {
                bool loop = true;
                while (loop == true)
                {
                    // 0+3  3+3  6+3  9+3 == 12
                    // 4+2  6+2  8+2  10+2 == 12
                    x1 = x1 + v1; // soma a posicao inicial, mais o salto
                    x2 = x2 + v2;
                    if (x1 >= x2) // verifica se a nova distancia saltada do x1 alcancou x2
                    {
                        loop = false;
                        if (x1 == x2) // verifica se a posicao final e igual
                        {
                            return yes;
                        }
                    }
                }
                return no;
            }
            else 
            {
                return no;
            }
        }
        else
        {
            if (v2 > v1) // verifica se os saltos de x2 podem alcancar x1
            {
                bool loop = true;
                while (loop == true)
                {
                    x1 = x1 + v1; // soma a posicao inicial, mais o salto
                    x2 = x2 + v2;
                    if (x2 >= x1) // verifica se a nova distancia saltada do x2 alcancou x1
                    {
                        loop = false;
                        if (x1 == x2) // verifica se a posicao final e igual
                        {
                            return yes;
                        }
                    }
                }
                return no;
            }
            else 
            {
                return no;
            }
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
