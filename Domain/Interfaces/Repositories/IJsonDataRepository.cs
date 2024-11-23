using Domain.Entites;

namespace Domain.Interfaces.Repositories
{
    public interface IJsonDataRepository
    {
        Task AddAsync(JsonData jsonData);
        Task<List<JsonData>> GetAllAsync();
        Task<JsonData> GetAsync(int id);
    }
}