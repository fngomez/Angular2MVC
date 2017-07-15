namespace Angular2MVCWebApp.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Web.Http;
    using Newtonsoft.Json;
    using Angular2MVCWebApp.DBContext;

    public class BaseApiController : ApiController
    {
        protected readonly DatabaseEntities DatabaseEntities = new DatabaseEntities();

        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
