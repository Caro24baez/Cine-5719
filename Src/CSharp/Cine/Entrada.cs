using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine
{
    [Table("Entrada")]
    public class Entrada 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idEntrada"), Required]
        public int Id { get; set; }

        [ForeignKey("idProyeccion"), Required]
        public Proyeccion Proyeccion { get; set; }
        [Column("valor"), Required]
        public int Valor { get; set; }

        public Entrada()
        {
           
        }

       
      
    }
}
