using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LiveDemo
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        private Person person;
        public Person TargetPerson
        {
            get { return person; }
            set { person = value; OnPropertyChanged(nameof(TargetPerson)); }
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }

        public void AddPerson(object person)
        {
            Persons.Add(TargetPerson);
            TargetPerson = new Person();
        }

        public void RemovePerson(object person)
        {
            Persons.Remove((Person)person);
        }

        public ICommand AddCommand => new RelayCommand(AddPerson, null);
        public ICommand DeleteCommand => new RelayCommand(RemovePerson, null);

        public MainVM()
        {
            Persons = new ObservableCollection<Person>();
            TargetPerson = new Person();
        }
    }
}
