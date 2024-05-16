using HomeListsHelper.Interfaces;

namespace HomeListsHelper.Services
{
    public class ListCalculationService : IListCalculationService
    {
        private readonly IListManagementService _listManagementService;

        public ListCalculationService(IListManagementService listManagementService)
        {
            _listManagementService = listManagementService ?? throw new ArgumentNullException(nameof(listManagementService));
        }

        public async Task<decimal> GetTotalAmount(Guid listId)
        {
            var itemsList = await _listManagementService.GetListById(listId);

            return itemsList.Items.Sum(x => (x.Price ?? 0) * (x.Amount ?? 0));
        }
    }
}
