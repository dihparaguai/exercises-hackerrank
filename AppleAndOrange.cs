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
7 11 // localizacao da casa do sam = s / t
5 15 // localizacao das arvores de maca e laranja = a / b
3 2 // quantidade de macas e laranja que cairam = m / n
-2 2 1 // distancia da queda das macas em relacao a posicao da arvore = da
5 -6 // distancia da queda das laranjas em relacao a posicao da arvore = db

Sample Output 0
1 // uma maca caiu na casa de sam
1 // uma laranja caiu na casa de sam
*/

class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        // criar duas var int para armazenar a quantidade de macas e laranjas que cairam na casa do sam
        int countA = 0, countO = 0;
        // percorrer a lista das macas e laranjas, verificar se alguma delas caiu na casa de sam e incrementar a var count (distancia da arvores + distancia da queda >= localizacao inicial da casa do sam e =< localizacao final da casa do sam) 
        foreach (int apple in apples)
        {
            if ((apple + a) >= s && (apple + a <= t))
            {
                countA ++;
            }
        }
        
        foreach (int orange in oranges)
        {
            if ((orange + b) >= s && (orange + b <= t))
            {
                countO ++;
            }
        }
        // exebir no console as duas var count's
        Console.WriteLine($"{countA}\n{countO}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
