using GlossaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelpText();
                return;
            }

            string command = args[0].ToLower();

            switch (command)
            {
                case "-lists":
                    var lists = WordList.GetLists();
                    foreach (var list in lists)
                    {
                        Console.WriteLine(list);
                    }
                    break;

                case "-new":
                    if (args.Length < 4)
                    {
                        Console.WriteLine("Ange minst två språk.");
                        return;
                    }
                    var newList = new WordList(args[1], args.Skip(2).ToArray());
                    newList.Save();
                    break;

                case "-add":
                    if (args.Length < 3)
                    {
                        Console.WriteLine("Ange listnamnet och översättningarna att lägga till.");
                        return;
                    }
                    var addList = WordList.LoadList(args[1]);
                    addList.Add(args.Skip(2).ToArray());
                    addList.Save();
                    break;

                case "-remove":
                    if (args.Length < 4)
                    {
                        Console.WriteLine("Ange listnamnet, språket och ordet att ta bort.");
                        return;
                    }
                    var removeList = WordList.LoadList(args[1]);
                    removeList.Remove(args[2]);
                    removeList.Save();
                    break;

                case "-words":
                    if (args.Length != 3)
                    {
                        Console.WriteLine("Ange listnamnet och språket att sortera efter.");
                        return;
                    }
                    var wordsList = WordList.LoadList(args[1]);
                    wordsList.List(Array.IndexOf(wordsList.Languages, args[2]), translations => Console.WriteLine(string.Join(" ", translations)));
                    break;

                case "-count":
                    if (args.Length != 2)
                    {
                        Console.WriteLine("Ange listnamnet.");
                        return;
                    }
                    var countList = WordList.LoadList(args[1]);
                    Console.WriteLine($"Antal ord i listan: {countList.Count()}");
                    break;

                case "-practice":
                    if (args.Length != 2)
                    {
                        Console.WriteLine("Ange listnamnet.");
                        return;
                    }
                    var practiceList = WordList.LoadList(args[1]);
                    var word = practiceList.GetWordToPractice();
                    Console.WriteLine($"Öva på detta ord: {word.Translations[word.FromLanguage]}");
                    Console.WriteLine($"Översätt till: {practiceList.Languages[word.ToLanguage]}");
                    break;

                default:
                    Console.WriteLine("Felaktigt kommando. Vänligen använd följande kommandon:");
                    PrintHelpText();
                    break;
            }
        }

        private static void PrintHelpText()
        {
            Console.WriteLine("Använd följande parametrar:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <langauge n>");
            Console.WriteLine("-add <list name> <translation 1> <translation 2> .. <translation n>");
            Console.WriteLine("-remove <list name> <language> <word>");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }
    }
}
