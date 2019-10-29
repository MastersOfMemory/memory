using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastersofMemory.ViewModel
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string nameProperty)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(nameProperty)); //Als de handler geen null aangeeft, wordt de waarde geupdated
        }

        //Variabelen worden automatisch aangepast door deze Observable Object, 
        //dit komt door de inheritance van de inteface 'INotifyPropertyChanged'
    }
}
