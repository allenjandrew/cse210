namespace Develop03.Classes
{
    // Define Class
    public class Word
    {
        // Attributes
        private string _singleWord;
        private bool _isHidden;

        // Constructors
        public Word(string singleWord)
        {
            _singleWord = singleWord;
        }

        // Getters/Setters
        public Word GetSingleWord()
        {
            return _singleWord;
        }
        public bool GetIsHidden()
        {
            return _isHidden();
        }

        // Methods
        public bool HideWord()
        {
            if (!_isHidden)
            {
                string newWord;
                foreach (var letter in _singleWord)
                {
                    newWord += "_";
                }
                _singleWord = newWord;
                return _isHidden = true;
            }
            else
            {
                return false;
            }

        }
    }
}
