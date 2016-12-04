using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Db.Tables
{
    public class Login
    {
        public Login()
        {
            
        }
        [Key]
        public int id { get; set; }
        public string LoginId { get; set; }
    }
}
