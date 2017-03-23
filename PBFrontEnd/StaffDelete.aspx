<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="StaffDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 440px">
        <asp:TextBox ID="txtDelStaffID" runat="server"></asp:TextBox>
&nbsp;
    </p>
    <p style="margin-left: 440px">
        <asp:Label ID="lblDeleteConfirm" runat="server" Text="Are you sure you want to delete this Staff's data?"></asp:Label>
    </p>
    <p style="margin-left: 440px">
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
    </p>
    <p style="margin-left: 440px">
        <asp:Label ID="lblDelStaffID" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
