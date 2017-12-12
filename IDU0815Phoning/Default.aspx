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

    <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"   
            BackColor="White" BorderColor="White"   
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="6" CellSpacing="5"   
            GridLines="None" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" RowStyle-HorizontalAlign="Center" DataKeyNames="RECORD_ID,Expr1">  
            <Columns>  
               
                <asp:BoundField DataField="RECORD_ID" HeaderText="RECORD_ID" InsertVisible="False" ReadOnly="True" SortExpression="RECORD_ID" />
                <asp:BoundField DataField="RECORD_EVENT_ID" HeaderText="RECORD_EVENT_ID" SortExpression="RECORD_EVENT_ID" />
                <asp:BoundField DataField="RECORD_DATE" HeaderText="RECORD_DATE" SortExpression="RECORD_DATE" />
                <asp:BoundField DataField="CALL_ID" HeaderText="CALL_ID" SortExpression="CALL_ID" />
                <asp:BoundField DataField="Expr1" HeaderText="Expr1" InsertVisible="False" ReadOnly="True" SortExpression="Expr1" />
                <asp:BoundField DataField="CALLER" HeaderText="CALLER" SortExpression="CALLER" />
                <asp:BoundField DataField="RECEIVER" HeaderText="RECEIVER" SortExpression="RECEIVER" />

            </Columns>  
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />  
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />  
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />  
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />  
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#F1F1F1" />  
            <SortedAscendingHeaderStyle BackColor="#594B9C" />  
            <SortedDescendingCellStyle BackColor="#CAC9C9" />  
            <SortedDescendingHeaderStyle BackColor="#33276A" />  

        </asp:GridView>  --%>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="RECORD_ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="60%"  >
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            
            <%--<asp:HyperLinkField
                    DataNavigateUrlFields="RECORD_ID"
                    DataNavigateUrlFormatString="EventDetails.aspx?id={0}"
                    DataTextField="RECORD_EVENT_ID"
                    HeaderText="Event"
                        SortExpression="RECORD_EVENT_ID" />--%>
            <asp:HyperLinkField
                    DataNavigateUrlFields="CALL_ID"
                    DataNavigateUrlFormatString="CallDetails.aspx?id={0}"
                    DataTextField="CALL_ID"
                    HeaderText="Caller"
                    SortExpression="CALL_ID" />
            <%--<asp:BoundField DataField="CALL_ID" HeaderText="Call ID" SortExpression="CALL_ID" />--%>
            <asp:HyperLinkField
                    DataNavigateUrlFields="CALLER"
                    DataNavigateUrlFormatString="CallList.aspx?caller={0}"
                    DataTextField="CALLER"
                    HeaderText="Caller"
                    SortExpression="CALLER" />
            <%--<asp:BoundField DataField="CALLER" HeaderText="Caller" SortExpression="CALLER" />--%>
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
    </asp:DropDownList>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filter by
    <asp:DropDownList ID ="FilterByDropDownList" runat="server">
        <asp:ListItem Text="Caller" Value="CALLER" Selected="True"/>
        <asp:ListItem Text="Receiver" Value="RECEIVER" />
        <asp:ListItem Text="Event" Value="EVENT_NAME" />
    </asp:DropDownList>

    <%--<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">--%>
        <asp:TextBox ID="SearchTextBox" runat="server" ></asp:TextBox>
        <asp:Button ID="SearchButton" runat="server" Text="Search"/>
    <%--</asp:Content>--%>

    <br />
    <br />
    <br />
    <%--<asp:SqlDataSource ID="sds_Items" runat="server" 
            ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" 
            SelectCommand="SELECT * FROM [T_EVENT]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sds_Location" runat="server" 
            SelectCommand="SELECT * FROM [T_CALL]" 
            ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>"></asp:SqlDataSource>
        
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataSourceID="sds_Items">
            <Columns>
                <asp:TemplateField HeaderText="Call number" >
                    <itemtemplate>
                        <asp:Label ID="call_id" runat="server" Text='<%# Bind("CALL_ID") %>'></asp:Label>
                    </itemtemplate>
                    
                    <itemstyle width="80px" /> 
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Receiver" >
                    <ItemTemplate>
                        <asp:Label ID="lblLocation" runat="server" Text='<%# LookupLocation(DataBinder.Eval(Container.DataItem, "CALL_ID")) %>'></asp:Label> 
                    </ItemTemplate>
                    
                   <ItemStyle Width="25%" /> 
               </asp:TemplateField>
            </Columns>
        </asp:GridView>--%>

<%--    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False"   
            DataKeyNames="RECORD_ID" BackColor="White" BorderColor="White"   
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="6" CellSpacing="5"   
            GridLines="None" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">  
            <Columns>  
                <asp:HyperLinkField
                    DataNavigateUrlFields="RECORD_ID"
                    DataNavigateUrlFormatString="EventDetails.aspx?id={0}"
                    DataTextField="RECORD_ID"
                    HeaderText="ID"
                    SortExpression="RECORD_ID" />
                <asp:BoundField DataField="RECORD_EVENT_ID" HeaderText="Type" SortExpression="RECORD_EVENT_ID" />
                <asp:BoundField DataField="RECORD_DATE" HeaderText="Date" SortExpression="RECORD_DATE" />
                <asp:BoundField DataField="CALL_ID" HeaderText="Call" SortExpression="CALL_ID" />

            </Columns>  
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />  
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />  
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />  
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />  
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#F1F1F1" />  
            <SortedAscendingHeaderStyle BackColor="#594B9C" />  
            <SortedDescendingCellStyle BackColor="#CAC9C9" />  
            <SortedDescendingHeaderStyle BackColor="#33276A" />  

        </asp:GridView>--%>

     <br />

<%--     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_EVENT_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALL_ID AS Expr1, T_CALL.CALLER, T_CALL.RECEIVER FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID" FilterExpression="CONVERT([CALLER],'System.String') LIKE '{0}%'">--%>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALLER, T_CALL.RECEIVER, T_EVENT_TYPE.EVENT_NAME FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID INNER JOIN T_EVENT_TYPE ON T_EVENT.RECORD_EVENT_ID = T_EVENT_TYPE.EVENT_ID" FilterExpression="CONVERT({0},'System.String') LIKE '{1}%'"> 
        <FilterParameters>
            <%--<asp:ControlParameter Name="CALLER" ControlID="SearchTextBox" PropertyName="Text" Type="String"/>--%>
            <asp:ControlParameter ControlID="FilterByDropDownList" Name="FieldToSearch" PropertyName="SelectedValue" />    
            <asp:ControlParameter ControlID="SearchTextBox" Name="Search Criteria" PropertyName="Text"  />
        </FilterParameters>
     </asp:SqlDataSource>
    


</asp:Content>

     
