using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSite.Models
{
    public class BDbInitializer : DropCreateDatabaseAlways<BContext>
    {
        protected override void Seed(BContext db)
        {
            db.Category.Add(new Category { catName = "Категория о том, о сём" });
            db.Category.Add(new Category { catName = "Категория о спорте" });
            db.Category.Add(new Category { catName = "Категория о программировании" });
            base.Seed(db);
        }
    }
}