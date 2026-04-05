using SportsLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsLeague.Domain.Interfaces.Services
{
    public interface ISponsorService
    {
        Task<IEnumerable<Sponsor>> GetAllAsync();
        Task<Sponsor?> GetByIdAsync(int id);
        Task<Sponsor> CreateAsync(Sponsor sponsor);
        Task UpdateAsync(int id, Sponsor sponsor);
        Task DeleteAsync(int id);

        Task LinkToTournamentAsync(int sponsorId, int tournamentId, decimal contributionAmount);

        Task<IEnumerable<Sponsor>> GetSponsorsByTournamentAsync(int tournamentId);

        Task<IEnumerable<Sponsor>> GetActiveSponsorsAsync();
        Task<IEnumerable<TournamentSponsor>> GetTournamentsBySponsorAsync(int sponsorId);
        Task UnlinkFromTournamentAsync(int sponsorId, int tournamentId);
    }
}