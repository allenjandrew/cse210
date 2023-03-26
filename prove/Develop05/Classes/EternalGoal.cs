namespace Develop05.Classes
{
    public class EternalGoal : Goal
    {
        // Constructors
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        // Methods
        public override void RecordProgress()
        {
            AddEarned(GetPoints());
            IncreaseTimesCompleted();
        }

        public override string ToString()
        {
            return $"[{GetTimesCompleted()}x] {GetName()} - {GetDescription()}";
        }

        public override string GetSummary()
        {
            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPoints: {GetPoints()}\nEarned: {GetEarned()}\nTimes Completed: {GetTimesCompleted()}";
        }
    }
}
