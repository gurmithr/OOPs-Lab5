using System;


public class InvalidRadiusException : Exception
{
    public InvalidRadiusException()
    {
        Console.WriteLine("Invalid radius Radius should be Positive");
    }

    public InvalidRadiusException(double radius)
    {
        Console.WriteLine($"Invalid radius: {radius} Radius should be positive");
    }
}


public class Circle
{
    private double radius;


    public double Radius
    {
        get { return radius; }
        set { SetRadius(value); }
    }
    public void SetRadius(double r)
    {
        if (r > 0)
        {
            radius = r;
        }
        else
        {
            throw new InvalidRadiusException(r);
        }
    }


    public override string ToString()
    {
        return $"Radius of the Circle: {radius}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {

            Circle c1 = new Circle();
            c1.SetRadius(10);
            Console.WriteLine(c1);

            Circle c2 = new Circle();
            c2.SetRadius(-11);
            Console.WriteLine(c2);

            Circle c3 = new Circle();
            c3.SetRadius(0);
            Console.WriteLine(c3);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
