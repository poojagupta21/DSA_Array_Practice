using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public  class LeaderArray
{
    public static List<int> SearchLeader()
    {
        int[] arr = [16, 17, 4, 3, 5, 2];
        int maxRight = arr[arr.Length-1];
        List<int> result = new List<int>();
        result.Add(maxRight);
        for(int j= arr.Length-2 ; j >= 0; j--)
        {
            if (arr[j] >= maxRight)
            {
                maxRight = arr[j];
                result.Add(arr[j]);
            }
        }
        result.Reverse(); 
        return result;
    }
}