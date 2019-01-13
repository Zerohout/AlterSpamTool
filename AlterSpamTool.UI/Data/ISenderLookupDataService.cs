using System.Collections.Generic;
using System.Threading.Tasks;
using AlterSpamTool.Model;

namespace AlterSpamTool.UI.Data
{
    public interface ISenderLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetSenderLookupAsync();
    }
}