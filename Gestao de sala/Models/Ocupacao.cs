using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_sala.Models
{
    public class Ocupacao
    {
        public int OcupID { get; set; }
        public int SalaID { get; set; }
        public DateTime OcupDATA { get; set; }
        public DateTime OcupHoraInicio { get; set; }
        public DateTime OcupHoraFim { get; set; }
    }
}
