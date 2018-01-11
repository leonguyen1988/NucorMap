<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeBehind.aspx.cs" Inherits="Demos_CodeBehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF99FF;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h1>Hi visitor and welcome to Nucor Map</h1>
              <p>We&#39;re glad you&#39;re<span class="auto-style1"> paying a visit</span> to <strong>Nucor Yamato Company</strong>, the one of biggest steel company in United States.                
              </p>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

    </form>
</body>
</html>
