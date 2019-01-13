using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlterSpamTool.DataAccess;
using AlterSpamTool.Model;

namespace AlterSpamTool.UI.Data
{
    public class LookupDataService : ISenderLookupDataService
    {
        private Func<AlterSpamToolDbContext> _contextCreator;

        public LookupDataService(Func<AlterSpamToolDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetSenderLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Senders.AsNoTracking()
                    .Select(s =>
                        new LookupItem
                        {
                            Id = s.Id,
                            DisplayMember = s.Name
                        })
                    .ToListAsync();
            }
        }
    }
}
