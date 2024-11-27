using System.Diagnostics.CodeAnalysis;

List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(15);
numbers.Add(20);

int x = 55;
int[] serial = new int[]
    {
        70,
        80,
        90
    };

numbers.Add(x);
numbers.AddRange(serial);

numbers.Insert(3, 0);
numbers.RemoveAt(2);
numbers.Remove(55);
numbers.RemoveAt(numbers.IndexOf(0));
foreach (var number in numbers)
{
    Console.Write($"{number,-5}");
}

Console.WriteLine("-----------------------");
