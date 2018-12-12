using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(string fname)
        {
            EchoClient.Client client = new EchoClient.Client();
            var response = client.CreateUser(new EchoClient.Models.User() { UserName = fname });
            if(response)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}