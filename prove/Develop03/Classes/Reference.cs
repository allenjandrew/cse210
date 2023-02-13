namespace Develop03.Classes
{
    // Define Class
    public class Reference
    {
        // Attributes
        private string _book {get; set;}
        private int _chapter {get; set;}
        private List<int> _verses = new List<int>();

        // Constructors
        public Reference(string value)
        {
            List<string> splits = new List<string>(value.split(" "));
            string numbers = splits[-1];
            splits.RemoveAt(-1);
            string name = splits.Join(" ");
            List<string> splits2 = new List<string>(numbers.split(":"));
            int chapter = int.Parse(splits2[0]);
            string verses = splits2[-1];


        }
    }
}