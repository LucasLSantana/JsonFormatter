using Application.Application.DTOs;

namespace Application.Interfaces
{
    public interface IJsonDataAppService
    {
        Task AddAsync(JsonDataDto jsonDataDto);
        Task<List<JsonDataDto>> GetAllAsync();
        Task<JsonDataDto> GetAsync(int id);
    }
}