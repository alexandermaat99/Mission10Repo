using bowlingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace bowlingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlerRespository;
        public BowlerController(IBowlingRepository temp)
        {
            _bowlerRespository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRespository.Bowlers.ToArray();
            return bowlerData;
        }
    }
}