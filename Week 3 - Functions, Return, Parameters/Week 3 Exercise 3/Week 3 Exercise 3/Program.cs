internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.topLeft = new Point { x = 0, y = 0 };
        r.width = 5;
        r.height = 5;

        Point p = new Point { x = 3, y = 3 };

        bool result = Inside(r, p);
        Console.WriteLine(result);
    }

    static bool Inside(Rectangle r, Point p)
    {
        if (p.x >= r.topLeft.x && p.x <= r.topLeft.x + r.width &&
            p.y >= r.topLeft.y && p.y <= r.topLeft.y + r.height)
        {
            return true;
        }
        return false;
    }
}

class Point
{
    public float x;
    public float y;
}

class Rectangle
{
    public Point topLeft;
    public float width;
    public float height;
}