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
Output Format
If Brian did not overcharge Anna, print Bon Appetit on a new line; otherwise, print the difference that Brian must refund to Anna. This will always be an integer.

Sample Input 0
4 1
3 10 2 9
12

Sample Output 0
5
*/

class Result
{

    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int anaNotAte = bill[k]; // atribuindo o valor do que ana nao comeu
        int billDivision = (bill.Sum() - anaNotAte) /2; // descobrindo o valor da disivao correta da conta
        int brianOverCharged = b - billDivision; // descobrindo o valor cobrado a mais ou a menos de ana
        
        if (brianOverCharged == 0) // teste para verificar se o valor foi cobrado correto
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(brianOverCharged);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result.bonAppetit(bill, k, b);
    }
}
