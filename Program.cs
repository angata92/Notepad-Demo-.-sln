using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notepad Demo....");
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("Creating Simple Notepad...");

            Console.WriteLine("Enter pages count for Simple Notepad: ");
            int simpleNotepadPagesCount = int.Parse(Console.ReadLine());

            INotepad simpleNotepad = new SimpleNotepad(simpleNotepadPagesCount);

            for (int i = 1; i <= simpleNotepadPagesCount; i++)
            {
                simpleNotepad.WriteOnPage(i, "Page " + i + " text...");
            }

            simpleNotepad.PrintAllPages();

            Console.WriteLine();

            Console.WriteLine("Creating Secured Notepad...");

            Console.WriteLine("Enter pages count for Secured Notepad: ");
            int securedNotepadPagesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter password for Secured Notepad: ");
            string securedNotepadPassword = Console.ReadLine();

            INotepad securedNotepad = new SecuredNotepad(securedNotepadPagesCount, securedNotepadPassword);

            for (int i = 1; i <= securedNotepadPagesCount; i++)
            {
                securedNotepad.WriteOnPage(i, "Page " + i + " text...");
            }

            securedNotepad.PrintAllPages();

            Console.ReadLine();
        }
    }
}
