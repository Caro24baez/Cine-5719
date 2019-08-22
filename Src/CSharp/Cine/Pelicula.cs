using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cine
{
    [Table ("Pelicula")]
    public class Pelicula
    {
        [Key, Column("idPelicula"), Required]
        public short pelicula { get; set; }
        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }
        [Column("fechaLanzamiento"), Required]
        public DateTime FechaLanzamiento { get; set; }
        public Pelicula() { }
        public Pelicula(string nombre)
        {
            Nombre = nombre;
        }

    }
}
