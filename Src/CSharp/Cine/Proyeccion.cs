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
        [Column("fechaHora"), Required]
        public DateTime FechaHora { get; set; }
        [Column("idSala"), Required]
        public byte Sala { get; set; }
        public List<Entrada> Entradas { get; set; }
        public Proyeccion() { }
        public Proyeccion(Pelicula pelicula, Entrada entrada)
        {
            Pelicula = pelicula;
            Entradas = entrada;
            FechaHora = DateTime.Now;
        }

        public Proyeccion(Entrada entrada)
        {
            Entradas = entrada;
        }

        public bool horaFuncion(DateTime inicio, DateTime fin)
        {
            return inicio <= FechaHora && FechaHora <= fin;
        }
        public int EntradasVendidasEntre(DateTime inicio, DateTime fin)
        {
            return 0;
        }
        public int AgregarProyeccion()
        {
            return 0;
        }
    }
}
