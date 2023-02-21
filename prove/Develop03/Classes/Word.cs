namespace Develop03.Classes
{
    // Define Class
    public class Word
    {
        // Attributes
        private string _singleWord;
        private bool _isHidden = false;

        // Constructors
        public Word(string singleWord)
        {
            _singleWord = singleWord;
        }

        // Getters/Setters
        public string GetSingleWord()
        {
            return _singleWord;
        }
        public bool GetIsHidden()
        {
            return _isHidden;
        }

        // Methods
        public bool HideWord()
        {
            if (!_isHidden)
            {
                string newWord = "";
                foreach (var letter in _singleWord)
                {
                    if (char.IsLetter(letter))
                    {
                        newWord += "_";
                    }
                    else {
                        newWord += letter;
                    }
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
