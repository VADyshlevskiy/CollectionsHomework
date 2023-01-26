namespace Task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Customer _customer = new Customer("Валерий");
            _customer.Subscribe(shop);                                                                                     //Подписался на магазин

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("-\tНажмите \"А\" чтобы добавить товар");
            Console.WriteLine("-\tНажмите \"D\" чтобы удалить товар");
            Console.WriteLine("-\tНажмите \"X\" чтобы выйти");

            ConsoleKey _key;

            do
            {
                _key = Console.ReadKey().Key;

                if (_key == ConsoleKey.F)
                {
                    Console.WriteLine("Введите название товара и идентификационный номер в формате \"YYYYMMDDHHMMSS\"");
                    var str = Console.ReadLine().Split(' ');

                     shop.Add(new Item(str[0], Convert.ToInt64(str[1])));
                }

                if (_key == ConsoleKey.D)
                {
                    Console.WriteLine("Введите идентификационный номер товара");
                    shop.Remove(Convert.ToInt64(Console.ReadLine()));
                }

            }
            while (_key != ConsoleKey.X);
        }
    }
}