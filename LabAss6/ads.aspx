<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ads.aspx.cs" Inherits="LabAss6.ads" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 151px;
            width: 423px;
        }
        .auto-style2 {
            height: 91px;
            width: 839px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/App_Data/AdListXMLFIile.xml" KeywordFilter="ads1" />
       Ads 1</div>
        <div>
            <h2>This is my advertisement page</h2></div>

        <div class="auto-style1">
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/App_Data/AdListXMLFIile.xml" KeywordFilter="ads2" />
        Ads 2</div>
    </form>
</body>
</html>
