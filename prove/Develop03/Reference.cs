using System;

namespace Develop3 
{
    //keeps track of the book, chapter, and verse information
    class Reference
    {
        private string _reference;
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;
        
        private List<string> _scriptureReferences;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }

        public string GetBook()
        {
            return _book;
        }
        public int GetChapter()
        {
            return _chapter;
        }
        public int GetVerse()
        {
            return _verse;
        }
        public int GetEndVerse()
        {
            return _endVerse;
        }

    }
}