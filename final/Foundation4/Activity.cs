public class Activity
{
    protected string date;
    protected int minutes;
    protected string type;

    public Activity(string date, int minutes, string type)
    {
        this.date = date;
        this.minutes = minutes;
        this.type = type;
    }

    public virtual double GetDistanceMiles()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary(Activity activity)
    {
        return $"{date} {type} ({minutes} min): Distance {activity.GetDistanceMiles()} miles, Speed {activity.GetSpeed()} mph, Pace {activity.GetPace()} min per mile";
    }
}