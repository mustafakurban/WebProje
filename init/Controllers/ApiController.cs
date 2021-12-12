using init.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace init.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            Context c = new Context();
            var degerler = c.Apikeys.ToList();
            var hayvanlar = c.animals.ToList();
            var api_key = id.Substring(0,4);
            var an_id = id[4].ToString();

            var numQuery =
               from X in hayvanlar
               where X.id == Int32.Parse(an_id)
               select X.isim;

            var list = numQuery.ToList();

            if (Int32.Parse(api_key) == degerler[0].ApiKey)
            {
                return list[0];
            }
           
            
            return "404";
        }

   
    }
}
