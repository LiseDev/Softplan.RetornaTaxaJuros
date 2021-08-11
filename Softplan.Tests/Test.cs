using Softplan.CalculaJuros.Controllers;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Softplan.Tests
{
    public class Test
    {
        [Fact]
        public void Deveria_retornar_url_do_github()
        {
            //Arrange           
            ShowmethecodeController controller = new ShowmethecodeController();

            //Act
            var result = controller.Get();


            //Assert
            result.Should().BeOfType<OkObjectResult>();
             ((OkObjectResult)result).Value.Should().Be("https://github.com/");
        }

        [Theory]
        [InlineData(100, 5, "105,10")]
        [InlineData(100, 3, "103,03")]
        [InlineData(0, 3, "0,00")]
        public async Task Deveria_calcular_juros(double initialValue, int months, string expectedValue)
        {
            //Arrange
            CalculaJurosController controller = new CalculaJurosController();

            //Act
            var result = await controller.GetAsync(initialValue, months);

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            ((OkObjectResult)result).Value.Should().Be(expectedValue);
        }
    }
}