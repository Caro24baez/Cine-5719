using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cine;
using Cine.Ado;

namespace TestAdoMySQLCore
{
    [TestClass]
    public class TestsCreacionBD
    {
        public static MySQLADO AdoMySQL { get; set; }

        [ClassInitialize]
        public static void SetUpClase(TestContext context)
        {
            AdoMySQL = new MySQLADO();
            AdoMySQL.Database.EnsureDeleted();
        }

        [TestMethod]
        public void SeCreaBD()
        {
            AdoMySQL.Database.EnsureCreated();
        }
    }
}
