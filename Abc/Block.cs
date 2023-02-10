namespace Abc;

public class Block
{
    public List<char> Letters { get; }
    public bool IsUsed { get; set; }

    public Block(char firstLetter, char secondLetter)
    {
        Letters = new List<char>
        {
            firstLetter,
            secondLetter
        };

        IsUsed = false;
    }
}