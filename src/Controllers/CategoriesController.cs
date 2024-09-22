using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_3_online_Backend_Teamwork.src.Entity;

namespace sda_3_online_Backend_Teamwork.src.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CategoriesController: ControllerBase
    {
        public List<Category> categories = new List<Category>
        {
            new Category { Id = 1 , CategoryName = "Category1"},
            new Category { Id = 2 , CategoryName ="Category2"},
            new Category { Id = 3 , CategoryName ="Category3"}
        };

        [HttpGet]
        public ActionResult GetCategory()
        {
            return Ok(categories);
        }

        [HttpGet("{Id}")]
        public ActionResult GetCategoryById(int id)
        {
            Category? foundCategory = categories.FirstOrDefault(c => c.Id == id);
            if(foundCategory == null)
            {
                return NotFound();
            }
            return Ok(foundCategory);
        }

        [HttpPost]
        public ActionResult CreateCategory(Category newCategory)
        {
            categories.Add(newCategory);
            return CreatedAtAction(nameof(GetCategoryById), new {id = newCategory.Id},newCategory);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteCategory(int id)
        {
            Category? foundCategory = categories.FirstOrDefault(c => c.Id == id);
            if (foundCategory == null)
            {
                return NotFound();
            }
            categories.Remove(foundCategory);
            return NoContent();
        }

        [HttpPut("{Id}")]
        public ActionResult PutCategory(int id, Category updateCategory)
        {
            Category? foundCategory = categories.FirstOrDefault(c => c.Id == id);
            if (foundCategory == null)
            {
                return NotFound();
            }

            foundCategory.Id = updateCategory.Id;
            foundCategory.CategoryName = updateCategory.CategoryName;
            return NoContent();
        }

    }
}