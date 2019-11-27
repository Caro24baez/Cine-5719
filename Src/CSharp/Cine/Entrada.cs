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
        [ForeignKey("idCajero"), Required]
        public Cajero Cajero { get; set; }
        [Column("valor"), Required]
        public double Valor { get; set; }
        [Column("fechaHora"), Required]
        public DateTime FechaHora { get; set; }
        public Entrada()
        {
        }
            
        public Entrada(Proyeccion proyeccion, Cajero cajero)
        {
            Proyeccion = proyeccion;
            Cajero = cajero;
            this.Valor = proyeccion.Valor;
            this.FechaHora = DateTime.Now;
        }

      
    }
}
