using HttpServer;

namespace HttpServerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //HttpRequestParser httpRequestParser = new HttpRequestParser();
        }

        [Test]
        public void IsAppsettingNotEmptyTest()
        {
            Datasource datasource = new Datasource();
            string connectionString = "";
            
            connectionString =  datasource.readAppsettings();


            Assert.IsNotEmpty(connectionString);
            //Assert.Pass();
        }

        [Test]
        public void IsAppsettingEmptyTest()
        {
            Datasource datasource = new Datasource();
            string connectionString = "";

            connectionString = datasource.readAppsettings();


            Assert.IsEmpty(connectionString);
            //Assert.Pass();
        }

        [Test]
        public void GetConnectionstringTest()
        {
            Datasource datasource = new Datasource();
            string connectionString = "12345string";

            string DTSConnectionString = datasource.readAppsettings();


            Assert.True(connectionString == DTSConnectionString);
        }


    }
}