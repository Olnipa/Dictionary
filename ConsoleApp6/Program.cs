namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

            dictionary.Add("Чебурек", "Жаренный в масле плоский пирожок из тонкого пресного теста с начинкой из бараньего фарша с острыми приправами.");
            dictionary.Add("Чебурашка", "То же, что ванька-встанька");

            Console.WriteLine("Добро пожаловать в краткий словарь Ожигова.");

            while (isOpen)
            {
                string choosenMenu = ReadWord("\nВыберите действие:\n\n" +
                    "1 - Найти значение слова\n2 - Вывести все слова в словаре\n0 - Выйти из словаря\n\nВведите значение:");

                switch (choosenMenu)
                {
                    case "1":
                        string word = ReadWord("\nВведите слово: ");

                        WriteDefinition(dictionary, word);

                        break;
                    case "2":

                        WriteDictionaryKeys(dictionary);

                        break;
                    case "0":
                        isOpen = false;
                        break;
                }

                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string ReadWord(string text)
        {
            Console.Write(text);
            string value = Console.ReadLine();
            return value;
        }

        static void WriteDefinition(Dictionary<string, string> dictionary, string word)
        {
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine($"\n{word} - {dictionary[word]}");
            }
            else
            {
                Console.WriteLine($"\nИзвините, слова {word} в данном словаре пока нет.");
            }
        }

        static void WriteDictionaryKeys(Dictionary<string, string> dictionary)
        {
            int i = 1;

            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }
        }
    }
}