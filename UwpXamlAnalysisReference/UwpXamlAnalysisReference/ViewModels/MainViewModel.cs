using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpXamlAnalysisReference.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<T>(T value, string propertyName)
        {
        }
    }
}
