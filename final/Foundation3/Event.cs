using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title} \n {_description} \n {_date} at {_time} \n {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{_title} - {_date}";
    }
}