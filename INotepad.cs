using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadDemo
{
    public interface INotepad
    {
        void WriteOnPage(int pageNumber, string text);

        void OverwritePageText(int pageNumber, string text);

        void DeletePageText(int pageNumber);

        void PrintAllPages();
    }
}
