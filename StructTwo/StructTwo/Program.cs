
var p1 = new Point(3,4);
Console.WriteLine(p1);

p1.SetOrigin();
Console.WriteLine(p1);



public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"{X},{Y}";
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void SetOrigin()
    {
        X = 0;
        Y = 0;
    }

}
