using AlterSpamTool.Model;
using AlterSpamTool.UI.Data;
using System.Collections.ObjectModel;

namespace AlterSpamTool.UI.ViewModel
{
    /// <summary>
    /// Основная модель представления
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Конструктор основной модели представления
        /// </summary>
        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }
        
        /// <summary>
        /// Загрузка данных
        /// </summary>
        public async void LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

        public INavigationViewModel NavigationViewModel { get; }
    }
}
