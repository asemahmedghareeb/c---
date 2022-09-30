using System;
namespace array;
class array
{
    static void Main(string [] args)
    {
        // array is referece type the array stored in stack but the value in the heap
        //string[] friends = new string[5];


        //string[] friends =new string[5] { "ASEM", "ahmed", "samy", "mohamed", "Ghareeb" };
       
        string[] friends = { "ASEM", "ahmed", "samy", "mohamed", "Ghareeb" };
        //we can use var but we should first explicity say the type (new int)
        var numbers = new int [5] { 1, 2, 3, 4, 5 };


        //MultiDimenshnal array
        int[,] suduko =
        {
            {1, 2 ,3, 4, 5 },
            {4, 5, 6, 7, 8 },
            {8, 9, 10,11,12},
            {12,13,14,15,16},
            {17,18,19,20,21},
        };
        int[,] arr2d = new int[3, 3];

        //for (int i = 0; i < 3; i++){
        //    for(int k = 0; k < 3; k++)
        //    {
        //        int num= Convert.ToInt32(Console.ReadLine());
        //        arr2d[i, k] = num;
        //    }  
        //}

        //for (int i = 0; i < 3; i++){
        //    for(int k = 0; k < 3; k++)
        //    {
        //        Console.WriteLine(arr2d[i,k]);
        //    }  
        //}

        //jagged array 
        var jagged = new int[][]
        {
            new int[] {1,2 },
            new int[] {3,4,6},
            new int[] {7}
        };

        var friends2 = new string[] { "asem", "ahmed", "ghareeb", "elbadahy","mohamed" };
        //this array wil contain the elements from zero index (inclusive) element to the element index 2 (index 2 exclusive)
        //var slice1 =friends2[..2];


        //this means the new array contain the element from index 1 (inclusive) until the end except the last 3 elements
        var sliceRange1 = 1..^3;
        var slice1 = friends2[sliceRange1] ;
        //for (int i = 0; i < slice1.Length; i++)
        //    Console.WriteLine(slice1[i]);

       
        //this array will contain the element from index 2 (inclusive) to the end  last index is (inclusive) 
        var sliceRange2 = 2..;
        var slice2 =friends2[sliceRange2];
        
        for (int j = 0; j < slice2.Length; j++)
            Console.WriteLine(slice2[j]);


        //bound checks
         

        Console.ReadKey();
    }
}