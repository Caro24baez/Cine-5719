using Cine.Ado;

namespace ConsolaCajero
{
    public static class AdoCajero
    {
            public static IADO ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "cajero");
    }
}
