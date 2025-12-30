using System.Buffers;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Xml;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("check for subset, the task is to determine whether b[] is a subset of a[].");

        List<int> a = new List<int>() { 11, 1, 13, 21, 3, 7 };
        List<int> b = new List<int>() { 12, 3, 7, 1 };
        Console.WriteLine(CheckSubset.isSubset(a,b));

        Console.WriteLine("check for disjoint i.e., there is no element common between both the arrays.");

        int[] arrA = {12, 34, 11, 9, 3};
        int[] arrB = {7, 2, 1, 5};
        Console.WriteLine(CheckDisjoint.isDisjoint(arrA,arrB));
    }
}
