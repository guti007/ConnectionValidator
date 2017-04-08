using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace CredentialValidator
{
    public class Credentials : ICredentials
    {
        public Credentials(string userName,string password)
        {
            _userName = userName;
            _password = password;
        }

        string _userName = String.Empty;
        string _password = String.Empty;

        public NetworkCredential GetCredential(Uri uri, string authType)
        {
            return new NetworkCredential(_userName, _password);
        }
    }
}