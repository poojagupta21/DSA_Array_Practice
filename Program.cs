using System.Diagnostics;

class Program
{
    public static void Main()
    {
        int[] arr = [10, 20, 30, 5, 50, 90, 100, 110];
        int[] arr1 = [1,1, 2, 2, 3, 4, 4, 4, 5, 5];


        Console.WriteLine("helloe");
        ArrayProblem1.PrintArray();
        AlternateElements.Elements();
        Console.WriteLine();
        List<int> result = AlternateElements.CallRecursive(arr);
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
        result = LeaderArray.SearchLeader();
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
        Boolean result1 = ArraySorted.IsSorted(arr, arr.Length);
        Console.WriteLine(result1);
        Console.WriteLine("---------------");
        int newSize = DistinctElements.RemoveDuplicates(arr1);
        for (int i = 0; i < newSize; i++)
        {
            Console.WriteLine(arr1[i] + " ");
        }

        int []arr2 = {1, 2, 3}; 
        SubArrays.printSubArrays(arr2, 0, 0);

        int[] reverse = {2,3,3,1,9,4,5};
        ReverseArray2.reverse(reverse,0,reverse.Length-1);
        foreach(var r in reverse){
            Console.Write(r +",");
        }

        Console.WriteLine();

        int[] rotate = {1,2,3,4,5,6};
        RotateArray.Rotate(rotate, 2);
        foreach(var r in rotate){
            Console.Write(r + ",");
        }
    }
}