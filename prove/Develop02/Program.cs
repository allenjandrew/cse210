using System;
using Develop02.Classes;

/* I have exceeded requirements by: adding a ton of prompts to my prompt generator; allowing the user to write
    with or without a prompt; storing the filename in a variable so the user only has to save the file (without
    entering a new filename every time); providing a save as ... option; providing an open file ... option;
    allowing the user to add new global notes to their journal; allowing the user to add a new prompt; etc.
*/

namespace Develop02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();
            mainMenu.StartUp();
            mainMenu.Run();
        }
    }
}
