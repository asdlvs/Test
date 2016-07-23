using System.Web.Http;

namespace StrongTest.Api.Controllers
{
    public class TestController : ApiController
    {
        [Route("api/test/"), HttpGet]
        public int GetTest()
        {
            return 42;
        }
    }
}
