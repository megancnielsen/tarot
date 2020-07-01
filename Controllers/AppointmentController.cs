using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cSharpTarot.Models;
using cSharpTarot.Services;

namespace cSharpTarot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private TarotService _appointmentService;

        public AppointmentController(TarotService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public ActionResult<List<Appointment>> Get() => _appointmentService.Get();
        
        [HttpPost("[action]")]
        public IActionResult Create([FromBody]Appointment appt)
        {
            System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(ModelState));
            System.Console.WriteLine("****************************************************************************************************");
            System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(appt));
            System.Console.WriteLine("****************************************************************************************************");
            _appointmentService.Create(appt);
            return Ok(appt);
        }
    }
}