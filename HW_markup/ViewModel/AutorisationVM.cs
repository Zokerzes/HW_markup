using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.ViewModel
{
    internal class AutorisationVM
    {
        public string LoginUser { get; set; }
        public string PasswordUser  { get; set; }
        public User Auth()
        {
            if (LoginUser == null) return null;
            if (PasswordUser == null) return null;
            var context = new UsersDB();
            var access = context.Users.Where(x=>x.Login==LoginUser).FirstOrDefault();
            //context.Users.Where(delegate(User x) { return x.Login == CurentUser.Login; }).FirstOrDefault();
            if (access!=null && access.isAutorisation(PasswordUser)) //проверяем пароль
            {
                return access; // тип - User
            }
            return null;
        }
    }
}
