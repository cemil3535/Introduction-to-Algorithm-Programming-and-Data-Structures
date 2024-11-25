

int[] numbers = { 1, 5, 9, 17 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Numbers[{i}] = " +
        $"{numbers[i]}");
}

Console.WriteLine("--------------------------------------------------------------");

Console.Write("Dizi boyutunu giriniz: ");
int size = int.Parse( Console.ReadLine());
int[] numbers2 = new int[size];

var random = new Random();

for (int i = 0; i < numbers2.Length; i++)
    numbers2[i] = random.Next(1, 10);

foreach (number n in numbers2)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------------------");

double[,] matris = new double[,] 
{ 
    { 1, 2, 3 },
    { 2, 3, 4 },
    { 6, 7, 8 } 
};

for (int i = 0; i < matris.GetLength(0); i++)
{
    for (int j = 0; j < matris.GetLength(1); j++)
    {
        Console.Write($"{matris[i, j],5}");
    }
    Console.WriteLine();
}



