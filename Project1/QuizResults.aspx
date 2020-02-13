<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuizResults.aspx.cs" Inherits="Project1.QuizResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Server Side Project 1</title>
    <link rel="stylesheet" type="text/css"  href="main.css"  />
   
</head>
<body>
    <div  id="top"></div>
    <form id="form1" runat="server">
        
        <p style="width: 1057px">
        <asp:Label ID="lblDisplay" runat="server" Text="Label" style="position: absolute; z-index: 1; left: 50px; top: 421px; width: 548px"></asp:Label>
        </p>
        
        <div>
        
            <asp:Label ID="lblQuestion1" runat="server" style="z-index: 1; left: 42px; top: 483px; position: absolute; width: 598px" Text="Label"></asp:Label>
             </div>
        <br /><br />
        <asp:Label ID="lblScore" runat="server" style="z-index: 1; left: 46px; top: 592px; position: absolute; height: 3px" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
