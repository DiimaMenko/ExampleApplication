using HomeListsHelper.Models;

namespace HomeListsHelper.Interfaces
{
    public interface IListManagementService
    {
        Task<ItemsList> GetListById(Guid listId);
    }
}
