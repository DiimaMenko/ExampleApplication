namespace HomeListsHelper.Interfaces
{
    public interface IListCalculationService
    {
        Task<decimal> GetTotalAmount(Guid listId);
    }
}
