using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;
using ProductsAPI.Repository;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryRepository.GetCategories();
            return Ok(categories);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            _categoryRepository.InsertCategory(category);
            return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            if (category == null || category.Id != id)
                return BadRequest();
            _categoryRepository.UpdateCategory(category);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok();
        }
    }

}
