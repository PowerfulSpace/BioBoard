using PS.BioBoard.Domain.Entites;

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
