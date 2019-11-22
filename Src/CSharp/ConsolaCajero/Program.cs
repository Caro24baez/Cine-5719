using MenuesConsola;
using consolaCajero;
using ConsolaCajero.Menu;
using ProgramaGerente.Menu;
using consolaCajero.Menu;

namespace ConsolaCajero
{
    public class Program
    {
        static void Main(string[] args)
        {

            var login = new Login() { Nombre = "Inicio Usuario" };
            login.mostrar();
        }
    }
}
