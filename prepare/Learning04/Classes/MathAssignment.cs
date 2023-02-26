namespace Learning04.Classes
{
    // Define Class
    public class MathAssignment : Assignment
    {
        // Attributes
        private string _textbookSection;
        private string _problems;

        // Constructors
        public MathAssignment(string name, string topic, string textbookSection, string problems)
            : base(name, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        // Methods
        public string GetHomeworkList()
        {
            return $"Problems {_problems} from textbook section {_textbookSection}";
        }
    }
}
