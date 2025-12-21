public class SubArrays
{
    public static void printSubArrays(int[] arr,
                            int start, int end)
    {
        // Stop if we have reached 
        // the end of the array 
        if (end == arr.Length)
            return;

        // Increment the end point 
        // and start from 0 
        else if (start > end)
            printSubArrays(arr, 0, end + 1);

        // Print the subarray and 
        // increment the starting point 
        else
        {
            Console.Write("[");
            for (int i = start; i < end; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            Console.WriteLine(arr[end] + "]");
            printSubArrays(arr, start + 1, end);
        }
        return;
    }
}