using System;
using System.ComponentModel;

namespace BrainAnalysis
{
    public class AppViewModelBase : INotifyPropertyChanged
    {
        protected AppViewModelBase()
        {

        }

        #region INotifyPropertyChanged

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}