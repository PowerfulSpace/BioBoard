using System;

namespace PS.BioBoard.DAL.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        public Task<IEnumerable<Person>> GetAllAsync();
        public Task<Person?> GetByIdAsync(Guid id);
        public Task AddAsync(Person person);
        public Task UpdateAsync(Person person);
        public Task DeleteAsync(Guid id);
    }
}
