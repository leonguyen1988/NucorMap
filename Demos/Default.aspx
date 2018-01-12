<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Demos_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            color: #FF0000;
        }
    </style>
    <link href="../Styles/Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="PageWrapper">
        <header>Header Goes Here</header>
        <nav>Menu Goes Here</nav>
        <section id="MainContent">
            <h1>hi there visitors and welcome to Nucor Company</h1>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        </section>
       <aside id="Sidebar">Sidebar Goes Here</aside>
        <footer>Footer Goes Here</footer>

    </div>
    </form>
</body>
</html>
