using Airport.Core.Services;
using Airport.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        /*private static List<Flight> flightss = new List<Flight>()
        {
            new Flight{FlightsNum=100,Date=new DateTime(),LeavingTime=new DateTime(),ArrivalTime=new DateTime(),TerminalNum=50},
            new Flight{FlightsNum=101,Date=new DateTime(),LeavingTime=new DateTime(),ArrivalTime=new DateTime(),TerminalNum=52}

        };*/
        private static int CountFlight = 102;

        private readonly IflightService _flightService;
        public FlightsController(IflightService flightService)
        {
            _flightService = flightService;
        }

        // GET: api/<FlightsController>
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _flightService.GettAll();
        }

        // GET api/<FlightsController>/5
        [HttpGet("{id}")]
        public Flight Get(int Id)
        {
            return _flightService.GetById(Id);
        }

        // POST api/<FlightsController>
        [HttpPost]
        public void Post([FromBody] Flight f)
        {
            _flightService.PostNewFlight(f);
        }

        // PUT api/<FlightsController>/5
        [HttpPut("{id}")]
        public void Put(int Id, [FromBody] Flight f)
        {
            _flightService.PutFlight(Id, f);
        }

        // DELETE api/<FlightsController>/5
        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
            _flightService.DeleteFlight(Id);
        }
    }
}
