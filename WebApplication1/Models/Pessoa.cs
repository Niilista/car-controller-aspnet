using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteValidacaoSoftware.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key, Column("cpf")]
        public string CPF { get; set; }
        [Column("nome")]
        public string Name { get; set; }
    }
}
