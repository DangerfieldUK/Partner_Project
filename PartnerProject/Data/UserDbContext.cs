using Microsoft.EntityFrameworkCore;
using PartnerProject.Models.Indentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartnerProject.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base()
        {
            Database.SetInitializer<UserDbContext>(new CreateDatabaseIfNotExists<UserDbContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }
        public DbSet<User> Users { get; set; }
    }
}
