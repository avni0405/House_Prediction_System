using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test1_service
{
    public class user
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string image1 { get; set; }
        public virtual ICollection<House> house { get; set; }
    }
}