using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace BlogSite.Models
{
    public class Category
    {
        // ID категории
        [Key]
        public int catId { get; set; }
        // наименование категории
        public string catName { get; set; }
        // ID блога
        public int blogId { get; set; }
    }
}