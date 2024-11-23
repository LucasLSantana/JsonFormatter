using Application.Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entites;
using Domain.Interfaces.Services;

namespace Application.Application.Services
{
    public class JsonDataAppService : IJsonDataAppService
    {
        private readonly IJsonDataService _jsonDataService;

        public JsonDataAppService(IJsonDataService jsonDataService)
        {
            _jsonDataService = jsonDataService;
        }

        public async Task AddAsync
            (JsonDataDto jsonDataDto)
        {
            var jsonData = JsonDataMapping.MapToEntitie(jsonDataDto);
            await _jsonDataService.AddAsync(jsonData);
        }

        public async Task<List<JsonDataDto>> GetAllAsync()
        {
            var listEntity = await _jsonDataService.GetAllAsync();
            return listEntity.Select(JsonDataMapping.MapToDto).ToList();
        }

        public async Task<JsonDataDto> GetAsync(int id)
        {
            var json = await _jsonDataService.GetAsync(id);
            return JsonDataMapping.MapToDto(json);
        }
    }
}