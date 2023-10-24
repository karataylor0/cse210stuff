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
            Console.Write(_text);
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
        public string GetWordText()
        {
            return _text;
        }
    }
}