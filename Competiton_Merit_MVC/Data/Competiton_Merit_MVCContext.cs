using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Competiton_Merit_MVC.Models;

namespace Competiton_Merit_MVC.Data
{
    public class Competiton_Merit_MVCContext : DbContext
    {
        public Competiton_Merit_MVCContext (DbContextOptions<Competiton_Merit_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Competiton_Merit_MVC.Models.School> School { get; set; }

        public DbSet<Competiton_Merit_MVC.Models.Subject> Subject { get; set; }

        public DbSet<Competiton_Merit_MVC.Models.Student_participate> Student_participate { get; set; }

        public DbSet<Competiton_Merit_MVC.Models.Meritlist> Meritlist { get; set; }
    }
}
