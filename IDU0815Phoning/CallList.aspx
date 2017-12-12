<%@ Page Title="CallList" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="CallList.aspx.cs"
    Inherits="IDU0815Phoning.CallList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:TextBox ID="textCaller" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="textEvent" runat="server" Visible="false"></asp:TextBox>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RECORD_ID,Expr1" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="40%" HorizontalAlign="Center" AllowPaging="true" AllowSorting="true">
        <Columns>
            <asp:HyperLinkField
                    DataNavigateUrlFields="CALL_ID"
                    DataNavigateUrlFormatString="CallDetails.aspx?id={0}"
                    DataTextField="CALL_ID"
                    HeaderText="Call ID"
                    SortExpression="CALL_ID" />
            <asp:BoundField DataField="EVENT_NAME" HeaderText="Event"  />
            <asp:BoundField DataField="RECORD_DATE" HeaderText="Date" SortExpression="RECORD_DATE" />
            <asp:BoundField DataField="RECEIVER" HeaderText="Receiver" SortExpression="RECEIVER" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White"/>
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALL_ID AS Expr1, T_CALL.CALLER, T_CALL.RECEIVER, T_EVENT_TYPE.EVENT_NAME FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID INNER JOIN T_EVENT_TYPE ON T_EVENT.RECORD_EVENT_ID = T_EVENT_TYPE.EVENT_ID" FilterExpression="CALLER = '{0}' AND EVENT_NAME = '{1}'">
    <FilterParameters>
         <asp:ControlParameter Name="CALLER" ControlID="textCaller" PropertyName="Text" />
         <asp:ControlParameter Name="RECORD_EVENT_ID" ControlID="textEvent" DefaultValue="Pick-up" PropertyName="Text" />
     </FilterParameters>
    </asp:SqlDataSource>
    </asp:Content>
