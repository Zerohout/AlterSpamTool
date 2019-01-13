using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AlterSpamTool.UI.ViewModel
{
    /// <summary>
    /// Основа модели представления
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие при изменении свойства компонента
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Подписка на событие при изменении свойства компонента
        /// </summary>
        /// <param name="propertyName">Имя свойства компонента</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}