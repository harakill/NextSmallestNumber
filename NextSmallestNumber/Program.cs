// See https://aka.ms/new-console-template for more information


using NextSmallestNumber;

int[] a = new[] { 3, 4, 6, 9, 10, 12, 14, 15, 17, 19, 21 };

var smallestNumber = new SmallestNumber();

Console.WriteLine(smallestNumber.GetNextSmallestNumber(a, 12));
Console.WriteLine(smallestNumber.GetNextSmallestNumber(a, 13));
Console.WriteLine(smallestNumber.GetNextSmallestNumber(a, 14));
Console.WriteLine(smallestNumber.GetNextSmallestNumber(a, 15));
Console.WriteLine(smallestNumber.GetNextSmallestNumber(a, 2));
