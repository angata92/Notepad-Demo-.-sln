using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadDemo
{
    public class Page
    {
        private string _title;

        private string _text;

        public Page(string title, string text)
        {
            this._title = title;
            this._text = text;
        }

        public Page(string title)
            : this(title, string.Empty)
        {
        }

        public void AddText(string text)
        {
            this._text = this._text + text;
        }

        public void DeleteText()
        {
            this._text = string.Empty;
        }

        public string ViewText()
        {
            return this._title + Environment.NewLine + this._text;
        }
    }
}
