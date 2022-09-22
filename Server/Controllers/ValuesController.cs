using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DiabetesBlazorApp.Shared;

namespace DiabetesBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<GlucoseValue> glucoseValues = new List<GlucoseValue>
        {
            new GlucoseValue
            {
                FirstName = "Peter", LastName = "Parker", Value = "6.7" },
            
            new GlucoseValue
            {
                FirstName = "Derick", LastName = "Jones", Value = "7.1"}
        };


        public async Task<IActionResult> GetGlucoseValues()
        {
            return Ok(glucoseValues);
        }
    }
}
