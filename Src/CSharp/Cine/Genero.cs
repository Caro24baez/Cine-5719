using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Cine
{

    [Table("Genero")]
    class Genero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idGenero")]
        public int Id { get; set; }

        [Column("genero"), Required]
        public byte genero { get; set; }

        public Genero() { }

        public Genero(byte Genero)
        {
            genero = Genero;
        }

    }    
}
