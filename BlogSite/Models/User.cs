using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class User
    {
        // ID юзера
        public int Id { get; set; }
        // логин
        public string login { get; set; }
        // пароль
        public string password { get; set; }
        // цена
        public int blogID { get; set; }
    }
}