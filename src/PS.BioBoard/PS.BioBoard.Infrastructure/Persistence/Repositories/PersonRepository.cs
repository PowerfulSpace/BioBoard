using Microsoft.EntityFrameworkCore;
using PS.BioBoard.Application.Common.Interfaces.Persistence;
using PS.BioBoard.Domain.Entites;

namespace PS.BioBoard.Infrastructure.Persistence.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly BioBoardDbContext _dbContext;
        public PersonRepository(BioBoardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _dbContext.Persons.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(Guid id)
        {
            var person = await _dbContext.Persons.FirstOrDefaultAsync(x => x.Id == id); 
            return person!;
        }

        public async Task AddAsync(Person person)
        {
            await _dbContext.Persons.AddAsync(person);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(Person person)
        {
            _dbContext.Entry(person).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var person = new Person { Id = id };
            _dbContext.Persons.Attach(person);
            _dbContext.Entry(person).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }
    }
}
