using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJSCJR_TacoslaEnredadaInterfaz.Models
{
    public class Taco
    {
        public int idTaco { get; set; }
        public string? nombreTaco { get; set; }
        public Boolean conGuacamole { get; set; }
        public string? decripcionTaco { get; set; }
    }
}
