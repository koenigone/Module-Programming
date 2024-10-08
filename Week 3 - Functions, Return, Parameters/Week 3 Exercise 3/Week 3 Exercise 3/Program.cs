internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.topLeft = new Point();
        Point p = new Point();

        bool result = Inside(r, p);
        Console.WriteLine(result);



        bool Inside(Rectangle r, Point p)
        {
            if (p.x > r.width)
            {
                return false;
            } 
            else if (p.y > p.y) 
            { 
                return false;
            } else
            {
                return true;
            }
        }
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