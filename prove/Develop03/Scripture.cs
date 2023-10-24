using System;
using System.Security.Cryptography;

//keeps track of both the reference and the text of the scripture; 
//can hide words and get the rendered display of the text
namespace Develop3 
{
    class Scripture
    {
        private int _randomWord;
        private Reference _reference;
        private string _scripture;
        private List<Word> _words;
        
        public Scripture(string scripture, Reference reference)
        {
            _scripture = scripture;
            _reference = reference;
            InitializeWords();
        }

        private void InitializeWords()
        {
            string[] scriptureWords = _scripture.Split(' ');
            _words = new List<Word>();
            foreach (string word in scriptureWords)
            {
                _words.Add(new Word(word));
            }
        }
        
        public void HideRandomWords()
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_words.Count);
            _words[index].Hide();
        }

        public void HideWord(string wordToHide)
        {
            foreach (Word word in _words)
            {
                if (word.GetText() == wordToHide && !word.IsHidden())
                {
                    word.Hide();
                    break;
                }
            }
        }
        
        public string GetDisplayText()
        {
            string displayText = _scripture;
            foreach (Word word in _words)
            {
                displayText = displayText.Replace(word.GetText(), word.GetText());
            }
            return displayText + $"\n{_reference.GetDisplayText()}";
        }
        
        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (word.IsHidden() == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}