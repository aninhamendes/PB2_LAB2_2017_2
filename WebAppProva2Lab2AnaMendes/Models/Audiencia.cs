using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2AnaMendes.Models
{
    public class Audiencia
    {
        public int AudienciaId { get; set; }
        public DateTime Data { get; set; }
        public string Detalhes { get; set; }
        public List<Processo> Processos { get; set; }
    }
}