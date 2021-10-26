using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parciais.WEB.Models;

namespace Parciais.WEB.ViewModel.Home
{
    public class DadosDashboard
    {
        public Status Status { get; set; }
        public List<MaisEscalados> MaisEscalados { get; set; }
    }
}
