using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class SolutionManager
{
    public static void CreateBox()
    {

    }
    public static void GenericBoxOfString()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n;i++)
        {
            string input = Console.ReadLine();
            var box = new Box<string>(input);
            Console.WriteLine(box);
        }
    }
    public static void GenericBoxOfInt()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n;i++)
        {
            int input = int.Parse(Console.ReadLine());
            var box = new Box<int>(input);
            Console.WriteLine(box);
        }
    }
    public static void GenericSwapMethodStrings()
    {
        int n = int.Parse(Console.ReadLine());
        var listOfBoxes = new List<Box<string>>();

        while (n > 0)
        {
            var input = Console.ReadLine();
            listOfBoxes.Add(new Box<string>(input));
            n--;
        }

        var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SolutionManager.Swap(listOfBoxes, swapIndexes[0], swapIndexes[1]);
        listOfBoxes.ForEach(str => Console.WriteLine(str));
    }
    public static void GenericSwapMethodInts()
    {
        int n = int.Parse(Console.ReadLine());
        var listOfInts = new List<Box<int>>();

        while(n > 0)
        {
            listOfInts.Add(new Box<int>(int.Parse(Console.ReadLine())));
            n--;
        }

        var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SolutionManager.Swap(listOfInts, swapIndexes[0], swapIndexes[1]);
        listOfInts.ForEach(val => Console.WriteLine(val));
    }
    public static void GenericCountMethodStrings()
    {
        var numberOfElements = int.Parse(Console.ReadLine());
        var listOfElements = new List<Box<string>>();

        while(numberOfElements > 0)
        {
            listOfElements.Add(new Box<string>(Console.ReadLine()));
            numberOfElements--;
        }

        var comparison = new Box<string>(Console.ReadLine());
        Console.WriteLine(SolutionManager.CountGreaterThanComparisonValue(listOfElements, comparison));
    }
    public static void GenericCountMethodDoubles()
    {
        var listOfDoubles = new List<Box<double>>();
        int n = int.Parse(Console.ReadLine());

        while(n > 0)
        {
            listOfDoubles.Add(new Box<double>(double.Parse(Console.ReadLine())));
            n--;
        }

        var comparison = new Box<double>(double.Parse(Console.ReadLine()));
        Console.WriteLine(SolutionManager.CountGreaterThanComparisonValue(listOfDoubles, comparison));
    }
    private static void Swap<T>(IList<T> collection,int indexToSwap,int swapWithIndex)
    {
        var temp = collection[indexToSwap];
        collection[indexToSwap] = collection[swapWithIndex];
        collection[swapWithIndex] = temp;
    }
    private static int CountGreaterThanComparisonValue<T>(IEnumerable<T> collection,T comparisonValue) where T:IComparable<T>
    {
        var count = 0;

        foreach(var item in collection)
        {
            if(item.CompareTo(comparisonValue) > 0)
            {
                count++;
            }
        }
        return count;
    }
  
}

