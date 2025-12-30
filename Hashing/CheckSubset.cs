public class CheckSubset
{
    public static Boolean isSubset(List<int> a , List<int> b)
    {
        HashSet<int> arrA = new HashSet<int>(a);

        foreach(var num in b)
        {
            if (!arrA.Contains(num))
            {
                return false;
            }
        }
        return true; 
    }
}