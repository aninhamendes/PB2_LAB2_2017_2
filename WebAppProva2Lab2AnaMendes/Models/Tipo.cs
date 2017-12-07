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
        //Adicionando o Lazy Loading
        public virtual List<Processo> Processos { get; set; }
    }
}