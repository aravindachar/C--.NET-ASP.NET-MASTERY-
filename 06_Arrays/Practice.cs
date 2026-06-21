// Print all elements.
// Find the maximum element.
// Find the minimum element.
// Calculate the sum.
// Calculate the average.
// Reverse an array.
// Count even numbers.
// Count odd numbers.
// Search for an element (Linear Search).
// Copy one array into another.
using System.Collections;
using System.ComponentModel.Design;

class Practice
{
    static void main(string[] args)
    {
        int[] arr = {1,222,33,4,45};
        for(int i = 0 ; i < arr.Length ; i++)
        {
            System.Console.WriteLine(arr[i]);
        }
        Array.Sort(arr);
        System.Console.WriteLine(arr[0]);
        System.Console.WriteLine(arr[arr.Length-1]);
        int sum = 0 ;
        for(int i = 0 ; i <arr.Length ; i++)
        {
            sum = sum + arr[i];
        }        
        int avg = sum/arr.Length ;
        int countev = 0 ;
        int countodd = 0 ;
         for(int i = 0 ; i <arr.Length ; i++)
        {
            if (arr[i] % 1 == 0 )
            {
                countev ++ ;
            }
            if(arr[i]%1 == 1)
            {
                countodd ++ ;
            }

        }   
        int[] arr2 = new int[arr.Length];
        for(int i = 0 ; i < arr2.Length ; i++)
        {
            arr2[i] = arr[i];
        } 

    }
}
