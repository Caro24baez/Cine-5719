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

        [ForeignKey("idProyeccion"), Required]
        public Proyeccion Proyeccion { get; set; }

        [Column("numeroEntrada"), Required]
        public int NumeroEntrada { get; set; }

        [Column("funcion"), StringLength(45), Required]
        public string Funcion { get; set; }

        [Column("valor"), Required]
        public int Valor { get; set; }
        
        public List<Proyeccion> Proyecciones { get; set; }

        public Entrada()
        {
            Proyecciones = new List<Proyeccion>();
        }

        public Entrada(int numeroEntrada, string funcion, int valor)
        {
            this.NumeroEntrada = numeroEntrada;
            this.Funcion = funcion;
            this.Valor = valor;
        }
        
        public Entrada(int valor)
        {
            cambiarValorEntrada(valor);
        }

        public void cambiarValorEntrada(int valor)
        {
            Proyeccion proyeccion = new Proyeccion(this);
            Proyecciones.Add(proyeccion);
        }
    }
}
