using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/*
    INotifyPropertyChanged - mainly used for updating the UI when binding

 */

namespace FacturaReminder.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
