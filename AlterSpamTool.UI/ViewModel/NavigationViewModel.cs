using AlterSpamTool.Model;
using AlterSpamTool.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AlterSpamTool.UI.ViewModel
{
    public class NavigationViewModel : INavigationViewModel
    {
        private ISenderLookupDataService _senderDataService;

        public NavigationViewModel(ISenderLookupDataService senderDataService)
        {
            _senderDataService = senderDataService;
            Senders = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _senderDataService.GetSenderLookupAsync();

            Senders.Clear();

            foreach (var item in lookup)
            {
                Senders.Add(item);
            }
        }

        public ObservableCollection<LookupItem> Senders { get; }
    }
}
