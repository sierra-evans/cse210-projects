public class Square : Shape
{
    protected double side;

    public Square(string color, double side) : base (color)
    {
        this.side = side;
    }

    public override double GetArea()
    {
        return side * side;
    }
}