using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cine;
using Cine.Ado;

namespace TestAdoMySQLCore
{
    [TestClass]
    public class TestsCreacionBD
    {
        public static MySQLADo AdoMySQL { get; set; }

        [ClassInitialize]
        public static void SetUpClase(TestContext context)
        {
            AdoMySQL = new MySQLADo();
            AdoMySQL.Database.EnsureDeleted();
        }

        [TestMethod]
        public void SeCreaBD()
        {
            AdoMySQL.Database.EnsureCreated();
        }
    }
}
