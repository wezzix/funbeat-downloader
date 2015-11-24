using System;
using System.ComponentModel;
using System.Linq.Expressions;
using MK.Funbeat.Utilities;
using PropertyChanged;

namespace MK.Funbeat
{
    /// <summary>
    /// Automatically implements INotifyPropertyChanged for data binding scenarios
    /// using PropertyChanged.Fody.
    /// </summary>
    [ImplementPropertyChanged]
    [Serializable]
    public abstract class Bindable : INotifyPropertyChanged
    {
        /// <summary>
        /// Indicates if the entity has changed. Must be reset manually.
        /// Automatically implemented by PropertyChanged.Fody.
        /// </summary>
        public virtual bool IsChanged { get; set; }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged<TProperty>(Expression<Func<TProperty>> property)
        {
            OnPropertyChanged(property.GetMemberName());
        }
    }
}