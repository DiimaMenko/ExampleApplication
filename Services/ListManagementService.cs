using HomeListsHelper.Data;
using HomeListsHelper.Interfaces;
using HomeListsHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeListsHelper.Services
{
    public class ListManagementService : IListManagementService
    {
        private ApplicationDbContext _dbContext { get; }

        public ListManagementService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<ItemsList> GetListById(Guid listId)
        {
            return await _dbContext.ItemsLists.FirstOrDefaultAsync(x => x.Id == listId);
        }
    }
}
