using System.Collections.Generic;
using System.Threading.Tasks;
using AlterSpamTool.Model;

namespace AlterSpamTool.UI.Data
{
    /// <summary>
    /// Интерфейс сервиса данных сущности "Отправитель"
    /// </summary>
    public interface ISenderDataService
    {
        Task<List<Sender>> GetAllAsync();
    }
}