using Microsoft.EntityFrameworkCore;
using SysReport.Core.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysReport.Core.DAL
{
    public class SysReportContext : DbContext
    {
        public DbSet<TestData> TestDatas { get; set; }
        public DbSet<TestSource> TestSources { get; set; }


        public SysReportContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sysReportDb.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestData>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<TestSource>().Property(x => x.Id).ValueGeneratedOnAdd();
        }

        public void Migration()
        {
            Database.EnsureCreated();
        }
    }
}
