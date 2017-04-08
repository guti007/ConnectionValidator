using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace CredentialValidator
{
    public class Helper
    {
        static Helper()
        {
            _filePath = ConfigurationManager.AppSettings["certificatePath"];
            _serviceUrl = ConfigurationManager.AppSettings["serviceUrl"];
        }

        readonly static string _filePath;

        static string _serviceUrl;

        public static string ServiceUrl
        {
            get { return _serviceUrl; }
            internal set { _serviceUrl = value; }
        }

        public static X509Certificate GetCertificate(string certificateType)
        {
            X509Certificate x509Certificate = null;
            if (certificateType == "X509Certificate")
            {
                x509Certificate = new X509Certificate(_filePath);
            }
            else if (certificateType == "X509Certificate2")
            {
                x509Certificate = new X509Certificate2(_filePath);
            }
            else
            {

            }

            return x509Certificate;
        }
    }
}