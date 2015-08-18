<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Calculator</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>

<body>

<div id="framecontentLeft">
</div>

<div id="framecontentRight">
</div>

<div id="maincontent"><div id="resultsDiv">
<div id="imageDiv"><p><img alt="Calculate" src="cashregister.jpg" /></p></div>
<form id="form1" runat="server">

<p><b>Enter transaction amount:</b></p>
    <asp:TextBox ID="transactionAmount" runat="server" align="center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="flightNumberValidate" runat="server" ControlToValidate="transactionAmount" Display="Dynamic"><br />**Required field**</asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="numberValidator" runat="server" Display="dynamic" ControlToValidate="transactionAmount" ValidationExpression="^\d*\.?\d*$" ErrorMessage="** Numbers only **"></asp:RegularExpressionValidator>

<p><b>Enter customer amount:</b></p>
    <asp:TextBox ID="customerAmount" runat="server" align="center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="customerAmount" Display="Dynamic"><p>**Required field**</p></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="numberValidator1" runat="server" Display="dynamic" ControlToValidate="customerAmount" ValidationExpression="^\d*\.?\d*$" ErrorMessage="** Numbers only **"></asp:RegularExpressionValidator>
    <asp:CompareValidator ID="CompareValidator3" Operator="GreaterThanEqual" ControlToValidate="customerAmount" ControlToCompare="transactionAmount" ErrorMessage="<br />** Customer amount needs to be greater or equal to the transaction amount **" runat="server" />
<p><asp:Button ID="calcButton" runat="server" Text="Calculate!" /></p>
</form>

<asp:Literal ID="results" runat="server" Visible="false" />
</div>
</div>



</body>
</html>
