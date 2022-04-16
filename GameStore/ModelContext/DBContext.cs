using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using GameStore.Model;

namespace GameStore.ModelContext
{
    class DBContext : DbContext
    {
        public DBContext()
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }
    }
}
