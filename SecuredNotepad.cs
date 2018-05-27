using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadDemo
{
    public class SecuredNotepad : SimpleNotepad
    {
        private string _password;

        public SecuredNotepad(int pageCount, string password)
            : base(pageCount)
        {
            this._password = password;
        }

        private bool CheckPassword()
        {
            // The user enters password
            Console.WriteLine("Enter password: ");
            
            // reading password
            string enteredPassword = Console.ReadLine();

            //compare the password with the one in the notepad
            if (enteredPassword == this._password)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Wrong password!");

                return false;
            }
        }

        public override void WriteOnPage(int pageNumber, string text)
        {
            if (this.CheckPassword() == true)
            {
                base.WriteOnPage(pageNumber, text);
            }
        }

        public override void OverwritePageText(int pageNumber, string text)
        {
            if (this.CheckPassword() == true)
            {
                base.OverwritePageText(pageNumber, text);
            }
        }

        public override void DeletePageText(int pageNumber)
        {
            if (this.CheckPassword() == true)
            {
                base.DeletePageText(pageNumber);
            }
        }

        public override void PrintAllPages()
        {
            if (this.CheckPassword() == true)
            {
                base.PrintAllPages();
            }
        }
    }
}
