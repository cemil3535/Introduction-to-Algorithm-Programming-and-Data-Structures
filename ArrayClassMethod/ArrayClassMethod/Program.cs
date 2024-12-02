using System.Collections;

int[] numbers = new int[]
{
    5,3,8,10,2,18,23,44,55,6,34,19
};

var numbers2 = Array.CreateInstance(typeof(int), numbers.Length);
var numberList = new ArrayList(numbers);

numbers.CopyTo(numbers2, 0);
numberList.Sort();

Array.Sort(numbers);
Array.Clear(numbers, 2,1);
var x = Array.IndexOf(numbers, 44);
Console.WriteLine(x);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"numberList[{i}] = " + $"{numberList[i],3}     " +
    $"number[{i}] = " + $"{numbers[i]}");

}