using System;

//keeps track of a single word and whether it is shown or hidden
namespace Develop3
{
    class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }
        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            //Show word code.
        }

        public bool IsHidden()
        {
            //return true if hidden, false if shown
            return _isHidden;
        }

        public string GetText()
        {
            //return display text, underscores if hidden, word if not
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }
}