using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new ConcurrentDictionary<string, int>();

            ConsoleKey _key;

            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("-\tНажмите \"1\" чтобы добавить книгу");
                Console.WriteLine("-\tНажмите \"2\" чтобы вывести список не прочитанного");
                Console.WriteLine("-\tНажмите \"3\" чтобы выйти");

                _key = Console.ReadKey().Key;

                if (_key == ConsoleKey.D1 || _key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Введите название книги:");
                    var succeed = books.TryAdd(Console.ReadLine(), 0);
                    if (succeed) Console.WriteLine("Книга успешно добавлена!");
                }

                if (_key == ConsoleKey.D2 || _key == ConsoleKey.NumPad2)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine($"{book.Key} - {book.Value}%");
                    }
                }

                Console.WriteLine();

                Task.Run(() =>
                {
                    while (true)
                    {
                        foreach (var item in books)
                        {
                            var key = item.Key;
                            var newValue = item.Value + 1;
                            if (newValue < 100) books.TryUpdate(key, newValue, item.Value);
                            else books.TryRemove(item);
                            Thread.Sleep(1000);
                        }
                        
                    }
                });

            }
            while (_key != ConsoleKey.D3 && _key != ConsoleKey.NumPad3);
        }
    }
}