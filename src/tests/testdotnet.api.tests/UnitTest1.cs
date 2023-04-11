namespace testdotnet.api.tests;
using testdotnet.api.Controllers;
using testdotnet.api;
using Microsoft.Extensions.Logging;
using Moq;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
  var mock = new Mock<ILogger<WeatherForecastController>>();

        ILogger<WeatherForecastController> logger = mock.Object;

        var weatherForecastController = new WeatherForecastController(logger);
      
        var data=weatherForecastController.Get();
        
         Assert.Equal(data.Count(),5);
    }
}