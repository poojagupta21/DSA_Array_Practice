public class DistinctElements
{
    public static int RemoveDuplicates(int[] arr)
    {
        int n = arr.Length;
        if (n <= 1)
        {
            return n;
        }
        int idx = 1;
        for (int j = 1; j < n; j++)
        {
            if (arr[j] != arr[j - 1])
            {
                arr[idx++] = arr[j];
            }
        }
        return idx;
    }
}