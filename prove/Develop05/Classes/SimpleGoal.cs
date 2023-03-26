namespace Develop05.Classes
{
    public class SimpleGoal : Goal
    {
        // Constructors
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points) { }

        // Methods
        public override void RecordProgress()
        {
            if (!IsComplete())
            {
                AddEarned(GetPoints());
                MarkComplete();
            }
        }

        public override string ToString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {GetName()} - {GetDescription()}";
        }

        public override string GetSummary()
        {
            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPoints: {GetPoints()}\nEarned: {GetEarned()}\nComplete: {IsComplete()}";
        }
    }
}
