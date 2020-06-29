using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cSharpTarot.Models;
using cSharpTarot.Services;

namespace cSharpTarot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private TarotService DbContext;

        public AppointmentController(TarotService service)
        {
            DbContext = service;
        }

        [HttpGet]
        public ActionResult<List<Appointment>> Get() => DbContext.Get();
        [HttpPost]
        public ActionResult<Appointment> Create(dynamic Appt)
        {
            System.Console.WriteLine("****************************************************************************************************");
            System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(Appt));
            System.Console.WriteLine("****************************************************************************************************");
            DbContext.Create(Appt);
            return Appt;
        }
    }
}