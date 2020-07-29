using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteValidacaoSoftware.Models
{
    [Table("Carro")]
    public class Carro
    {
        [Key, Column("placa")]
        public string Placa { get; set; }
        [Column("modelo")]
        public string Modelo { get; set; }
        [Column("marca")]
        public string Marca { get; set; }
        [Column("proprietario")]
        public string Proprietario { get; set; }
    }
}
