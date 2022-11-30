using Microsoft.AspNetCore.Mvc;

namespace CosmosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : ControllerBase
    {
        [HttpGet(Name = "GetFamilies")]
        public async Task<ActionResult<List<Family>>> GetAsync()
        {
            return Ok(await CosmosDB.Instance.QueryAllItemsAsync());
        }
    }
}