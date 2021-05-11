using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PartnerProject.Models.Indentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartnerProject.Models.Identity
{
    public class UserAccountDbContext : IdentityDbContext<User, UserRole, int>
    {
        public UserAccountDbContext(DbContextOptions<UserAccountDbContext> options) : base(options)
        {

        }
    }
}

