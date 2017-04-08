<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="CredentialValidator.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Certificate Type :</label>
            <asp:DropDownList ID="dropDownCertificateType" runat="server">
                <asp:ListItem Text="X509Certificate" Value="X509Certificate">
                </asp:ListItem>
                <asp:ListItem Text="X509Certificate2" Value="X509Certificate2">
                </asp:ListItem>
            </asp:DropDownList>
        </div>
         <div>
            <label>Service Url : </label>
            <asp:TextBox ID="txtServiceUrl" runat="server" Width="400px"></asp:TextBox>
        </div>        
         <div>
            <label>Credential : </label>
            <asp:TextBox ID="txtUserName" runat="server"  placeholder="User Name" ></asp:TextBox>
              <asp:TextBox ID="txtPassword" TextMode="Password" PlaceHolder="Password" runat="server"></asp:TextBox>
             <asp:CheckBox ID="chkUseProvidedCredential" runat="server"  />
             <label>Check this to use this credential</label>
        </div>       
        <div>
            
             <asp:Button runat="server" BackColor="SeaShell" Text="Send Request" OnClick="SendRequest" />
        </div>
        <br />
        <br />

        <div>
            <label>Response : </label>
            <asp:Label ID="txtResponse" Min-height="400px" BorderWidth="1px" BorderColor="Black" runat="server" Width="500px" Height="100px" BackColor="WhiteSmoke">

            </asp:Label>
            <asp:Button runat="server" Text="ClearResponse" OnClick="ClearResponse"/>
        </div>
    </form>
</body>
</html>
