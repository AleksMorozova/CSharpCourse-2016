using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DomainModel;
using System.ServiceModel.Web;

namespace RestService
{

    public class DataService : IDataService
    {
        static List<User> users = UserList.GetUsers;

        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public string GetData(string data, AuthenticationToken authenticationToken)
        {
            if(authenticationToken == null)
                throw new NullReferenceException("Authentication Token is null");

            User user = users.Find(u => u.Login == authenticationToken.Login && u.Tokens.Contains(authenticationToken.Token));
            if (user == null)
                throw new FaultException("Unknown Username or Token");

            return user.Login + " - " + data;
        }
    }
}
