public class CheckDisjoint
{
    public static Boolean isDisjoint(int[] a, int[] b)
    {
        HashSet<int> arrSet = new HashSet<int>();

        for(int i=0 ; i < a.Length; i++)
        {
            arrSet.Add(a[i]);
        }

        foreach(var num in b)
        {
            if (arrSet.Contains(num))
            {
                return false;
            }
        }

        return true;
    }
}