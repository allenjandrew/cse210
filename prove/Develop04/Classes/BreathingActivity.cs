namespace Develop04.Classes
{
    // Define Class
    public class BreathingActivity : Activity
    {
        // Attributes
        // none

        // Constructors
        BreathingActivity()
            : base(
                "Breathing Activity",
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
            )
        {
            base.SetDurationFromInput();
        }

        // Methods
        public void BreatheIn() // display "Breathe in..." and call base.CountDownFrom(8)
        {
            return;
        }

        public void BreatheOut() // display "Breathe out..." and call base.CountDownFrom(12)
        {
            return;
        }
    }
}
