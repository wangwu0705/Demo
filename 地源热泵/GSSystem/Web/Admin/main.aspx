<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="GSSystem.Web.Admin.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理页面</title>
    <style type="text/css">
        BODY {
            FONT-SIZE: 12px;
            COLOR: #000000;
            FONT-FAMILY: 宋体;
            BACKGROUND-COLOR: #d6dff7;
        }

        A {
            FONT: 12px 宋体;
            COLOR: #000000;
            TEXT-DECORATION: none;
        }

            A:hover {
                COLOR: #428eff;
            }

        TD {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: 宋体;
        }

        TH {
            FONT-WEIGHT: bold;
            FONT-SIZE: 12px;
            BACKGROUND-IMAGE: url(images/admin_bg_1.gif);
            COLOR: white;
            BACKGROUND-COLOR: #4455aa;
        }

        TD.txlHeaderBackgroundAlternate {
            COLOR: #ffffff;
            BACKGROUND-COLOR: #799ae1;
        }

        #TableTitleLink A:link {
            COLOR: #ffffff;
            TEXT-DECORATION: none;
        }

        #TableTitleLink A:visited {
            COLOR: #ffffff;
            TEXT-DECORATION: none;
        }

        #TableTitleLink A:active {
            COLOR: #ffffff;
            TEXT-DECORATION: none;
        }

        #TableTitleLink A:hover {
            COLOR: #ffffff;
            TEXT-DECORATION: underline;
        }

        TD.txlRow {
            BACKGROUND-COLOR: #dee5fa;
        }

        TD.txlRowHighlight {
            BACKGROUND-COLOR: #d4def9;
        }

        .tableBorder {
            BORDER-RIGHT: #6595d6 1px solid;
            BORDER-TOP: #6595d6 1px solid;
            BORDER-LEFT: #6595d6 1px solid;
            BORDER-BOTTOM: #6595d6 1px solid;
            BACKGROUND-COLOR: #ffffff;
        }

        INPUT {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: Tahoma,Verdana,宋体;
        }

        SELECT {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: Tahoma,Verdana,宋体;
        }

        TEXTAREA {
            FONT-SIZE: 12px;
            LINE-HEIGHT: 15px;
            FONT-FAMILY: Tahoma,Verdana,宋体;
        }
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body bottommargin="0" bgcolor="#ddeeff" leftmargin="0" topmargin="0" rightmargin="0"
    marginwidth="0" marginheight="0" style ="text-align :center ">
    <form id="form1" runat="server">   
    <script language="javascript"> function jumpto(url) { if (url != '') { window.open(url); } } </script>
        <asp:Image ID="Image1" runat="server" Height="100%" ImageUrl="left.files/images/mainface.jpg" Width="100%" />
    </form>
</body>
</html>
