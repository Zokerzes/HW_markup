using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.ViewModel
{
    internal class AutorisationVM : NotifyClass
    {
        public string LoginUser { get; set; }
        public string PasswordUser  { get; set; }
        private string _userName;
        public string UserName {    get {return _userName;}
                                    set { _userName = value; OnPropertyChanged("UserName"); } }
        public bool Auth()
        {
            if (LoginUser == null) return false;    //логин не пустой
            if (PasswordUser == null) return false; // пароль не пустой
            var context = new UsersDB();            //создаем список пользователей
            var access = context.Users.Where(x=>x.Login==LoginUser).FirstOrDefault();
            //context.Users.Where(delegate(User x) { return x.Login == CurentUser.Login; }).FirstOrDefault();
            if (access!=null && access.isAutorisation(PasswordUser)) //проверяем пароль
            {
                GLOBAL.User = access; // acess тип - User
                return true; //авторизация успешна флаг тру
            }
            return false;
        }
    }
}
