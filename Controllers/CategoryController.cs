using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApiGear.Context;
using WebApiGear.Models;

namespace WebApiGear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private WebApiGearContext _dbContext;
        public CategoryController(WebApiGearContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<CategoryModel> GetCategory()
        {
            var list = _dbContext.Category.Include(x => x.TrademarkName).ToList();
            return list;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> PostCategory(CategoryModel data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _dbContext.Category.Add(data);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            return Ok(data);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
