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
     * Complete the 'utopianTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int utopianTree(int n) 
    {
        // Se n for 0, a altura inicial da arvore e 1
        if (n == 0) 
        {
            return 1;
        }
        // Se n for 1, a altura inicial da arvore e 2
        else if (n == 1) 
        {
            return 2;
        }
        // Caso contrario, comecar a altura da arvore com 2
        else 
        {
            int treeTall = 2;
            // Loop para cada ano a partir do terceiro (i = 2) ate o ano n
            for (int i = 2; i <= n; i++) 
                {
                // Se o ano for par, a altura aumenta em 1
                if (i % 2 == 0) 
                {
                    treeTall = treeTall + 1;
                }
                // Se o ano for impar, a altura duplica
                else 
                {
                    treeTall = treeTall * 2;
                }
            }
            return treeTall;
        }
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
