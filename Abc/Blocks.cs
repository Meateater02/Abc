namespace Abc;

public class Blocks
{
    public List<Block> TwentyBlocks { get; }

    public Blocks()
    {
        TwentyBlocks = new List<Block>();
        InitialiseBlocks();
    }

    private void InitialiseBlocks()
    {
        var letters = new List<string>
        {
            "B O", "X K", "D Q", "C P", "N A", "G T", "R E", "T G", "Q D", "F S", "J W", "H U", "V I", "A N", "O B",
            "E R", "F S", "L Y", "P C", "Z M"
        };

        foreach (var t in letters)
        {
            var characters = t.ToCharArray();
            var block = new Block(characters[0], characters[2]);
            TwentyBlocks.Add(block);
        }
    }
}