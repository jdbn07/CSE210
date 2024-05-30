abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToString("MM/dd/yyyy")}\nTime: {time}\nAddress: {address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();
    

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToString("MM/dd/yyyy")}";
    }
}