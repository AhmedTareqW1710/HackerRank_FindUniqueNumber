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

class Solution
{

    // Complete the sockMerchant function below.
    static int FindUniqueNumber(int[] ar)
    {
        int result = -1;
       
        for (int i = 0; i < ar.Length; i++)
        {
            result = ar[i];

            for (int j = 0; j < ar.Length; j++)
            {
                if (i != j)
                {
                    if (ar[j] == result)
                    {
                        result = -1;
                        break;
                    }
                }
            }

            if (result != -1)
            {
                break;
            }
        }


        return result;
    }

    static void Main(string[] args)
    {
        
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = FindUniqueNumber(ar);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
