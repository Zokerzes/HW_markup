using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.Model
{
    internal class UsersDB
    {
        
        public List<User> Users { get; set; } = new List<User>()
        {
            new User("Вася","user111","123"),
            new User("Петя","user222","234"),
            new User("Коля","user333","345"),
            new User("Ваня","user444","456"),
            new User("Маша","user555","567"),         //вместо конструктора
        };
    }
}
