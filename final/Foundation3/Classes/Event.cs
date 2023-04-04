// Class Event
//     Attributes:
//         _title: string
//         _eventType: string
//         _description: string
//         _date: string
//         _time: string
//         _address: Address
//     Constructors:
//         Event(_title, _eventType, _description, _date, _time, _address)
//     Methods:
//     StandardDetails(): string
//     FullDetails(): virtual string
//     ShortDetails(): string

namespace Foundation3.Classes
{
    // Define Class
    class Event
    {
        // Attributes
        protected string _title;
        protected string _description;
        protected string _date;
        protected string _time;
        protected Address _address;
        protected string _eventType;

        // Constructors
        public Event(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string eventType
        )
        {
            _title = title;
            _eventType = eventType;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        // Methods

        public string StandardDetails()
        {
            return $"{_title}\n{_description}\nWhere: {_address.ToString()}\nWhen: {_date} @ {_time}";
        }

        public virtual string FullDetails()
        {
            throw new Exception("Method 'FullDetails' not available in base class 'Event'");
        }

        public string ShortDetails()
        {
            return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
        }
    }
}
