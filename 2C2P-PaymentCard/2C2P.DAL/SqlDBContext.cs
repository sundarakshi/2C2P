using System;
using System.Data.Entity;


namespace _2C2P.DAL
{
    public class SqlDBContext : DbContext
    {

        public SqlDBContext() : base()
        {
            Database.SetInitializer<SqlDBContext>(null);
        }

    }
}
