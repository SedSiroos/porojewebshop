using Microsoft.EntityFrameworkCore;
using Poroject.DataLayer.Entities.Course;
using Poroject.DataLayer.Entities.Permissons;
using Poroject.DataLayer.Entities.User;
using Poroject.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.DataLayer.Context
{
    public class PorojectContext : DbContext
    {
        public PorojectContext(DbContextOptions<PorojectContext> options) : base(options)
        {

        }


        #region UserContext
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        #endregion

        #region Wallets
        public DbSet<WalletType> walletTypes { get; set; }
        public DbSet<Wallet> wallets { get; set; }
        #endregion

        #region Permission
        public DbSet<Permission> Permission { get; set; }
        public DbSet<PermissonRoles> PermissonRoles { get; set; }
        #endregion

        #region Course
        public DbSet<CourseGroup> courseGroups { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseStatus> CourseStatuses { get; set; }
        public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);

            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);

            modelBuilder.Entity<CourseGroup>()
                .HasQueryFilter(g => !g.IsDelete);

            modelBuilder.Entity<CourseEpisode>()
                .HasQueryFilter(e => !e.IsDelete);

            base.OnModelCreating(modelBuilder);
        }
    }
}
