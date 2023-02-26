namespace Learning04.Classes
{
    // Define Class
    public class WritingAssignment : Assignment
    {
        // Attributes
        private string _title;

        // Constructors
        public WritingAssignment(string name, string topic, string title)
            : base(name, topic)
        {
            _title = title;
        }

        // Methods
        public string GetWritingInfo()
        {
            return $"{_title} by {_studentName}";
        }
    }
}
