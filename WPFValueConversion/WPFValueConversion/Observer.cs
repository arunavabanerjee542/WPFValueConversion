using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFValueConversion
{
    class Observer : INotifyPropertyChanged
    {
        private bool _isChecked;
        private Visibility _isVisible;

        public Observer()
        {
            _isChecked = true;
            _isVisible = Visibility.Visible;
        }

        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                updateVisible(value);
                OnPropertyChanged("IsChecked");

            }
        }
        public Visibility IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        public void updateVisible(bool b)
        {
            if(b==true)
            {
                IsVisible = Visibility.Visible;
            }
            else
            {
                IsVisible = Visibility.Hidden;
            }


        }


    }
}
