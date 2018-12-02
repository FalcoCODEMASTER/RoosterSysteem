using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoosterSysteem.Models
{
    public class testclass
    {
        public string bericht{ get; set; }

        public void OnGet()
        {
            bericht = "hij doet het !";
        }
    }
}