using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAssignmentDotNet8EntityFramework
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Dictionary<string, string>>> Get()
        {
            List<Dictionary<string, string>> categories =
            [
                new Dictionary<string, string>()
                {
                    { "name", "category 1" },
                },

                new Dictionary<string, string>()
                {
                    { "name", "category 2" },
                },

                new Dictionary<string, string>()
                {
                    { "name", "category 3" },
                }
            ];
            return Ok(categories);
        }
    }
}
