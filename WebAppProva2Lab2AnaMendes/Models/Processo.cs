using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2AnaMendes.Models
{
    public class Processo
    {
        public int ProcessoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool Situacao { get; set; }

        //chave estrangeira
        public int PessoaId { get; set; }
        //propriedade de navegação
        public Pessoa Pessoa { get; set; }

        public List<Audiencia> Audiencias { get; set; }
        //chave estrangeira
        public int TipoId { get; set; }
        //propriedade de navegação
        public Tipo Tipo { get; set; }


    }
}