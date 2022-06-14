using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktails.Objects;

namespace Cocktails
{
    public class Context : DbContext
    {
        public Context(): base("name=1")
        {
            //Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
            
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientType> IngredientTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<DrinkGlass> Glasses { get; set; }
    }
}
