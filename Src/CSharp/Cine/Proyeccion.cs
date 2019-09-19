using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Cine
{
    [Table("Proyeccion")]
    public class Proyeccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idProyeccion")]
        public short Id { get; set; }
        [ForeignKey("idPelicula"), Required]
        public Pelicula Pelicula { get; set; }
        [Column("fechaHora"), Required]
        public DateTime FechaHora { get; set; }
        [ForeignKey("idSala"), Required]
        public Sala Sala { get; set; }
        public List<Entrada> Entradas { get; set; }
        public Proyeccion() { } 
        public Proyeccion(Pelicula pelicula, Sala sala)
        {
            Sala = sala;
            Pelicula = pelicula;
            FechaHora = DateTime.Now;
        }

        public bool horaFuncion(DateTime inicio, DateTime fin) 
        {
            return inicio <= FechaHora && FechaHora <= fin;
        }
        public List<Entrada> EntradasVendidasEntre(DateTime inicio, DateTime fin)
        {
            List<Entrada> entradasTotales = Entradas.Where(a => a.FechaHora > inicio && a.FechaHora < fin).ToList();
                                  
            return entradasTotales;
            
        }
        public int AgregarProyeccion()
        {
            return 0;
        }

        public int EntradasDisponible()
        {
            return Entradas.Count - Sala.Capacidad;
        }
    }
}
