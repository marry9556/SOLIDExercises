using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Book
    {
        private string _name;
        private string _author;
        private string _text;

        public Book()
        {
            this._name = "Fiction";
            this._author = "George R.R. Martin";
            this._text = "Lannister always pays his debts!!";
        }

        public String replaceWordInText(String word)
        {
            return _text.Replace(word, _text);
        }

        public bool isWordInText(String word)
        {
            return _text.Contains(word);
        }
    }
}
