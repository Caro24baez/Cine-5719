using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cine
{
    [Table("Pelicula")]
    public class Pelicula
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idPelicula")]
        public short id { get; set; }

        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("fechaLanzamiento", TypeName = "Date" ), Required]
        public DateTime FechaLanzamiento { get; set; }   
        
        public List<Proyeccion> Proyecciones { get; set; }

        public Pelicula()
        {
            Proyecciones = new List<Proyeccion>();
        }
        public Pelicula(string nombre) 
        {
            Nombre = nombre;
            FechaLanzamiento = DateTime.Now;
        }
    }
}