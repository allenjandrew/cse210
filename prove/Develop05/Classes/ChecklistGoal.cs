namespace Develop05.Classes
{
    public class ChecklistGoal : Goal
    {
        // Attributes
        private int _timesToComplete;
        private int _completionBonus;

        // Constructors
        public ChecklistGoal(
            int timesToComplete,
            int completionBonus,
            string name,
            string description,
            int points
        )
            : base(name, description, points)
        {
            _timesToComplete = timesToComplete;
            _completionBonus = completionBonus;
        }

        // Methods
        public override void RecordProgress()
        {
            if (!IsComplete())
            {
                AddEarned(GetPoints());
                IncreaseTimesCompleted();
                if (GetTimesCompleted() == _timesToComplete)
                {
                    AddEarned(_completionBonus);
                    MarkComplete();
                }
            }
        }

        public override string ToString()
        {
            return $"[{GetTimesCompleted()}/{_timesToComplete}] {GetName()} - {GetDescription()}";
        }

        public override string GetSummary()
        {
            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPoints: {GetPoints()}\nEarned: {GetEarned()}\nTimes Completed: {GetTimesCompleted()}\nTimes To Complete: {_timesToComplete}";
        }
    }
}
