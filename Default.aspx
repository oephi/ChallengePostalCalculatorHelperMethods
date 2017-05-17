<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Postal Calculator<br />
            <br />
            Width:&nbsp;
            <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
            <br />
            Height:&nbsp;
            <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
            <br />
            Length:&nbsp;
            <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="lengthTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundButton" runat="server" AutoPostBack="True" GroupName="deilveryButtons" OnCheckedChanged="groundButton_CheckedChange" Text="Ground" />
            <br />
            <asp:RadioButton ID="airButton" runat="server" AutoPostBack="True" GroupName="deilveryButtons" OnCheckedChanged="airButton_CheckedChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="nextDayButton" runat="server" AutoPostBack="True" GroupName="deilveryButtons" OnCheckedChanged="nextDayButton_CheckedChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
