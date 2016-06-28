using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoYoutube.Common
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}