namespace Develop05.Classes
{
    // Define class
    public class InMemRepository : Repository
    {
        // Attributes
        private List<Goal> _goals = new List<Goal>();

        // Getters
        public override List<Goal> GetAll()
        {
            return _goals;
        }

        // Methods
        public override void Add(Goal goal)
        {
            _goals.Add(goal);
        }

        public override void Remove(Goal goal)
        {
            _goals.Remove(goal);
        }
    }
}
