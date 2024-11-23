using Application.Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JsonFormatter.Controllers
{
    public class JsonController : Controller
    {
        private readonly IJsonDataAppService _jsonDataAppService;

        public JsonController(IJsonDataAppService jsonDataAppService)
        {
            _jsonDataAppService = jsonDataAppService;
        }

        public async Task<IActionResult> Index()
        {
            var listJson = await _jsonDataAppService.GetAllAsync();
            return View(listJson);
        }

        public IActionResult Format()
        {
            return View();
        }

        public IActionResult Generate()
        {
            return View();
        }

        [HttpPost]
        public async Task<RedirectToActionResult> GravarJson(JsonDataDto jsonDataDto)
        {
            try
            {
                await _jsonDataAppService.AddAsync(jsonDataDto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> Visualizar(int id)
        {
            try
            {
                var json = await _jsonDataAppService.GetAsync(id);
                return View(json);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }
    }
}