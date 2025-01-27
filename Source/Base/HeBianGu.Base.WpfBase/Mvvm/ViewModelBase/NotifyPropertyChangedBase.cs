﻿using System.ComponentModel;

namespace HeBianGu.Base.WpfBase
{
    public abstract class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        #region - MVVM -

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
