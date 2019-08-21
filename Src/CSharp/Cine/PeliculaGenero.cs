﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cine
{
    [Table ("PeliculaGenero")]
    public class PeliculaGenero
    {
        [ForeignKey("idPelicula"), Required]
        public short Pelicula { get; set; }

        [ForeignKey("idGenero"), Required]
        public byte Genero { get; set; }
        PeliculaGenero() { }
    }
}
