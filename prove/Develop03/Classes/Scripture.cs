namespace Develop03.Classes
{
    // Define class
    public class Scripture
    {
        // Attributes
        private List<Word> _wordList = new List<Word>();
        private Reference _reference;

        // Constructors
        public Scripture() { }

        public Scripture(string inputString)
        {
            // Split inputString
            List<string> divided = new List<string>(inputString.Split(" - "));
            // Get reference
            _reference = new Reference(divided[0]);
            // Remove reference from string list
            divided.RemoveAt(0);
            // Put the verse back together, in case it was split
            string text = string.Join(" - ", divided);
            // Split the verse into words
            string[] wordsList = text.Split(" ");
            // Create a Word instance for each word
            foreach (string wordIt in wordsList)
            {
                Word word = new Word(wordIt);
                _wordList.Add(word);
            }
        }

        // Getters/Setters
        public List<Word> GetwordList()
        {
            return _wordList;
        }

        public Reference GetReference()
        {
            return _reference;
        }

        // Methods
        public bool HideRandomWords(int numTimes)
        {
            Random tRex = new Random();
            bool hidEnough;
            bool noneLeft = true;
            for (int i = 0; i < numTimes; i++)
            {
                hidEnough = false;
                noneLeft = true;
                while (!hidEnough)
                {
                    hidEnough = _wordList[tRex.Next(_wordList.Count)].HideWord();
                }
                foreach (Word wordIt in _wordList)
                {
                    if (!wordIt.GetIsHidden())
                    {
                        noneLeft = false;
                    }
                }
                if (noneLeft)
                {
                    return noneLeft;
                }
            }
            return noneLeft;
        }

        public void DisplayScripture()
        {
            Console.Clear();
            _reference.DisplayReference();
            foreach (var word in _wordList)
            {
                Console.Write(word.GetSingleWord() + " ");
            }
            Console.WriteLine();
        }
    }
}
