using HW_markup.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup
{
    internal class UserContext
    {
        public UserContext(User user)
        {
            _user = user;
            _currentUserContext = this;  // не очень понятно
        }


        private User _user;                                 
        public User User
        {
            get { return _user; }
        }


        private static UserContext _currentUserContext;
        public static UserContext CurrentUserContext    //текущий пользователь
        {
            get { return _currentUserContext; }
            set
            {
                if (_currentUserContext == null)
                {
                    _currentUserContext = value;
                    OnPropertyChanged();                // Статический NotifyPropertyChanged
                }
            }
        }


        public void ClearUser()
        {
            _currentUserContext = null;
        }

        // Статический NotifyPropertyChanged
        public static event PropertyChangedEventHandler PropertyChanged;
        protected static void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(CurrentUserContext, new PropertyChangedEventArgs(property));
        }
    }
}
