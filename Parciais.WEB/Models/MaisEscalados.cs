using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parciais.WEB.Models
{
    public class MaisEscalados
    {
        public MaisEscalados()
        {
            Atleta = new Atleta();
        }
        public string posicao { get; set; }
        public string posicao_abreviacao { get; set; }
        public string clube { get; set; }
        public string clube_nome { get; set; }
        public string escudo_clube { get; set; }
        public Atleta Atleta { get; set; }
        public int clube_id { get; set; }
        public int escalacoes { get; set; }
    }
}
