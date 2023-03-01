namespace Develop04.Classes
{
    // Define Class
    public class ListingActivity : Activity
    {
        // Attributes
        private List<string> _promptList = List<string>(
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        );

        // Constructors
        public ListingActivity()
            : base(
                "Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
            ) { }

        // Methods
        public void GeneratePrompt() // Gets a random item out of _promptList and prints it on screen
        {
            return;
        }

        public List<string> UserListsItems() //  Prompts user for answers to question for _duration amount of times
        {
            return;
        }

        public void DisplayNumItems() // Displays the number of items in the List returned by UserListsItems
        {
            return;
        }
    }
}
