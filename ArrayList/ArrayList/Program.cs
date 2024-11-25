using System;
using System.Collections;

ArrayList arrayList = new ArrayList()
{
    10,"BTK Akademi",true,'e'
};


foreach (var item in arrayList)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

int[] numbers = new int[]
{
    23,44,55
};
arrayList.AddRange(numbers);

foreach (var item in arrayList)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

Console.WriteLine(arrayList[4]);

int x = (int)arrayList[0];
Console.WriteLine(x+10);

//Delete
//arrayList.Remove(10);
//arrayList.RemoveAt(1);
arrayList.RemoveRange(1,1);

foreach (var item in arrayList)
{
    Console.Write($"{item} ");
}
Console.WriteLine();