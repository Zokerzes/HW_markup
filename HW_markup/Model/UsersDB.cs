using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.Model
{
    internal class UsersDB
    {
        private static UsersDB _context;
        public static UsersDB Context => _context ?? (_context = new UsersDB());

        private UsersDB()
        {
            Orders = new ObservableCollection<Order>()
            {
                new Order()
                {
                    Id = 1, Client="Кантов", Date =new DateTime(2022,12,10),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                         new OrderProduct(){ Product=Products.First(x=>x.Id==1), Quantity=2},
                         new OrderProduct(){ Product=Products.First(x=>x.Id==2), Quantity=2},
                         new OrderProduct(){ Product=Products.First(x=>x.Id==4), Quantity=2 },
                         new OrderProduct(){ Product=Products.First(x=>x.Id==5), Quantity=5},
                         new OrderProduct(){ Product=Products.First(x=>x.Id==6), Quantity=1}
                    }
                },

                new Order()
                {
                    Id = 2, Client="Тарин", Date =new DateTime(2022,10,23),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                         new OrderProduct(){ Product=Products.First(x=>x.Id==4), Quantity=4},
                         new OrderProduct(){ Product=Products.First(x=>x.Id==5), Quantity=1},
                         new OrderProduct(){ Product=Products.First(x=>x.Id==6), Quantity=2}
                    }
                },

                new Order()
                {
                    Id = 3, Client="Котова", Date =new DateTime(2022,11,4),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                            new OrderProduct(){ Product=Products.First(x=>x.Id==1), Quantity=1},
                            new OrderProduct(){ Product=Products.First(x=>x.Id==2), Quantity=1},
                            new OrderProduct(){ Product=Products.First(x=>x.Id==3), Quantity=1},
                            new OrderProduct(){ Product=Products.First(x=>x.Id==6), Quantity=2}
                    }
                },

                new Order()
                {
                    Id = 4, Client="Сидорина", Date =new DateTime(2022,12,5),
                    Products = new ObservableCollection<OrderProduct>()
                    {
                            new OrderProduct(){ Product=Products.First(x=>x.Id==1), Quantity=1},
                            new OrderProduct(){ Product=Products.First(x=>x.Id==4), Quantity=2},
                            new OrderProduct(){ Product=Products.First(x=>x.Id==5), Quantity=4},
                            new OrderProduct(){ Product=Products.First(x=>x.Id==6), Quantity=1}
                    }
                },
            };
        }

        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>()
        {
            new User("Вася","user111","123"),
            new User("Олег","u","1"),
            new User("Петя","user222","234"),
            new User("Коля","user333","345"),
            new User("Ваня","user444","456"),
            new User("Маша","user555","567"),         //вместо конструктора
        };
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>()
        {
            new Product() {Id=1, Name="конфета шоколадная",              Price=100M },
            new Product() {Id=2, Name="конфета леденец",                 Price=124M },
            new Product() {Id=3, Name="конфета \"рачки\"",               Price=132M },
            new Product() {Id=4, Name="конфета \"белочка\"",             Price=230M },
            new Product() {Id=5, Name="торт \"чайка\"",                  Price=400M },
            new Product() {Id=6, Name="торт \"Графские Развалины\"",     Price=608M }
        };

        public ObservableCollection<Order> Orders { get; set; }
    }
}
