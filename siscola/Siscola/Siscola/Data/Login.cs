using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siscola.Data
{
    [Table("login")]
    public class Login
    {
        [Key]
        public int cod { get; set; }
        public int cod_usuario { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
    }
}
