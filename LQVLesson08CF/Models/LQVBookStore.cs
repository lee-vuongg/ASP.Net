using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LQVLesson08CF.Models
{
    public class LQVBookStore : DbContext
    {
        public LQVBookStore() : base("LQVBookStoreConnectionString)
        {

        }
        // Tạo các bảng
        public DbSet<LQVCategory> LQVCategories { get; set; }
        public DbSet<LQVBook> LQVBooks { get; set; }

    }
}