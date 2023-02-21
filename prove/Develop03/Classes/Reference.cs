namespace Develop03.Classes
{
    // Define Class
    public class Reference
    {
        // Attributes
        private string _book;
        private int _chapter;
        private List<int> _verses = new List<int>();

        // Constructors
        public Reference(string inputString)
        {
            // Split the string
            string[] splits = inputString.Split(" ");
            // Extract numbers from split string
            string numbers = splits[^1];
            // Remove numbers from split string
            string[] removed = splits.SkipLast(1).ToArray();
            // Create book name from split string
            _book = string.Join(" ", removed);
            // split numbers string
            string[] splits2 = numbers.Split(":");
            // Extract chapter from split numbers
            _chapter = int.Parse(splits2[0]);
            // Extract verses from split numbers
            string verses = splits2[^1];
            // If multiple verses
            if (verses.Contains("-"))
            {
                string[] versesSplit = verses.Split("-");
                for (int i=0; i<versesSplit.Count(); i++)
                {
                    _verses.Add(int.Parse(versesSplit[i]));
                }
            }
            else if (verses.Contains(","))
            {
                string[] versesSplit = verses.Split(",");
                for (int i=0; i<versesSplit.Count(); i++)
                {
                    _verses.Add(int.Parse(versesSplit[i]));
                }
            }
            else
            {
                _verses.Add(int.Parse(verses));
            }            

        }

        // Methods
        public void DisplayReference()
        {
            string versePrinter;
            if (_verses[0] == _verses[^1])
            {
                versePrinter = $"{_verses[0]}";
            }
            else // if (_verses[0] +1 < _verses[-1])
            {
                versePrinter = $"{_verses[0]}-{_verses[^1]}";
            }
            Console.Write($"{_book} {_chapter}:{versePrinter} - ");
        }
    }
}