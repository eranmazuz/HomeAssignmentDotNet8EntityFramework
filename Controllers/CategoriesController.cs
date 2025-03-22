using HomeAssignmentDotNet8EntityFramework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAssignmentDotNet8EntityFramework
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            List<Category> categories =
            [
                new Category()
                {
                    Id = 1,
                    Name = "Category 1"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Category 2"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Category 3"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Category 4"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Category 5"
                }
            ];
            return Ok(categories);
        }
    }
}
