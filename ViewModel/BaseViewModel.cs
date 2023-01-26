using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMobileClone.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool _isBusy;
        string _title;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (value == IsBusy)
                    return;
                _isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }

        public bool IsNotBusy => !_isBusy;

        public string Title
        {
            get => _title;
            set
            {
                if(value == _title) return;
                _title = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
