using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresidentsExcercise.Model;
using PresidentsExcercise.Repository;

namespace PresidentsExcercise.Controllers
{
    [Produces("application/json")]
    [Route("api/President")]
    public class PresidentController : Controller
    {
        private readonly IPresidentRepository presidentRepository;

        public PresidentController(IPresidentRepository _presidentRepository)
        {
            this.presidentRepository = _presidentRepository;
        }

        

        // GET: api/President/5
        [HttpGet]
        public List<President> Get()
        {
            var name = Request.Query["name"];
            var orderBy = Request.Query["orderby"];

            return presidentRepository.getPresidents(name,orderBy);
        }
        
     
    }
}
