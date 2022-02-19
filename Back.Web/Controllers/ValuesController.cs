using Back.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("GetAnimal")]
        public List<Animal> Animals()
        {
            return new List<Animal>()
                {
                    new Animal()
                    {
                        Id = 1, Caption = "Обезьяна"
                    }
                    , new Animal()
                    {
                        Id = 2, Caption = "Лошадь"
                    }
                };
        }
    }
}
