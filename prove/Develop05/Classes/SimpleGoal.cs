namespace Develop05.Classes
{
    public class SimpleGoal : Goal
    {
        // Constructor
        public SimpleGoal(string name, string desc, int points)
            : base(name, desc, points) { }

        // Methods
        public override void RecordProgress()
        {
            _earned = GetPoints();
            _complete = true;
        }

        public override string ToString()
        {
            string s = "";
            s += $"name: {GetName()}\n";
            s += $"desc: {GetDesc()}\n";
            s += $"points: {GetPoints()}\n";
            s += $"earned: {GetEarned()}\n";
            s += $"complete: {IsComplete()}\n";
            return s;
        }
    }
}
