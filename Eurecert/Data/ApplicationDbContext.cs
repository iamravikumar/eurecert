﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Eurecert.Models;

namespace Eurecert.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<InstitutionalFunction> InstitutionalFunctions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<SalesRepresentative> SalesRepresentatives { get; set; }
        public DbSet<ToBeInformed> ToBeInformeds { get; set; }
        


        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<ReferenceMethod> ReferenceMethods { get; set; }
        public DbSet<PublicityMethod> PublicityMethods { get; set; }
        public DbSet<Service> Services { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Eurecert.Models.Service> Service { get; set; }
    }
}
