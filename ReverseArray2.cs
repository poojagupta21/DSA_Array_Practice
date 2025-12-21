public class ReverseArray2
{
    public static void reverse(int[] arr, int left, int right)
    {
        if (left > right || left == right)
        {
            return;
        }
        else
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            reverse(arr, left + 1, right - 1);
        }
    }
}