<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Controls_CBC.ascx.cs" Inherits="WebApplicationRefregitzTow.Controls_CBC"%>
<asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
<asp:Label ID="lblMove" runat="server" Text="0" Visible="False"></asp:Label>
<asp:Label ID="lblMove1" runat="server" Text="NoMove" Visible="False"></asp:Label><br />
<table border="1" style="width: 100%; height: 100%">
    <tr>
        <td style="width: 100px; height: 87px;">
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
            <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image1" runat="server"  /></asp:Panel>
        </td>
        <td style="width: 100px; height: 87px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged"/>
             <asp:Panel ID="Panel2" runat="server" Height="50px" Width="125px">
                 <asp:Image ID="Image2" runat="server" /></asp:Panel>
        </td>
        <td style="width: 100px; height: 87px;">
            <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged"/>
            <asp:Panel ID="Panel3" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image3" runat="server" /></asp:Panel>
        </td>
        <td style="width: 100px; height: 87px;" bgcolor="gray"> 
            <asp:CheckBox ID="CheckBox4" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged"/>
        <asp:Panel ID="Panel4" runat="server" Height="50px" Width="125px">
               <asp:Image ID="Image4" runat="server" />
               </asp:Panel>
        </td>
        <td style="width: 91px; height: 87px;">
        <asp:CheckBox ID="CheckBox5" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged"/>
        <asp:Panel ID="Panel5" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image5" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 87px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged"/>
<asp:Panel ID="Panel6" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image6" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 87px;">
        <asp:CheckBox ID="CheckBox7" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox7_CheckedChanged"/>
<asp:Panel ID="Panel7" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image7" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 107px; height: 87px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox8" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox8_CheckedChanged"/>
<asp:Panel ID="Panel8" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image8" runat="server" />
                </asp:Panel>
        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 45px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox9" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox9_CheckedChanged"/>
<asp:Panel ID="Panel9" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image9" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 45px;">
        <asp:CheckBox ID="CheckBox10" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox10_CheckedChanged"/>
<asp:Panel ID="Panel10" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image10" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 45px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox11" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox11_CheckedChanged"/>
<asp:Panel ID="Panel11" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image11" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 45px;">
        <asp:CheckBox ID="CheckBox12" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox12_CheckedChanged"/>
<asp:Panel ID="Panel12" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image12" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 91px; height: 45px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox13" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox13_CheckedChanged"/>
<asp:Panel ID="Panel13" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image13" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 45px;">
        <asp:CheckBox ID="CheckBox14" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox14_CheckedChanged"/>
<asp:Panel ID="Panel14" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image14" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 100px; height: 45px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox15" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox15_CheckedChanged"/>
<asp:Panel ID="Panel15" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image15" runat="server" />
                </asp:Panel>
        </td>
        <td style="width: 107px; height: 45px;">
        <asp:CheckBox ID="CheckBox16" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox16_CheckedChanged"/>
<asp:Panel ID="Panel16" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image16" runat="server" />
                </asp:Panel>
        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 62px;">
        <asp:CheckBox ID="CheckBox17" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox17_CheckedChanged"/>
<asp:Panel ID="Panel17" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image17" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 62px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox18" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox18_CheckedChanged"/>
<asp:Panel ID="Panel18" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image18" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 62px;">
        <asp:CheckBox ID="CheckBox19" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox19_CheckedChanged"/>
<asp:Panel ID="Panel19" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image19" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 62px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox20" runat="server" AutoPostBack="True"   OnCheckedChanged="CheckBox20_CheckedChanged"/>
<asp:Panel ID="Panel20" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image20" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 91px; height: 62px;">
        <asp:CheckBox ID="CheckBox21" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox21_CheckedChanged"/>
<asp:Panel ID="Panel21" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image21" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 62px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox22" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox22_CheckedChanged"/>
<asp:Panel ID="Panel22" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image22" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 62px;">
        <asp:CheckBox ID="CheckBox23" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox23_CheckedChanged"/>
<asp:Panel ID="Panel23" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image23" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 107px; height: 62px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox24" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox24_CheckedChanged"/>
<asp:Panel ID="Panel24" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image24" runat="server" />
                </asp:Panel>

        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 72px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox25" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox25_CheckedChanged"/>
<asp:Panel ID="Panel25" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image25" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 72px;">
        <asp:CheckBox ID="CheckBox26" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox26_CheckedChanged"/>
<asp:Panel ID="Panel26" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image26" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 72px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox27" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox27_CheckedChanged"/>
<asp:Panel ID="Panel27" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image27" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 72px;">
        <asp:CheckBox ID="CheckBox28" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox28_CheckedChanged"/>
<asp:Panel ID="Panel28" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image28" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 91px; height: 72px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox29" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox29_CheckedChanged"/>
<asp:Panel ID="Panel29" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image29" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 72px;">
        <asp:CheckBox ID="CheckBox30" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox30_CheckedChanged"/>
<asp:Panel ID="Panel30" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image30" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 72px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox31" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox31_CheckedChanged"/>
<asp:Panel ID="Panel31" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image31" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 107px; height: 72px;">
        <asp:CheckBox ID="CheckBox32" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox32_CheckedChanged"/>
<asp:Panel ID="Panel32" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image32" runat="server" />
                </asp:Panel>

        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 81px;">
        <asp:CheckBox ID="CheckBox33" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox33_CheckedChanged"/>
<asp:Panel ID="Panel33" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image33" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 81px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox34" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox34_CheckedChanged"/>
<asp:Panel ID="Panel34" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image34" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 81px;">
        <asp:CheckBox ID="CheckBox35" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox35_CheckedChanged"/>
<asp:Panel ID="Panel35" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image35" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 81px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox36" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox36_CheckedChanged"/>
<asp:Panel ID="Panel36" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image36" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 91px; height: 81px;">
        <asp:CheckBox ID="CheckBox37" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox37_CheckedChanged"/>
<asp:Panel ID="Panel37" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image37" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 81px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox38" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox38_CheckedChanged"/>
<asp:Panel ID="Panel38" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image38" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 81px;">
        <asp:CheckBox ID="CheckBox39" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox39_CheckedChanged"/>
<asp:Panel ID="Panel39" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image39" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 107px; height: 81px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox40" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox40_CheckedChanged"/>
<asp:Panel ID="Panel40" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image40" runat="server" />
                </asp:Panel>

        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 91px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox41" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox41_CheckedChanged"/>
<asp:Panel ID="Panel41" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image41" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 91px;">
        <asp:CheckBox ID="CheckBox42" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox42_CheckedChanged"/>
<asp:Panel ID="Panel42" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image42" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 91px;" bgcolor="gray">
         <asp:CheckBox ID="CheckBox43" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox43_CheckedChanged"/>
<asp:Panel ID="Panel43" runat="server" Height="50px" Width="125px">
               <asp:Image ID="Image43" runat="server" />
               </asp:Panel>

        </td>
        <td style="width: 100px; height: 91px;">
        <asp:CheckBox ID="CheckBox44" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox44_CheckedChanged"/>
<asp:Panel ID="Panel44" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image44" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 91px; height: 91px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox45" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox45_CheckedChanged"/>
<asp:Panel ID="Panel45" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image45" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 91px;">
        <asp:CheckBox ID="CheckBox46" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox46_CheckedChanged"/>
<asp:Panel ID="Panel46" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image46" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 91px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox47" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox47_CheckedChanged"/>
<asp:Panel ID="Panel47" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image47" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 107px; height: 91px;">
        <asp:CheckBox ID="CheckBox48" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox48_CheckedChanged"/>
<asp:Panel ID="Panel48" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image48" runat="server" />
                </asp:Panel>

        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 76px;">
        <asp:CheckBox ID="CheckBox49" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox49_CheckedChanged"/>
<asp:Panel ID="Panel49" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image49" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 76px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox50" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox50_CheckedChanged"/>
<asp:Panel ID="Panel50" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image50" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 76px;">
        <asp:CheckBox ID="CheckBox51" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox51_CheckedChanged"/>
<asp:Panel ID="Panel51" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image51" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 76px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox52" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox52_CheckedChanged"/>
<asp:Panel ID="Panel52" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image52" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 91px; height: 76px;">
        <asp:CheckBox ID="CheckBox53" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox53_CheckedChanged"/>
<asp:Panel ID="Panel53" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image53" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 76px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox54" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox54_CheckedChanged"/>
<asp:Panel ID="Panel54" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image54" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 145px; height: 76px;">
        <asp:CheckBox ID="CheckBox55" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox55_CheckedChanged"/>
<asp:Panel ID="Panel55" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image55" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 107px; height: 76px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox56" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox56_CheckedChanged"/>
<asp:Panel ID="Panel56" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image56" runat="server" />
                </asp:Panel>

        </td>
    </tr>
    <tr>
        <td style="width: 100px; height: 68px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox57" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox57_CheckedChanged"/>
<asp:Panel ID="Panel57" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image57" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 68px;">
        <asp:CheckBox ID="CheckBox58" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox58_CheckedChanged"/>
<asp:Panel ID="Panel58" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image58" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 68px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox59" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox59_CheckedChanged"/>
<asp:Panel ID="Panel59" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image59" runat="server" Height="45px" Width="37px" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 68px;">
        <asp:CheckBox ID="CheckBox60" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox60_CheckedChanged"/>
<asp:Panel ID="Panel60" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image60" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 91px; height: 68px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox61" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox61_CheckedChanged"/>
<asp:Panel ID="Panel61" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image61" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 68px;">
        <asp:CheckBox ID="CheckBox62" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox62_CheckedChanged"/>
<asp:Panel ID="Panel62" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image62" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 100px; height: 68px;" bgcolor="gray">
        <asp:CheckBox ID="CheckBox63" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox63_CheckedChanged"/>
<asp:Panel ID="Panel63" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image63" runat="server" />
                </asp:Panel>

        </td>
        <td style="width: 107px; height: 68px;">
        <asp:CheckBox ID="CheckBox64" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox64_CheckedChanged"/>
<asp:Panel ID="Panel64" runat="server" Height="50px" Width="125px">
                <asp:Image ID="Image64" runat="server" Height="42px" />
                </asp:Panel>

        </td>
    </tr>
</table>

    