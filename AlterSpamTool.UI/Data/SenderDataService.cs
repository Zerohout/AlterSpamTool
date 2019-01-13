using System;
using AlterSpamTool.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AlterSpamTool.DataAccess;

namespace AlterSpamTool.UI.Data
{
    /// <summary>
    /// Cервис данных сущности "Отправитель"
    /// </summary>
    public class SenderDataService : ISenderDataService
    {
        private Func<AlterSpamToolDbContext> _contextCreator;

        public SenderDataService(Func<AlterSpamToolDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<List<Sender>> GetAllAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Senders.AsNoTracking().ToListAsync();
            }
        }
    }
}
