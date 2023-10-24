using System;
using System.Security.Cryptography;

namespace Develop3 
{
    class Scripture
    {
        private Reference _reference;
        private string _scripture;
        private List<Word> _words;
        
        public Scripture(string scripture, Reference reference)
        {
            _scripture = scripture;
            _reference = reference;
            CreateWordsList();
        }

        private void CreateWordsList()
        {
            string[] scriptureWords = _scripture.Split(' ');
            _words = new List<Word>();
            foreach (string word in scriptureWords)
            {
                _words.Add(new Word(word));
            }
        }
        
        public void HideRandomWord()
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_words.Count);
            while (_words[index].IsHidden() == true)
            { 
                index = randomGenerator.Next(_words.Count);
            }
            _words[index].Hide();
        }
        
        public string GetDisplayText()
        {
            string displayText = _scripture;
            foreach (Word word in _words)
            {
                displayText = displayText.Replace(word.GetWordText(), word.GetDisplayText());
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