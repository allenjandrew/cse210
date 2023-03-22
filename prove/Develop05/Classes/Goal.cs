namespace Develop05.Classes
{
    // Define class
    public class Goal
    {
        // Attributes
        private string _name = "";
        private string _desc = "";
        protected int _points = 0;
        protected int _earned = 0;
        protected bool _complete = false;
        protected int _timesCompleted = 0;

        // Constructor
        public Goal(string name, string desc, int points)
        {
            _name = name;
            _desc = desc;
            _points = points;
        }

        // Getters
        public string GetName()
        {
            return _name;
        }

        public string GetDesc()
        {
            return _desc;
        }

        public virtual int GetPoints()
        {
            return _points;
        }

        public virtual int GetEarned()
        {
            return _earned;
        }

        public virtual bool IsComplete()
        {
            return _complete;
        }

        public void MarkComplete()
        {
            _complete = true;
        }

        public void MarkIncomplete()
        {
            _complete = false;
        }

        // Methods
        public virtual void RecordProgress() { }

        public virtual void AddPoints(int points)
        {
            _earned += points;
        }

        public virtual string ToString()
        {
            throw new Exception("Method 'ToString' not available in base class 'Goal'")
        }
    }
}
