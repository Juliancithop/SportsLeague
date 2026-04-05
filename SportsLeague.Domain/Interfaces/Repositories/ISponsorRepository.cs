using SportsLeague.Domain.Entities;
using System.Threading.Tasks;

namespace SportsLeague.Domain.Interfaces.Repositories
{
    public interface ISponsorRepository : IGenericRepository<Sponsor>
    {
        Task<bool> ExistsByNameAsync(string name);
        Task<Sponsor?> GetByIdWithTournamentsAsync(int id);
        Task<IEnumerable<Sponsor>> GetHighValueSponsorsAsync(decimal minInvestment);
        Task<IEnumerable<Sponsor>> GetActiveByYearAsync(int year);
    }
}