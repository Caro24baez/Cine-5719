using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cine
{
    [Table("Proyeccion")]
    public class Proyeccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idProyeccion")]
        public short IdProyeccion { get; set; }
        [ForeignKey("idPelicula"), Required]
        public Pelicula Pelicula { get; set; }
        [Column("fechaHora")]
        public DateTime FechaHora { get; set; }
        [Column("idSala")]
        public byte Sala { get; set; }
        [ForeignKey("idEntrada"), Required]
        public Entrada Entrada { get; set; }

        public Proyeccion() { }
        public Proyeccion(Pelicula pelicula, Entrada entrada)
        {
            Pelicula = pelicula;
            Entrada = entrada;
            FechaHora = DateTime.Now;
        }

        public Proyeccion(Entrada entrada)
        {
            Entrada = entrada;
        }

        public bool HoraFuncion(DateTime inicio, DateTime fin)
        {
            return inicio <= FechaHora && FechaHora <= fin;
        }
    }
}
