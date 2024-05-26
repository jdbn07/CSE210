using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName =  name;
        _description =  description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        //          CONDITION   ? TRUE : FALSE
        char mark = IsComplete()?'x':' '; // Tenary operator 'x TRUE' : ' FALSE '. "" --> String ||| '' ---> Single Character 
        return $"[{mark}] {_shortName} ({_description})"; // 
    }

    public virtual string GetDetailString2()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}