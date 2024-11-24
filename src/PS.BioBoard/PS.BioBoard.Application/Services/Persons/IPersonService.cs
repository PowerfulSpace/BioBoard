using PS.BioBoard.Domain.Entities;

namespace PS.BioBoard.Application.Services.Persons
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(Guid id);
        Task<Person> GetByEmailAsync(string email);
        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(Guid id);
    }
}
