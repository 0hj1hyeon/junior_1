using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public String Id { get; set; }
        public String Pw { get; set; }
    }
}
