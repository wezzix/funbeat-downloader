using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace MK.Funbeat.Utilities
{
    public static class ControlExtensions
    {
        public static void Bind<TControl, TControlProperty, TTarget, TTargetProperty>(
            this TControl control,
            Expression<Func<TControl, TControlProperty>> controlProperty,
            TTarget target,
            Expression<Func<TTarget, TTargetProperty>> targetProperty,
            bool formattingEnabled = true,
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
            where TControl : Control
            where TTarget : INotifyPropertyChanged
        {
            var controlPropertyName = control.GetPropertyInfo(controlProperty).Name;
            var targetPropertyName = target.GetPropertyInfo(targetProperty).Name;
            control.DataBindings.Add(controlPropertyName, target, targetPropertyName, formattingEnabled, updateMode);
        }
    }
}