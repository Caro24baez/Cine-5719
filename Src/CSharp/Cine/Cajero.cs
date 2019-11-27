using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine
{
    [Table ("Cajero")]
    public class Cajero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column("idCajero")]
        public int Dni { get; set; }
        [ForeignKey("idEntrada"), Required]
        public Entrada Entrada { get; set; }
        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }
        [Column("apellido"), StringLength(45), Required]
        public string Apellido { get; set; }
        [Column("email"), StringLength(45), Required]
        public string Email { get; set; }
        [Column("contrasenia"), StringLength(45), Required]
        public string Contrasenia { get; set; }

        public Cajero(int dni, string nombre, string apellido, string email, string contrasenia)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasenia = contrasenia;

        }

        [NotMapped]
        public string NombreCompleto => $"{Apellido}, {Nombre}";

    }
}