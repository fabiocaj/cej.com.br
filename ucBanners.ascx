<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucBanners.ascx.vb" Inherits="ucBanners" %>
<%@ Register Assembly="RadRotator.Net2" Namespace="Telerik.WebControls" TagPrefix="radR" %>
<radr:radrotator id="rrPortal" runat="server" FrameTimeout="5000" TransitionEffect="fade" Height="210px" Width="709px" >
    <FrameTemplate>
        <%# fRetornaHTMLBanner(DataBinder.Eval(Container.DataItem, "tArquivo"), DataBinder.Eval(Container.DataItem, "cTipoBanner")) %>
    </FrameTemplate>
</radr:radrotator>
