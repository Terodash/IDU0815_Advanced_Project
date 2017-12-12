<%@ Page Title = "oui" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="CallDetails.aspx.cs"
    Inherits="IDU0815Phoning.CallDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="font-weight: 700">
        <br />
        <%=CheckStateOfCall()%> call. </div>
    <asp:TextBox ID="txtSearch" runat="server" Visible="false"></asp:TextBox>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RECORD_ID,Expr1" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="50%" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CALL_ID" HeaderText="Call ID" SortExpression="CALL_ID" />
            <asp:HyperLinkField
                    DataNavigateUrlFields="CALLER"
                    DataNavigateUrlFormatString="CallList.aspx?caller={0}"
                    DataTextField="CALLER"
                    HeaderText="Caller"
                    SortExpression="CALLER" />
            <asp:BoundField DataField="EVENT_NAME" HeaderText="Event" SortExpression="RECORD_EVENT_ID" />
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
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALL_ID AS Expr1, T_CALL.CALLER, T_CALL.RECEIVER, T_EVENT_TYPE.EVENT_NAME FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID INNER JOIN T_EVENT_TYPE ON T_EVENT.RECORD_EVENT_ID = T_EVENT_TYPE.EVENT_ID" FilterExpression="CALL_ID = '{0}'">
    <FilterParameters>
         <asp:ControlParameter Name="CALL_ID" ControlID="txtSearch" PropertyName="Text" />
     </FilterParameters>
    </asp:SqlDataSource>
    <div style="font-weight: 700"><%=GetTimestamp()%></div>
    </asp:Content>