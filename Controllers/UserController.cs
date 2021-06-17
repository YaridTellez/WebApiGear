using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApiGear.Context;
using WebApiGear.Models.Identity;

using WebApiUser.Model.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiGear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private WebApiGearContext _dbContext;
        public UserController(WebApiGearContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<ApplicationUser> GetUser()
        {
            var list = _dbContext.AspNetUsers.Include(x => x.Location).ToList();
            return list;

        }

        //// GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUserById(int id)
        //{
        //    ViewModelUser CMDb = new ViewModelUser();
        //    try
        //    {
        //        CMDb = _dbContext.AspNetUsers.Find(id);
        //        if (CMDb == null)
        //        {
        //            return NotFound();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    CMDb.Location = _dbContext.LocationCity.Find(CMDb.LocationId);
        //    return Ok(CMDb);
        //}

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] ApplicationUser data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _dbContext.AspNetUsers.Add(data);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            return Ok(data);
        }

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUser(int id, [FromBody] ViewModelUser data)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        CategoryModel CMDb = new CategoryModel();
        //        CMDb = _dbContext.Category.Find(id);
        //        if (CMDb != null)
        //        {
        //            if (data.IdTrademark != 0)
        //            {
        //                CMDb.IdTrademark = data.IdTrademark;
        //            }
        //            CMDb.CategoryName = data.CategoryName;



        //            //   _dbContext.Category.Update(CMDb);
        //        }
        //        int i = this._dbContext.SaveChanges();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return Ok(data);
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser(int id)
        //{
        //    ViewModelUser user = _dbContext.AspNetUsers.Find(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    _dbContext.Remove(user);
        //    _dbContext.SaveChanges();

        //    return Ok(user);
        //}
    }
}
