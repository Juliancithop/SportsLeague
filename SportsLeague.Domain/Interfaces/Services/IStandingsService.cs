using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLeague.Domain.Interfaces.Services
{
    public interface IStandingsService
    {
        Task<object> GetStandingsAsync(int tournamentId); //Obtener la tabla de posiciones apra un torneo especifico
        Task<object> GetTopScorersAsync(int tournamentId); //Obtener la lista de los maximos goleadores para un torneo en especifico

        Task<object> GetCardStatsAsync(int tournamentId);// Obtener las estadistivcas de tarjetas para un torneo en especifico
    }

}
