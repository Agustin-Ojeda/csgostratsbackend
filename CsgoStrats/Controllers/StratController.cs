using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CsgoStrats.Models;

namespace CsgoStrats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StratController : ControllerBase
    {
        public IActionResult Get()
        {
            using (CsgostratsdbContext db = new CsgostratsdbContext())
            {
                var lst = db.Strats.ToList();
                return Ok(lst);
            }

        }
    }
}
