using Domain.Entites;

namespace Domain.Interfaces.Services
{
    public interface IJsonDataService
    {
        Task AddAsync(JsonData jsonData);
        Task<List<JsonData>> GetAllAsync();
        Task<JsonData> GetAsync(int id);
    }
}
