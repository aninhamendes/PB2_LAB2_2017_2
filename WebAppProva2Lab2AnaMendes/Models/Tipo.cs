using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2AnaMendes.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Descricao { get; set; }
        //propriedade de navegação
        public List<Processo> Processos { get; set; }
    }
}