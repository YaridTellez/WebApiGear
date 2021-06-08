using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

using WebAPI.Models;

namespace WebApiGear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get: api/person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetPersonModel()
        {
            return await _context.Person.ToListAsync();
        }

    }
}
