using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using lab3.Infrastructure.Models;

namespace lab3.Infrastructure.Interfaces
{
    public interface ITeamRepository
    {
        public Task<ICollection<Team>> GetAllTeamsAsync();
        public Task<Team> GetTeamByIdAsync(Guid? id);
        public Task CreateAsync(Team team);
        public Task EditAsync(Team team, Guid id);
        public Task DeleteAsync(Guid id);
    }
}
