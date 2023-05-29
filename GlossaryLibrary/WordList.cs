using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossaryLibrary
{
    public class WordList
    {
        private List<Word> words;

        public string Name { get; }
        public string[] Languages { get; }

        public IReadOnlyList<Word> Words
        {
            get { return words.AsReadOnly(); }
        }

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            words = new List<Word>();
        }

        public static string[] GetLists()
        {
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            directoryPath = Path.Combine(directoryPath, "GlossarySolution");

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            string[] files = Directory.GetFiles(directoryPath, "*.dat");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            }

            return files;
        }

        public static WordList LoadList(string name)
        {
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            directoryPath = Path.Combine(directoryPath, "GlossarySolution", name + ".dat");

            using (StreamReader reader = new StreamReader(directoryPath))
            {
                string[] languages = reader.ReadLine().Split(';');
                WordList wordList = new WordList(name, languages);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    wordList.Add(line.Split(';'));
                }

                return wordList;
            }
        }

        public void Save()
        {
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            directoryPath = Path.Combine(directoryPath, "GlossarySolution");

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            using (StreamWriter writer = new StreamWriter(Path.Combine(directoryPath, Name + ".dat")))
            {
                writer.WriteLine(string.Join(";", Languages));

                foreach (Word word in words)
                {
                    writer.WriteLine(string.Join(";", word.Translations));
                }
            }
        }


        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
                throw new ArgumentException("Felaktigt antal översättningar.");

            words.Add(new Word(translations));
        }

        public bool Remove(string word)
        {
            Word wordToRemove = words.Find(w => w.Translations.Any(t => t.Equals(word, StringComparison.OrdinalIgnoreCase)));

            if (wordToRemove != null)
            {
                words.Remove(wordToRemove);
                return true;
            }

            return false;
        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
        if (sortByTranslation < 0 || sortByTranslation >= Languages.Length)
        {
            throw new ArgumentException("Fel sortByTranslation index.");
        }

        List<Word> sortedWords = new List<Word>(words);
        sortedWords.Sort((w1, w2) => string.Compare(w1.Translations[sortByTranslation], w2.Translations[sortByTranslation], StringComparison.OrdinalIgnoreCase));

        foreach (Word word in sortedWords)
        {
            showTranslations(word.Translations);
        }
    }

        public Word GetWordToPractice()
        {
            if (words.Count == 0)
                return null;

            Random random = new Random();
            int randomIndex = random.Next(words.Count);
            int fromLanguage = random.Next(Languages.Length);
            int toLanguage;
            do
            {
                toLanguage = random.Next(Languages.Length);
            } while (toLanguage == fromLanguage);

            Word wordToPractice = new Word(fromLanguage, toLanguage, words[randomIndex].Translations);
            return wordToPractice;
        }
    }


}
