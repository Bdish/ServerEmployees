using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.Repository.Implementations;
using DAL.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EployeeController : ControllerBase
    {
        private IGenericRepository<Employee> _repo;

        public EployeeController(IGenericRepository<Employee> repo)
        {
            _repo = repo;
        }

        // GET: api/Eployee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _repo.Get();
        }

      

        // POST: api/Eployee
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            try
            {
                _repo.Create(employee);
                return Ok(employee);
            }
            catch
            {
                return BadRequest();
            }
        }
        
    }
}
