using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cine
{
    [Table ("PeliculaGenero")]
    public class PeliculaGenero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ Key, Column ("idPeliculaGenero")]
        public byte Id { get; set; }
        [ForeignKey("idPelicula"), Required]
        public short Pelicula { get; set; }

        [ForeignKey("idGenero"), Required]
        public byte Genero { get; set; }
        
        public PeliculaGenero() { }

        public PeliculaGenero(byte idGenero, short idPelicula)
        {
            Pelicula = idPelicula;
            Genero = idGenero;
        }
    }
}
