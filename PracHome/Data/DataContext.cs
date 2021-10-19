using Microsoft.EntityFrameworkCore;
using PracHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracHome.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> TblStudents { get; set; }
        public DbSet<Standard> TblStandards { get; set; }
        public DbSet<StudentStandardRelation> StudentStandardRelations { get; set; }


        //public DbSet<User_Model> Tbl_User { get; set; }
        //public DbSet<Role_Model> Tbl_Role { get; set; }
        // public DbSet<User_Role_Status> Tbl_URS_JOIN { get; set; }


        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //primary keys
                //modelBuilder.Entity<User_Role_Status>().HasKey(o => o.URS_PK_Id);
                //modelBuilder.Entity<User_Model>().HasKey(o => o.User_Id);
                //modelBuilder.Entity<Role_Model>().HasKey(o => o.Role_Id);
                //modelBuilder.Entity<Status_Model>().HasKey(o => o.Status_Id);
            //primary key

            //user model columns validation
            //modelBuilder.Entity<User_Model>().Property(t => t.User_Name).IsRequired().HasMaxLength(50);
            //modelBuilder.Entity<User_Model>().HasIndex(t => t.User_Name).IsUnique();
            //modelBuilder.Entity<User_Model>().Property(t => t.User_Password).IsRequired();
            //user model columns validation

            //role model columns validation
            //modelBuilder.Entity<Role_Model>().Property(t => t.Role_Name).IsRequired().HasMaxLength(50);
            //modelBuilder.Entity<Role_Model>().HasIndex(t => t.Role_Name).IsUnique();
            //role model columns validation

            /*
             *Many Users can have many roles [all the configuration is here]
              many-user -> many-roles third table is urs
             *
             */

            //modelBuilder.Entity<User_Role_Status>()
            //    .HasKey(T => new { T.User_Id_FK, T.Role_Id_FK });
            //modelBuilder.Entity<User_Role_Status>()
            //    .HasOne(user => user.User_Obj).WithMany(urs => urs.URS_Objs).HasForeignKey(FK_User => FK_User.User_Id_FK);
            //modelBuilder.Entity<User_Role_Status>()
            //    .HasOne(role => role.Role_Obj).WithMany(urs => urs.URS_Objs).HasForeignKey(FK_User => FK_User.Role_Id_FK);

            /*
             *Many Users can have many roles [all the configuration is here]
              many-user -> many-roles third table is urs and configured above
             *
            
           

        }
    */

    }
}
