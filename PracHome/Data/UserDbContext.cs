using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracHome.Models;

namespace PracHome.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserAuth> TblUserAuths { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblUserRole> TblUserRoles { get; set; }

    }
}
