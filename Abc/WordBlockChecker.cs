using System.Collections;

namespace Abc;

public class WordBlockChecker
{
    private readonly Blocks _blocks;
    
    public WordBlockChecker()
    {
        _blocks = new Blocks();
    }

    public bool CanMakeWord(string word)
    {
        ResetBlockUsed();

        //loop through each letter in the given word
        foreach (var letter in word.Select(char.ToUpper))
        {
            var letterChecked = false;
            
            //loop through all blocks
            foreach (var block in _blocks.TwentyBlocks.Where(block => !block.IsUsed && block.Letters.Contains(letter)))
            {
                letterChecked = true;
                block.IsUsed = true;
                break;
            }

            if (!letterChecked)
            {
                return false;
            }
        }

        return true;
    }

    private void ResetBlockUsed()
    {
        foreach (var block in _blocks.TwentyBlocks)
        {
            block.IsUsed = false;
        }
    }
}