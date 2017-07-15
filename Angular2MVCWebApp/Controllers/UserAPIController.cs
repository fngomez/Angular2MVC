namespace Angular2MVCWebApp.Controllers
{
    using System.Linq;
    using System.Net.Http;
    using System.Web.Http;
    using System.Data.Entity;
    using Angular2MVCWebApp.DBContext;

    public class UserApiController : BaseApiController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(DatabaseEntities.User.AsEnumerable());
        }

        public HttpResponseMessage Post([FromBody]User user)
        {
            DatabaseEntities.User.Add(user);
            return ToJson(DatabaseEntities.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]User user)
        {
            DatabaseEntities.Entry(user).State = EntityState.Modified;
            return ToJson(DatabaseEntities.SaveChanges());
        }

        public HttpResponseMessage Delete(int id)
        {
            User user = DatabaseEntities.User.FirstOrDefault(u => u.Id == id);
            DatabaseEntities.User.Remove(user);
            return ToJson(DatabaseEntities.SaveChanges());
        }
    }
}
