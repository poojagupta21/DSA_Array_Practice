public class ArraySorted
{
    public static Boolean IsSorted(int[] arr, int len)
    {
        if (len == 0 || len == 1)
            return true;
        
        return arr[len-1]>=arr[len-2] && IsSorted(arr,len-1);
    }

    public static bool isSorted(int []arr) {
        
        int n = arr.Length;
        
        // Iterate over the array and check if 
        // every element is greater than or
        // equal to previous element.
        for (int i = 1; i < n; i++)
            if (arr[i - 1] > arr[i])
                return false;

        return true;
    }
}