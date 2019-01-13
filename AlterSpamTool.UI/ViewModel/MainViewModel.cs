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
        public MainViewModel(IEditPanelViewModel editPanelViewModel)
        {
            EditPanelViewModel = editPanelViewModel;
        }
        
        /// <summary>
        /// Загрузка данных
        /// </summary>
        public async void LoadAsync()
        {
            await EditPanelViewModel.LoadAsync();
        }

        public IEditPanelViewModel EditPanelViewModel { get; }
    }
}
