using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
using System.ServiceModel.Web;
using System.Threading;

namespace RestWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        private List<User> users = new List<User>();

        public UserService()
        {
            users.Add(new User()
            {
                Id = 0,
                Name = "Pisockiy Pavel"
            });

            users.Add(new User()
            {
                Id = 1,
                Name = "Klimov Evgen"
            });

            users.Add(new User()
            {
                Id = 2,
                Name = "Pomikanov Andrey"
            });

            users.Add(new User()
            {
                Id = 3,
                Name = "Rudenko Anna"
            });
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "users/{id}")]
        public User User(string id)
        {
            var auth = Thread.CurrentPrincipal.Identity.IsAuthenticated;
            return users.Find(user => user.Id.ToString() == id);
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "users")]
        public IEnumerable<User> Users()
        {
            return users;
        }
    }
}
