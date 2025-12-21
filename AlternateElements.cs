using System.Security.Cryptography;
//Given an array arr[], the task is to print every alternate element of the array starting from the first element.
public class AlternateElements
{
    public static void Elements()
    {
        int[] arr = [10, 20, 30, 40, 50, 90, 100, 110];
        for (int i = 0; i < arr.Length; i = i + 2)
        {
            Console.Write(arr[i] + " ");
        }
    }

    public static List<int> RecursiveElements(int[] arr, int idx, List<int> res)
    {
        if (idx < arr.Length)
        {
            res.Add(arr[idx]);
            RecursiveElements(arr, idx + 2, res);
        }
        return res;
    }

    public static List<int> CallRecursive(int[] arr)
    {
        List<int> res = new List<int>();
        RecursiveElements(arr, 0, res);
        return res;
    }
}