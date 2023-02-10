// See https://aka.ms/new-console-template for more information

using Abc;

WordBlockChecker word = new WordBlockChecker();

Console.WriteLine(">>> can_make_word(\"A\")");
Console.WriteLine(word.CanMakeWord("A"));
Console.WriteLine(">>> can_make_word(\"Bark\")");
Console.WriteLine(word.CanMakeWord("Bark"));
Console.WriteLine(">>> can_make_word(\"bOOk\")");
Console.WriteLine(word.CanMakeWord("bOOk"));
Console.WriteLine(">>> can_make_word(\"TREAT\")");
Console.WriteLine(word.CanMakeWord("TREAT"));
Console.WriteLine(">>> can_make_word(\"COMMON\")");
Console.WriteLine(word.CanMakeWord("COMMON"));
Console.WriteLine(">>> can_make_word(\"SQUAD\")");
Console.WriteLine(word.CanMakeWord("SQUAD"));
Console.WriteLine(">>> can_make_word(\"CONFUSE\")");
Console.WriteLine(word.CanMakeWord("CONFUSE"));