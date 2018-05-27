using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadDemo
{
    public class SimpleNotepad : INotepad
    {
        public const int DefaultPageCount = 10;

        private Page[] _pages;

        public SimpleNotepad(int numberPages)
        {
            if (numberPages <= 0)
            {
                numberPages = DefaultPageCount;
            }

            this._pages = new Page[numberPages];

            for (int i = 0; i < this._pages.Length; i++)
            {
                this._pages[i] = new Page("Page " + (i + 1));
            }
        }

        public virtual void WriteOnPage(int pageNumber, string text)
        {
            if (this.IsValidPageNumber(pageNumber) == true)
            {
                this._pages[pageNumber - 1].AddText(text);
            }
        }

        public virtual void OverwritePageText(int pageNumber, string text)
        {
            if (this.IsValidPageNumber(pageNumber) == true)
            {
                this._pages[pageNumber - 1].DeleteText();
                this._pages[pageNumber - 1].AddText(text);
            }
        }

        public virtual void DeletePageText(int pageNumber)
        {
            if (this.IsValidPageNumber(pageNumber))
            {
                this._pages[pageNumber - 1].DeleteText();
            }
        }

        public virtual void PrintAllPages()
        {
            for (int i = 0; i < this._pages.Length; i++)
            {
                Console.WriteLine(this._pages[i].ViewText());
                Console.WriteLine();
            }
        }

        private bool IsValidPageNumber(int pageNumber)
        {
            if (pageNumber > 0 && pageNumber <= this._pages.Length)
            {
                return true;
            }

            Console.WriteLine("Invalid page number! Please use any number from 1 to 10.");

            return false;
        }
    }
}
