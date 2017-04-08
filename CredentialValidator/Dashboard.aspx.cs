using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CredentialValidator
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtServiceUrl.Text = Helper.ServiceUrl;
        }

        protected void SendRequest(object sender, EventArgs e)
        {
            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(txtServiceUrl.Text);

                webRequest.ClientCertificates.Add(Helper.GetCertificate(dropDownCertificateType.SelectedValue));
                webRequest.Method = "GET";

                if (chkUseProvidedCredential.Checked)
                {
                    webRequest.Credentials = new Credentials(txtUserName.Text, txtPassword.Text);
                }
                else
                {
                    webRequest.UseDefaultCredentials = true;
                }

                var webResponse = (HttpWebResponse)webRequest.GetResponse();
                txtResponse.Text = JsonConvert.SerializeObject(webResponse);
            }
            catch (Exception ex)
            {
                txtResponse.Text = JsonConvert.SerializeObject(ex);
            }
            finally
            {
                
            }
        }

        protected void ClearResponse(object sender, EventArgs e)
        {
            txtResponse.Text = String.Empty;
        }
    }
}