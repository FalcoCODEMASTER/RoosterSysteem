using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoosterSysteem.Models
{
    public class UserModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string faculty { get; set; }
        public string email { get; set; }
    }
}