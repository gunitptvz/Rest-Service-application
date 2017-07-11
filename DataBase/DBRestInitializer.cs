using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataBase
{
    public class DBRestInitializer : CreateDatabaseIfNotExists<DBRest>
    {
        protected override void Seed(DBRest context)
        {
            User user1 = new User {NickName = "Sergio", FullName = "Sergey"};
            User user2 = new User {NickName = "Andrew", FullName = "Andrey"};
            User user3 = new User {NickName = "Val", FullName = "Valeriy"};

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);

            context.SaveChanges();
        }
    }
}
