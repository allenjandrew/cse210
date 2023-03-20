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
        public virtual List<Goal> GetAll()
        {
            throw new Exception("not implemented in base class.");
        }

        public virtual void Add(Goal goal)
        {
            throw new Exception("not implemented in base class.");
        }

        public virtual void Remove(Goal goal)
        {
            throw new Exception("not implemented in base class.");
        }
    }
}
