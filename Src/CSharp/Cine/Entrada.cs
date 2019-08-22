using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine
{
    [Table("Entrada")]
    public class Entrada
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idEntrada")]
        public int Id { get; set; }

        [Column("numeroEntrada"), Required]
        public int NumeroEntrada { get; set; }

        [Column("funcion"), StringLength(45), Required]
        public string Funcion { get; set; }

        [Column("valor"), Required]
        public int Valor { get; set; }

        public Entrada() { }

        public Entrada(int numeroEntrada, string funcion, int valor)
        {
            numeroEntrada = NumeroEntrada;
            funcion = Funcion;
            valor = Valor;
        }
        
    }
}
