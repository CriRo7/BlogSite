using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class Blog
    {
        // ID блога
        public int blogId { get; set; }
        // наименование блога
        public string blogName { get; set; }
        // кол-во категорий
        public int countOfCat { get; set; }
        // кол-во постов
        public int countOfPost { get; set; }

    }
}