using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Cine
{

    [Table("Genero")]
    public class Genero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idGenero")]
        public int Id { get; set; }

        [Column("genero"),StringLength(45), Required]
        public string genero { get; set; }

        public Genero() { }

        public Genero(string Genero)
        {
            genero = Genero;
        }

    }    
}
