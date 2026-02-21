public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string description, string date, string time, string address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"Type: Reception \n RSVP: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception - {GetShortDescription()}";
    }
}