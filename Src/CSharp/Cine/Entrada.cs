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
        [Key, Column("idEntrada")]
        public int Id { get; set; }

        [ForeignKey("idProyeccion"), Required]
        public Proyeccion Proyeccion { get; set; }
        [Column("valor"), Required]
        public double Valor { get; set; }
        [Column("fechaHora"), Required]
        public DateTime FechaHora { get; set; }
        public Entrada()
        {
        }
            
        public Entrada(Proyeccion proyeccion)
        {
            Proyeccion = proyeccion;
            this.Valor = proyeccion.Valor;
            this.FechaHora = DateTime.Now;
        }

        public static implicit operator List<object>(Entrada v)
        {
            throw new NotImplementedException();
        }
    }
}
