using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace CosmosAPI.Controllers
{
    [ApiController]
    [Route("data")]
    public class FamilyController : ControllerBase
    {
        [HttpGet(Name = "GetFamilies")]
        public async Task<ActionResult<List<Family>>> GetAsync()
        {
            return Ok(await CosmosDB.Instance.QueryAllFamiliesAsync());
        }

    }
}