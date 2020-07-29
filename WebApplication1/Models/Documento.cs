using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteValidacaoSoftware.Models
{
    [Table("Documento")]
    public class Documento
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("proprietario")]
        public string CpfProprietario { get; set; }
        [Column("propriedade")]
        public string PlacaPropriedade { get; set; }
    }
}
