using Settlements.Models;

namespace Settlements.Repositories
{
    public interface ISettlementRepository
    {
        Settlement GetSettlementById(int id);
        IEnumerable<Settlement> GetSettlements();
        void AddSettlement(Settlement settlement);
        bool SettlementExists(string name);
        void UpdateSettlement(Settlement settlement);
        void DeleteSettlement(int id);
        Task<IEnumerable<Settlement>> FilterSettlements(string search = "");
    }
}
