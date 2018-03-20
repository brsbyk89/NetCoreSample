using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Business.Contracts;

namespace NetCoreSample.Controllers
{
    //[Produces("application/json")]
    //[Route("api/[controller]")]
    public class BookController : Controller
    {
        private IBusinessEngine _businessEngine;
        public BookController(IBusinessEngine businessEngine)
        {
            _businessEngine = businessEngine;
        }

        [HttpGet]
        public IEnumerable<object> GetAll()
        {
            
            return new List<string> { "123", "456", "789" };
        }

        [HttpGet]
        public string Get()
        {

            return _businessEngine.Get();
        }
    }
}