public class Swimming : Activity
{
    private double laps;

    public Swimming(string date, int minutes, string type, double laps) : base(date, minutes, type)
    {
        this.laps = laps;
    }

    public override double GetDistanceMiles()
    {
        double distance = ((laps * 50) / 1000) * 0.62;
        return distance;
    }

	public override double GetSpeed()
    {
        double speed = (GetDistanceMiles()) / minutes * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / (GetSpeed());
        pace = Math.Round(pace, 2);
        return pace;
    }
}