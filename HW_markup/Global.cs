using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup
{
    internal class GLOBAL  //публичные поля конфигураций   активный пользователь
    {
        private static User _user;
        public static User User
        {
            get { return _user; }
            set { if(value!=null) _user = value; }
        }
    }
}
