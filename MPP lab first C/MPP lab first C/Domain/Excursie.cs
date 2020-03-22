using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_lab_first_C.Domain
{
    public class Excursie
    {
        public int Id { get; set; }
        public string NumeObiectivTuristic { get; set; }
        public string NumeFirma { get; set; }
        public string OraPlecare { get; set; }
        public int Pret { get; set; }
        public int NumarLocuriDisponibile { get; set; }
    }
}
