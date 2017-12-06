using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2AnaMendes.Models
{
    public class Endereco
    {
        //Pessoa assume a responsabilidade de PK e FK
        [ForeignKey("Pessoa")]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public Pessoa Pessoa { get; set; }
        
    }
}