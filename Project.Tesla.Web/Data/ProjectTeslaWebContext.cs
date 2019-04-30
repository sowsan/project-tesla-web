using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project.Tesla.Web.Models
{
    public class ProjectTeslaWebContext : DbContext
    {
        public ProjectTeslaWebContext (DbContextOptions<ProjectTeslaWebContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Tesla.Web.Models.Sessions> Session { get; set; }
    }
}
