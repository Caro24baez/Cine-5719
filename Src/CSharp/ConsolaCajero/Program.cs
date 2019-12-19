using MenuesConsola;
using ConsolaCajero;
using ConsolaCajero.Menu;

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
