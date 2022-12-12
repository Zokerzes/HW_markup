using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HW_markup.ViewModel
{
    internal class AutorisationVM : NotifyClass
    {
        const Int16 FAIL_cound = 3; //кол-во попыток ввода
        const Int16 PAUSE = 10;     //время блокивровки авторизации сек.

        public AutorisationVM()
        {
            Message = $"У Вас {FAIL_cound} попытки(ток)";
            IsEnableAuth = true;
            Failcound = FAIL_cound;
            //Failcound = FAIL_cound+1;
            //OnPropertyChanged("FAIL_cound");
        }
        public string LoginUser { get; set; }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value; /*OnPropertyChanged("UserName");*/
                OnPropertyChanged();
            }
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        private Int16 _failcound;
        public Int16 Failcound
        {
            get { return _failcound; }
            set
            {
                if (value > 0)
                {
                    _failcound = value;
                    //_failcound--;
                    Message = $"Кол-во не удачных попыток {_failcound}";
                }
                else
                {
                    var t = StartPause();
                    _failcound = FAIL_cound;
                }

            }
        }

        private bool _isEnableAuth;
        public bool IsEnableAuth
        {
            get { return _isEnableAuth; } 
            set 
            { 
                _isEnableAuth = value; 
                OnPropertyChanged(); 
            } 
        }



        public bool Auth(string password)
        {
            if (LoginUser == null) return false;    //логин не пустой
            if (password == null) return false;
            var context = new UsersDB();            //создаем список пользователей
            var access = context.Users.Where(x => x.Login == LoginUser).FirstOrDefault();
            //context.Users.Where(delegate(User x) { return x.Login == CurentUser.Login; }).FirstOrDefault();
            if (access != null && access.isAutorisation(password)) //проверяем пароль
            {
                GLOBAL.User = access; // acess тип - User
                UserName = access.Name;
                return true; //авторизация успешна флаг тру
            }
            Failcound--;
            return false;
        }
        private async Task StartPause()
        {
            IsEnableAuth = false;
            for (int i = PAUSE; i >= 0; i--)
            {
                Message = $"авторизация заблокирована на {i} сек.";

                await Task.Delay(1000);
            }
            // OnPropertyChanged(Message);
            IsEnableAuth = true;
            Message = "Повторите попытку";

        }

    }
}
