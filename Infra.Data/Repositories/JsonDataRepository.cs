using Domain.Entites;
using Domain.Interfaces.Repositories;
using Infra.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class JsonDataRepository : IJsonDataRepository
    {
        private readonly ApplicationDbContext _context;

        public JsonDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(JsonData jsonData)
        {
            await _context.JsonData.AddAsync(jsonData);
            await _context.SaveChangesAsync();
        }
        
        public async Task<List<JsonData>> GetAllAsync()
        {
            return await _context.JsonData.ToListAsync();
        }
        
        public async Task<JsonData> GetAsync(int id)
        {
            return await _context.JsonData.FirstOrDefaultAsync(f => f.JsonDataId == id) ?? new JsonData();
        }
    }
}
