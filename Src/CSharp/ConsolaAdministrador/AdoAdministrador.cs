using Cine.Ado;
namespace ConsolaAdministrador.Menu
{
    public static class AdoAdministrador
    {
       public static IADO ADO { get; set; } =
       FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "administrador");
    }
}
