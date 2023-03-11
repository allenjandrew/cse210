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
        public Activity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }

        // Methods
        protected void LoadingScreen(int seconds) // creates loading animation for ___ seconds
        {
            int spinnerMillisLeft = seconds * 1000;
            string[] spinnerKars =
            {
                ">   ",
                " >  ",
                "  > ",
                "   >",
                "   <",
                "  < ",
                " <  ",
                "<   ",
                // "-",
                // "\\",
                // "|",
                // "/",
            };
            int spinnerKarDuration = 125;
            while (spinnerMillisLeft > 0)
            {
                foreach (string kar in spinnerKars)
                {
                    Console.Write(kar);
                    Thread.Sleep(spinnerKarDuration);
                    Console.Write("\b\b\b\b    \b\b\b\b");
                    spinnerMillisLeft -= spinnerKarDuration;
                }
            }
        }

        protected void CountDownFrom(int seconds) // displays numbers counting down from ___ seconds
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        protected void StartActivity() // prints out summary w/ name and description; calls LoadingScreen(4)
        {
            Console.Clear();
            Console.Write($"Welcome to the {_activityName}!\n\n{_description}\n\n");
            LoadingScreen(4);
            SetDurationFromInput();
            Console.Write("Get ready...\n\n");
            LoadingScreen(4);
            Console.Clear();
        }

        private void SetDurationFromInput() // sets _duration from user input
        {
            Console.Write("How much time (in seconds) would you like to do this activity for?\n> ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        protected void EndActivity() // prints out summary of exercise w/ name and duration; calls LoadingScreen(4)
        {
            Console.Clear();
            Console.Write("Great job!\n\n");
            LoadingScreen(4);
            Console.Write($"You have completed {_duration} seconds of {_activityName}.\n\n");
            LoadingScreen(4);
        }

        public virtual void Execute() { }
    }
}
