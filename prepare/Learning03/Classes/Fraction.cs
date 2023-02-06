namespace Learning03.Classes
{
    public class Fraction
    {
        // Attributes
        private int _top;
        private int _butt;

        // Constructors
        public Fraction()
        {
            _top = 1;
            _butt = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _butt = 1;
        }

        public Fraction(int top, int butt)
        {
            _top = top;
            _butt = butt;
        }

        // Getters & Setters
        public int GetTop()
        {
            return _top;
        }
        public int SetTop(int top)
        {
            _top = top;
            return top;
        }

        public int GetButt()
        {
            return _butt;
        }
        public int SetButt(int butt)
        {
            _butt = butt;
            return butt;
        }

        // Methods
        public string GetFractionString()
        {
            return this.GetTop() + "/" + this.GetButt();
        }

        public double GetDecimalValue()
        {
            return (double)this.GetTop() / (double)this.GetButt();
        }
    }
}