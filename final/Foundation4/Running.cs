public class Running : Activity
{
    private double distance;

    public Running(string date, int minutes, string type, double distance) : base(date, minutes, type)
    {
        this.distance = distance;
    }

    public override double GetDistanceMiles()
    {
        return distance;
    }

	public override double GetSpeed()
    {
        double speed = distance / minutes * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = minutes / distance;
        return pace;
    }
}