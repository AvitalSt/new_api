using Airport.Core.Services;
using Airport.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotsController : ControllerBase
    {
        /*private static List<Pilot> Pilots = new List<Pilot>()
        {
            new Pilot{Id=1,Name="avi",NumWorker=10,Vettek=5,Company="el al"},
            new Pilot{Id=2,Name="dani",NumWorker=11,Vettek=6,Company="arkia"},
            new Pilot{Id=3,Name="shimi",NumWorker=12,Vettek=7,Company="mmm"}
         };*/
        private static int CountPilot = 4;

        private readonly IpilotService _pilotService;
        public PilotsController(IpilotService pilotsService)
        {
            _pilotService = pilotsService;
        }
        // GET: api/<PilotController>
        [HttpGet]
        public IEnumerable<Pilot> Get()
        {
            return _pilotService.GettAll();
        }

        // GET api/<PilotController>/5
        [HttpGet("{id}")]
        public Pilot Get(int id)
        {
            return _pilotService.GetById(id);
        }

        // POST api/<PilotController>
        [HttpPost]
        public void Post([FromBody] Pilot p)
        {
            /*Pilots.Add(new Pilot { Id = CountID, Name = p.Name, NumWorker = p.NumWorker, Vettek = p.Vettek, Company = p.Company });
            CountID++;
            return Pilots[Pilots.Count - 1];*/
            _pilotService.PostNewPilot(p);
        }

        // PUT api/<PilotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pilot p)
        {
            _pilotService.PutPilot(id, p);
        }

        // DELETE api/<PilotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pilotService.DeletePilot(id);
        }
    }
}
