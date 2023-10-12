class Scripture
{
    private int _randomWord;
    private string _reference;
    private string _scriptures;
    private List<string> _scriptureList;
    
    public void HideRandomWords()
    {

    }
    
    public string GetDisplayText()
    {

    }
    
    public bool IsCompletelyHidden()
    {

    }
    
    
    
    
    
    
    
    
    private List<string> _scriptureTexts;

    public List<string> GetScriptureTexts()
    {
        return _scriptureTexts;
    }



    public void AddOriginalScriptures()
    {
        using (StreamWriter outputFile = new StreamWriter("ScriptureStorage.xlsx"))
        {
            outputFile.WriteLine("Moses||1||39||For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
            outputFile.WriteLine("Moses||7||18||And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
            outputFile.WriteLine("Abraham||3||22-23||Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones;||And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.");
            outputFile.WriteLine("Genesis||1||26-27||And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth.||So God created man in his own image, in the image of God created he him; male and female created he them.");
            outputFile.WriteLine("Genesis||2||24||Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.");
            outputFile.WriteLine("Genesis||39||9||There is none greater in this house than I; neither hath he kept back any thing from me but thee, because thou art his wife: how then can I do this great wickedness, and sin against God?");
            outputFile.WriteLine("Exodus||19||5-6||Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me above all people: for all the earth is mine:||And ye shall be unto me a kingdom of priests, and an holy nation. These are the words which thou shalt speak unto the children of Israel.");
            outputFile.WriteLine("Joshua||24||15||And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.");
        }
    }

    public void LoadScripturesFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");
            book = parts[0];
            chapter = parts[1];
            verses = parts[2];
            _scriptureTexts = parts[3];

        }
    }
    /*public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }*/

    /*public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            AddEntry(newEntry);
        }
    }*/
}