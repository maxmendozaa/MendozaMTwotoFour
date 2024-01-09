

using Microsoft.AspNetCore.Mvc;
namespace say_hello_endpoint.controller;

[ApiController]
[Route("[controller]")]
    public class Controller: ControllerBase
    {
        public List <string> adding = new();
        [HttpPost]
        [Route("return {num1}/{num2}")]
        public List <string> Hello(int num1, int num2)
        {
            int sum = num1 + num2;
            adding.Add($"the sum of, {num1} and {num2} = {sum}");
            return adding;
        }
    }









