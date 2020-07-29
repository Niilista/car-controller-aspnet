using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteValidacaoSoftware.Models
{
    public class RegistroViewModel
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }
}
