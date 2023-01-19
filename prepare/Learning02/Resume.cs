public class Resume
{
    public string _name = "";
    public List<Job> _jobList = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine(_name);
        foreach (var job in _jobList)
        {
            job.Display();
        }
    }
}