using Domain.Entites;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class JsonDataService : IJsonDataService
    {
        private readonly IJsonDataRepository _jsonDataRepository;

        public JsonDataService(IJsonDataRepository jsonDataRepository)
        {
            _jsonDataRepository = jsonDataRepository;
        }

        public async Task AddAsync(JsonData jsonData)
        {
            await _jsonDataRepository.AddAsync(jsonData);
        }

        public async Task<List<JsonData>> GetAllAsync()
        {
            return await _jsonDataRepository.GetAllAsync();
        }
        
        public async Task<JsonData> GetAsync(int id)
        {
            return await _jsonDataRepository.GetAsync(id);
        }
    }
}