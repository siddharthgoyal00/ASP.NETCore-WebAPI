using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MyWebApi.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitsApiController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
           "apple",
           "banana",
           "mango",
           "cherry",
           "grapes",

        };
        [HttpGet]
        public List<string> GetFruits(){
            return fruits;
        }
    }
}