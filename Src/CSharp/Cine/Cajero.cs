using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine
{
    [Table ("Cajero")]
    class Cajero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idCajero")]
        public int Id { get; set; }
        [ForeignKey("idEntrada"), Required]
        public Entrada Entrada { get; set; }
        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }
        [Column("apellido"), StringLength(45), Required]
        public string Apellido { get; set; }
        [Column("email"), StringLength(45), Required]
        public string Email { get; set; }
        [Column("contraseña"), StringLength(45), Required]
        public string Contraseña { get; set; }


    }
}
