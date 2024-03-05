public class Circle : Shape
{
    private double radius;

    public Circle(string color, double radius) : base (color)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return radius * radius * Math.PI;
    }
}