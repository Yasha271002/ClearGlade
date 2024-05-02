using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClearGlade.Model
{
    
    public class SumNumberModel : INotifyPropertyChanged
    {
        private int _countTickets = 1;
        private int _priceOfTicket = 100;
        private int _sum;
        public int Num
        {
            get => _countTickets;
            set
            {
                _countTickets = value;
                OnPropertyChanged();
            }
        }

        public int Price
        {
            get => _priceOfTicket;
            set
            {
                _priceOfTicket = value;
                OnPropertyChanged();
            }
        }

        public int Sum
        {
            get => _sum = _countTickets * _priceOfTicket;
            set
            {
                _sum = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
