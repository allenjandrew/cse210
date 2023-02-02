using System;
using Develop02.Classes;

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