using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parciais.WEB.Models
{
    public class Atleta
    {
        public string nome { get; set; }
        public string apelido { get; set; }
        public string apelido_abreviado { get; set; }
        public string foto { get; set; }
        public int atleta_id { get; set; }
        public int preco_editorial { get; set; }
    }
}
