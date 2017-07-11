namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBRest : DbContext
    {
        static DBRest()
        {
            Database.SetInitializer(new DBRestInitializer());
        }

        public DBRest()
            : base("name=DBRest")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}