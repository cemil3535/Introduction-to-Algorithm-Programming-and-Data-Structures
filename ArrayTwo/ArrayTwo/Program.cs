
int[] numbers = new int[]
{
    5,3,8,10,2
};


var numbers1 = Array.CreateInstance(typeof(int), 5);
numbers1.SetValue(-5, 0);
numbers1.SetValue(3, 1);
numbers1.SetValue(8, 2);
numbers1.SetValue(10, 3);
numbers1.SetValue(-2, 4);

for (int i = 0; i < numbers1.Length; i++)
{
    Console.WriteLine("number[{0}] = {1} - numbers1[{0}] = {2}" , i, numbers[i], numbers1.GetValue(i));
}