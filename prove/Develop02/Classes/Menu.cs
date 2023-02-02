// Define class
public class Menu
{
    // Attributes
    public Journal _journal = new Journal();
    public PromptGenerator _prompter = new PromptGenerator();

    // Constructor
    public Menu()
    {
    }

    // Methods
    public void Run()
    {
        bool runApp = true;
        
        while (runApp)
        {
            Console.WriteLine($"Welcome! You are currently accessing {_journal._name}. What would you like to do?");
            Console.WriteLine("1. Free write\n2. Write from prompt\n3. Display journal\n4. Save file\n5. Save as …\n6. Open file …\n7. Create new journal\n8. Add new note\n9. Add new prompt\n10. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    _journal.CreateFreeWrite();
                    break;

                case 2:
                    _journal.CreateFromPrompt(_prompter);
                    break;
                
                case 3:
                    _journal.Display();
                    break;
                
                case 4:
                    _journal.Save();
                    break;
                
                case 5:
                    Console.Write("Please enter the filename: ");
                    string filename = Console.ReadLine();
                    _journal.SaveAs(filename);
                    break;
                
                case 6:
                    Console.Write("Please enter the filename: ");
                    string filename = Console.ReadLine();
                    _journal.Load(filename);
                    break;
                
                case 7:
                    Console.Write("Please enter a name for your Journal: ");
                    string name = Console.ReadLine();
                    Journal newJournal = new Journal();
                    newJournal._name = name;

                    Console.WriteLine($"Optionally, add any number of notes to {name}. Press <return> to add a note. Press <return> on blank to move on.");
                    while (true)
                    {
                        string newNote = Console.ReadLine();
                        if (newNote == "")
                        {
                            break;
                        }
                        newJournal.AddNote(newNote);
                    }

                    _journal = newJournal;
                    break;
                
                case 8:
                    Console.WriteLine("Enter your note:");
                    string newNote = Console.ReadLine();
                    if (newNote != "")
                    {
                        _journal.AddNote(newNote);
                    }
                    break;
                
                case 9:
                    Console.WriteLine("Enter the new prompt:");
                    string newPrompt = Console.ReadLine();
                    if (newPrompt != "")
                    {
                        _prompter.AddPrompt(newPrompt);
                    }
                    break;
                
                case 10:
                    Console.WriteLine("You have exited the app.");
                    runApp = false;
                    break;
                
                default:
                    break;
            }
        }
    }

}