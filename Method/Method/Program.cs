double sum = SerialToplam(5.5, 6.7, 8.9, 11.498);

Console.WriteLine("{0,5:0.##}",sum);

static double SerialToplam(params double[] serials)
{
    double sum = 0;
    foreach (var serial in serials)
    {
        sum += serial;

    }
    return sum;
}
