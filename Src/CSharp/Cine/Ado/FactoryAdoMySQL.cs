using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Cine.Ado
{
    public class FactoryAdoMySQL
    {
        public static MySQLADO GetAdo(string cadena)
        {
            var dbContextOptions = new DbContextOptionsBuilder();
            dbContextOptions.UseMySQL(cadena);
            return new MySQLADO(dbContextOptions.Options);
        }
        public static MySQLADO GetAdoDesdeJson(string archivo, string atributoJson)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(archivo, optional: true, reloadOnChange: true)
                .Build();
            string cadena = config.GetConnectionString(atributoJson);
            return GetAdo(cadena);
        }
    }
}
