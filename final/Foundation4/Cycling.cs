public class Cycling : Activity
{
    private double speed;

    public Cycling(string date, int minutes, string type, double speed) : base(date, minutes, type)
    {
        this.speed = speed;
    }

    public override double GetDistanceMiles()
    {
        double distance = speed * minutes / 60;
        return distance;
    }

	public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / speed;
        return pace;
    }
}