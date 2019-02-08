using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObjectListViewSample
{
    class ObservableObject : INotifyPropertyChanged
    {
        // http://objectlistview.sourceforge.net/cs/recipes.html#can-i-get-rid-of-the-refreshobject-calls
        // https://stackoverflow.com/questions/35582162/how-to-implement-inotifypropertychanged-in-c-sharp-6-0
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // C# 6 null-safe operator
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // C# 5 - CallMemberName means we don't need to pass the property's name
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;

            OnPropertyChanged(propertyName);

            return true;
        }
    }
}
