using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
using System.ServiceModel.Web;
using System.Net;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AccountService.svc or AccountService.svc.cs at the Solution Explorer and start debugging.
    public class AccountService : IAccountService
    {
        static List<User> users = UserList.GetUsers;
        
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "SignIn", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public AuthenticationToken SignIn(string login, string password)
        {
            User user = users.Find(u => u.Login == login && u.Password == password);
            if(user == null)
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }
                
            string token = Guid.NewGuid().ToString();
            user.Tokens.Add(token);

            return new AuthenticationToken() { Login = user.Login, Token = token };
        }

        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "SignOut", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public void SignOut(AuthenticationToken authenticationToken)
        {
            if (authenticationToken == null)
                throw new NullReferenceException("Authentication Token is null");

            User user = users.Find(u => u.Login == authenticationToken.Login);
            if(user == null)
                throw new FaultException("Unknown Username");

            if (user.Tokens.Contains(authenticationToken.Token))
            {
                user.Tokens.Remove(authenticationToken.Token);
            }
        }
    }
}
