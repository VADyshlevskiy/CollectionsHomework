using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Shop
    {
        public readonly ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public Shop()
        {

        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(long id)
        {
            Item item1 = null;
            try
            {
                if (Items.Count != 0)
                {
                    foreach (var item in Items)
                    {
                        if (item.Id == id) item1 = item;
                    }
                    if (item1 != null) Items.Remove(item1);
                    else Console.WriteLine($"Ошибка! Товар с идентификационным номером {id} не найден.");
                }
                else Console.WriteLine("Ошибка! Список товаров пуст.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
