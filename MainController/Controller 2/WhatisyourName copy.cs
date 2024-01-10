

using Microsoft.AspNetCore.Mvc;
namespace name_and_time.controller;

[ApiController]
[Route("[controller]")]
    public class Controller: ControllerBase
    {
        public List <string> sent = new();
        [HttpPost]
        [Route("Your name is {name}/{time}")]
        public List <string> Hello(string name, string time)
        {
            sent.Add($"Your name is {name} and you woke up at {time}");
            return sent;
        }
    }
