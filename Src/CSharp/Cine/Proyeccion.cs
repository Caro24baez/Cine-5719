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
        [Column("valor"), Required]
        public double Valor { get; set; }

        public void cambiarPrecioEntrada(object valor)
        {
            throw new NotImplementedException();
        }

        public List<Entrada> Entradas { get; set; }
        public Proyeccion() {

            Entradas = new List<Entrada>();
        } 
        public Proyeccion(Pelicula pelicula, Sala sala, double valor) : this ()
        {
            Sala = sala;
            Pelicula = pelicula;
            Valor = valor;
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
        public int EntradasDisponibles()
        {
            return Entradas.Count - Sala.Capacidad;
        }
        public void venderEntrada(Cajero cajero)
        {
            Entrada entrada = new Entrada(this, cajero);
            Entradas.Add(entrada);
        }

        //public void cambiarPrecioEntrada(float valor);
        //{
        //    Valor = valor;
        //   Entrada entrada = new Entrada(this);
        //   Entradas.Add(entrada);
        //}
    }
}
