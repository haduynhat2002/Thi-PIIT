using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Thi_PIIT.Data
{
    public class Thi_PIITContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Thi_PIITContext() : base("name=Thi_PIITContext")
        {
        }

        public System.Data.Entity.DbSet<Thi_PIIT.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<Thi_PIIT.Models.Coin> Coins { get; set; }
    }
}
