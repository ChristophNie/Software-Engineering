using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        private string _VName;
        private string _NName;
        private string _Alter;

        public string VName 
        { 
            get { return _VName; }
            set { _VName = value;  OnPropertyChanged(nameof(VName)); }
        
        }
        public string NName
        {
            get { return _NName; }
            set { _NName = value; OnPropertyChanged(nameof(NName)); }

        }
        public string Alter
        {
            get { return _Alter; }
            set { _Alter = value; OnPropertyChanged(nameof(Alter)); }

        }
        public Person()
        {

        }
    }
}
