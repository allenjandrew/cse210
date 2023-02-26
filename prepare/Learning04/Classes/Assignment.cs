namespace Learning04.Classes
{
    // Define Class
    public class Assignment
    {
        // Attributes
        protected string _studentName;
        protected string _topic;

        // Constructors
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        // Methods
        public string GetSummary()
        {
            return $"Student Name: {_studentName}; Topic: {_topic}";
        }
    }
}
