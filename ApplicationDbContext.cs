using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebAPI.Models;

namespace WebApiGear
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<PersonModel> Person { get; set; }
    }
}


//Hacer Migracion 
// add-migration inicial
// dotnet ef database update
