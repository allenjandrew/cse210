namespace Develop03.Classes
{
    // Define class
    public class Scripture
    {
        // Attributes
        private List<Word> _scriptureWordList = new List<Word>();
        private Reference _reference = new Reference();

        // Constructors
        public Scripture()
        {
        }

        // Getters/Setters
        public List<Word> GetScriptureWordList()
        {
            return _scriptureWordList;
        }

        public Reference GetReference()
        {
            return _reference;
        }

        // Methods
        public void HideRandomWords(int numTimes)
        {
            Random tRex = new Random();
            for (int i=0; i<numTimes; i++)
            {
                done = false;
                while (!done)
                {
                    done = _scriptureWordList[tRex.Next(_scriptureWordList.Count)].HideWord();
                }
            }
        }

        public void DisplayScripture()
        {
            _reference.DisplayReference();
            foreach (var word in _scriptureWordList)
            {
                Console.Write(word.GetSingleWord(), " ");
            }
            Console.WriteLine();
        }
    }
}