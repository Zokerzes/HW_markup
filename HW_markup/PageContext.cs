using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HW_markup
{
    internal class PageContext : NotifyClass
    {
        private Stack<UserControl> _pages = new Stack<UserControl>();
        public UserControl CurrentPage { get; private set; }

        public void AddPage(UserControl page)
        {
            _pages.Push(page);
            CurrentPage = page;
            OnPropertyChanged("CurrentPage");
        }

        public void DropPage()
        {
            _pages.Pop();
            CurrentPage = _pages.Peek();
            OnPropertyChanged("CurrentPage");
        }

    }
}
