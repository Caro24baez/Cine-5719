using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cine
{
    [Table("Sala")]
    public class Sala
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idSala")]
        public byte Id { get; set; }
        [Column("piso")]
        public byte Piso { get; set; }
        [Column("capacidad")]
        public short Capacidad { get; set; }
        public Sala() { }
        public Sala(byte piso, short capacidad)
        {
            this.Piso = piso;
            this.Capacidad = capacidad;
        }
        public string cad => ($"Piso:{Piso} Capacidad:{Capacidad}");        
    }
}