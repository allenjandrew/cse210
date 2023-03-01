namespace Develop04.Classes
{
    // Define Class
    public class Activity
    {
        // Attributes
        protected string _activityName;
        protected string _description;
        protected int _duration; // measured in seconds

        // Constructors
        public Activity(activityName, description)
        {
            _activityName = activityName
            _description = description
        }

        // Methods
        protected void LoadingScreen(int seconds) // creates loading animation for ___ seconds
        {
            return;
        }

        protected void CountDownFrom(int seconds) // displays numbers counting down from ___ seconds
        {
            return;
        }

        public void StartActivity() // prints out summary w/ name and description; calls LoadingScreen(5)
        {
            return;
        }

        public void SetDurationFromInput() // sets _duration from user input
        {
            return;
        }

        public void EndActivity() // prints out summary of exercise w/ name and duration; calls LoadingScreen(5)
        {
            return;
        }
    }
}