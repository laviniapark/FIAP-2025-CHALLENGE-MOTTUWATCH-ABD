using Xunit;

namespace ManagementApp.Tests ;

    [CollectionDefinition("API Tests")]
    public class ApiTestCollection : ICollectionFixture<CustomWebAppFactory>
    {
        
    }