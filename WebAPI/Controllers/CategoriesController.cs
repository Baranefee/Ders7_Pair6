using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet]

        public IActionResult GetById(int id)
        {
            return Ok(_categoryService.GetById(id));
        }

        [HttpPost]

        public IActionResult Add([FromBody] Category category)
        {
            return Ok(_categoryService.Add(category));
        }

        [HttpPut]

        public IActionResult Update([FromBody] Category category)
        {
            return Ok(_categoryService.Update(category));
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok("Kategori silme basarili");
        }
    }
}
