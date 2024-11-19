using PS.BioBoard.Domain.Entities;

namespace PS.BioBoard.Application.Common.Interfaces.Persistence
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(Guid id);
        Task<IEnumerable<Person>> GetAllAsync();

        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(Guid id);
    }
}
