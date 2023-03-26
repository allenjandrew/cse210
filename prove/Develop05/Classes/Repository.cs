namespace Develop05.Classes
{
    // Define class
    public class Repository
    {
        // Attributes
        private List<Goal> _goals = new List<Goal>();

        // Constructor
        public Repository() { }

        // Methods
        public List<Goal> GetAll()
        {
            return _goals;
        }

        public void Add(Goal goal)
        {
            _goals.Add(goal);
        }

        public void Remove(Goal goal)
        {
            _goals.Remove(goal);
        }
    }
}
