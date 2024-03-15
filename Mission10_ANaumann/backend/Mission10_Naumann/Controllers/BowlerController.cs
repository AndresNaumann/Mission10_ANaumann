using backendAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Naumann.Data;

namespace backendAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerrepository { get; set; }
        public BowlerController(IBowlerRepository temp) { 
            _bowlerrepository = temp;
        }

        [HttpGet]
        public IEnumerable<BowlersAndTeams> GetBowlersAndTeams()
        {
            return _bowlerrepository.GetBowlersAndTeams();
        }
    }
}
