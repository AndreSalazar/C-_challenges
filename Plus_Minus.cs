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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int totalElements=arr.Count;
        int elements;
        float sumPositive=0;
        float sumNegative=0;
        float sumZero=0;
        
        for(elements=0;elements<=totalElements-1;elements++){
            if(arr[elements]>0){
                sumPositive++;
            }else if(arr[elements]<0){
                sumNegative++;
            }else{
                sumZero++;
            }
        }
        float resultPositive=sumPositive/totalElements;
        float resultNegative=sumNegative/totalElements;
        float resultZero=sumZero/totalElements;
        
        Console.WriteLine(resultPositive);
        Console.WriteLine(resultNegative);
        Console.WriteLine(resultZero);
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
