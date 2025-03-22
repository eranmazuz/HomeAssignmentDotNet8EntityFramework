using HomeAssignmentDotNet8EntityFramework.Data;
using HomeAssignmentDotNet8EntityFramework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeAssignmentDotNet8EntityFramework
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>>Get()
        {
            var categories = await _context.Categories.ToListAsync();
            return Ok(categories);
        }
    }
}
