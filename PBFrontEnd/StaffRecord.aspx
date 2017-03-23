<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="StaffRecord.aspx.cs" Inherits="StaffRecord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblStaffRecord" runat="server" Font-Bold="True" Font-Underline="True" Text="Staff Record"></asp:Label>
    </p>
    <p style="margin-left: 400px">
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txt_StaffID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffFName" runat="server" Text="First Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffFName" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffSName" runat="server" Text="Surname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffSName" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffAddress" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffPostcode" runat="server" Text="Postcode"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffPostcode" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        &nbsp;<asp:Label ID="lblStaffPhoneNo" runat="server" Text="Phone Number"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtStaffPhoneNo" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffEmail" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffDOB" runat="server" Text="Date Of Birth"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffDOB" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffPosition" runat="server" Text="Job Position"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffPosition" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        <asp:Label ID="lblStaffSalary" runat="server" Text="Salary"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffSalary" runat="server"></asp:TextBox>
    </p>
<p style="margin-left: 400px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" Height="25px" Text="OK" Width="75px" OnClick="btnOK_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Height="25px" Text="Cancel" Width="75px" OnClick="btnCancel_Click" />
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

