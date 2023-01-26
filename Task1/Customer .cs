using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Customer
    {
        private Shop _shop;
        private string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public void Subscribe(Shop shop)
        {
            _shop = shop;
            _shop.Items.CollectionChanged += OnItemChanged;
            Console.WriteLine($"{_name}: подписался");
        }

        private void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Item Additem = (Item)e.NewItems[0];
                    Console.WriteLine($"{_name}, у нас появился новый товар: {Additem.Name} {Additem.Id}");
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Item Removeitem = (Item)e.OldItems[0];
                    Console.WriteLine($"{_name}, товар {Removeitem.Name} {Removeitem.Id} продан");
                    break;
            }
        }
    }
}
