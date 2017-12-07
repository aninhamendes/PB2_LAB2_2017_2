using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2AnaMendes.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        //adicionando o Lazy Loading
        public virtual List<Processo> Processos { get; set; }
        public Endereco Endereco { get; set; }

    }
}