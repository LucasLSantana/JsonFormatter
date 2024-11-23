using Application.Application.DTOs;
using Domain.Entites;

namespace Application.Mappings
{
    public class JsonDataMapping
    {
        public static JsonData MapToEntitie(JsonDataDto jsonDataDto)
        {
            return new JsonData
            {
                JsonGerado = jsonDataDto.JsonGerado,
                Url = jsonDataDto.Url,
                Metodo = jsonDataDto.Metodo,
                Response = jsonDataDto.Response
            };
        }

        public static JsonDataDto MapToDto(JsonData jsonData)
        {
            return new JsonDataDto
            {
                JsonDataId = jsonData.JsonDataId,
                JsonGerado = jsonData.JsonGerado,
                Url = jsonData.Url,
                Metodo = jsonData.Metodo,
                Response = jsonData.Response
            };
        }
    }
}