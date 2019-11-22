using MenuesConsola;
using consolaCajero;
using ConsolaCajero.Menu;
using ProgramaGerente.Menu;

namespace ConsolaCajero
{
    public class Program
    {
        static void Main(string[] args)
        {
           //var menuListaCajeros = new MenuListaCajeros() { Nombre = "Listado Cajeros" };
           //var menuAltaCajero = new MenuAltaCajero() { Nombre = "Alta Cajero" };
           //var menuAltaEntrada = new MenuAltaEntrada() { Nombre = "Alta Entrada" };

            var login = new Login() { Nombre = "Inicio Usuario" };
            login.mostrar();
        }
    }
}
