using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cSharpTarot.Controllers {
    [Route("api/[controller]")]
    public class AdminLoginController : Controller 
    {
        public string Username = "Admin";
        public string Password = "Password";


        [HttpPost("[action]")]
        public string LoginInfo() {
            return $"{{ didLogin: true }}";
        }
    }
}