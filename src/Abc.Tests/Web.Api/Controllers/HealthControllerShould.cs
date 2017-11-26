using Microsoft.AspNetCore.Mvc;
using Abc.Web.Api.Controllers;
using Xunit;

namespace Abc.Tests.Web.Api.Controllers
{
    public class HealthControllerShould
    {
        [Fact]
        public void Return_OkResult_When_Api_Is_Healthy()
        {
            var controller = new HealthController();

            var response = controller.IsHealthy();

            Assert.IsAssignableFrom<OkResult>(response);
        }
    }
}
