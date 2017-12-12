<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IDU0815Phoning._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %>.</h1>
     <h2>How are you doing today?</h2>
     <p class="lead">Here you can see the list of every events recorded in our database.
         You can select a specific Call, a specific Caller, and use some filters.
     </p>

    <asp:SqlDataSource ID="eventDB" runat="server" 
            ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" 
            SelectCommand="SELECT * FROM [T_EVENT]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="callDB" runat="server" 
            SelectCommand="SELECT * FROM [T_CALL]" 
            ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>"></asp:SqlDataSource>

    
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="RECORD_ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="60%" >
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:HyperLinkField
                    DataNavigateUrlFields="CALL_ID"
                    DataNavigateUrlFormatString="CallDetails.aspx?id={0}"
                    DataTextField="CALL_ID"
                    HeaderText="Call ID"
                    SortExpression="CALL_ID" />
            <asp:HyperLinkField
                    DataNavigateUrlFields="CALLER"
                    DataNavigateUrlFormatString="CallList.aspx?caller={0}"
                    DataTextField="CALLER"
                    HeaderText="Caller"
                    SortExpression="CALLER" />
            <asp:BoundField DataField="EVENT_NAME" HeaderText="Event" SortExpression="EVENT_NAME" />
            <asp:BoundField DataField="RECEIVER" HeaderText="Receiver" SortExpression="RECEIVER" />
            <asp:BoundField DataField="RECORD_DATE" HeaderText="Date" SortExpression="RECORD_DATE" />
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
    <strong>
    <br />
    Page Size

    </strong>

    <asp:DropDownList ID="ddl_PageSize" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
        Width="40px">
        <asp:ListItem Value= "5"/>
        <asp:ListItem Value= "10" Selected="True"/>
        <asp:ListItem Value= "15"/>
        <asp:ListItem Value= "20"/>
        <asp:ListItem Value= "30"/>
        <asp:ListItem Value= "40"/>
    </asp:DropDownList>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filter by
    <asp:DropDownList ID ="FilterByDropDownList" runat="server">
        <asp:ListItem Text="Caller" Value="CALLER" Selected="True"/>
        <asp:ListItem Text="Receiver" Value="RECEIVER" />
        <asp:ListItem Text="Event" Value="EVENT_NAME" />
    </asp:DropDownList>

        <asp:TextBox ID="SearchTextBox" runat="server" ></asp:TextBox>
        <asp:Button ID="SearchButton" runat="server" Text="Search"/>

    <br />
    <br />
    <br />
    
            <asp:ListView ID="eventList"
                 ItemType="IDU0815Phoning.Phoning.T_EVENT_TYPE"
                 runat="server"
                 SelectMethod="GetEventTypes" style="font-size: small" >
                     <ItemTemplate>
                         <b style="font-size: large; font-style: normal">
                             <a href="/EventList.aspx?id=<%#: Item.EVENT_ID %>">
                             <%#: Item.EVENT_NAME %>
                             </a>
                         </b>
                     </ItemTemplate>
                 <ItemSeparatorTemplate> | </ItemSeparatorTemplate>
             </asp:ListView>
     <br />

     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALLER, T_CALL.RECEIVER, T_EVENT_TYPE.EVENT_NAME FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID INNER JOIN T_EVENT_TYPE ON T_EVENT.RECORD_EVENT_ID = T_EVENT_TYPE.EVENT_ID" FilterExpression="CONVERT({0},'System.String') LIKE '%{1}%'"> 
        <FilterParameters>
            <asp:ControlParameter ControlID="FilterByDropDownList" Name="FieldToSearch" PropertyName="SelectedValue" />    
            <asp:ControlParameter ControlID="SearchTextBox" Name="Search Criteria" PropertyName="Text"  />
        </FilterParameters>
     </asp:SqlDataSource>
    


</asp:Content>

     
