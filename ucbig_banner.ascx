<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucbig_banner.ascx.vb" Inherits="ucbig_banner" %>
<link rel="stylesheet" href="css/slider.css" type="text/css" media="screen" /> 
<link rel="stylesheet" href="css/page.css" type="text/css" media="screen" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery.easing.1.2.js"></script>
<script src="js/jquery.anythingslider.js" type="text/javascript" ></script>
<script type="text/javascript">
    function formatText(index, panel) {
	  return index + "";
    }
    $(function () {
    
        $('.anythingSlider').anythingSlider({
            easing: "easeInOutExpo",        // Anything other than "linear" or "swing" requires the easing plugin
            autoPlay: true,                 // This turns off the entire FUNCTIONALY, not just if it starts running or not.
            delay: 9000,                    // How long between slide transitions in AutoPlay mode
            startStopped: false,            // If autoPlay is on, this can force it to start stopped
            animationTime: 5900,             // How long the slide transition takes
            hashTags: true,                 // Should links change the hashtag in the URL?
            buildNavigation: true,          // If true, builds and list of anchor links to link to each slide
    		pauseOnHover: true,             // If true, and autoPlay is enabled, the show will pause on hover
    		startText: " ",             // Start text
	        stopText: " ",               // Stop text
	        navigationFormatter: formatText       // Details at the top of the file on this use (advanced use)
        });
        
        $("#slide-jump").click(function(){
            $('.anythingSlider').anythingSlider(6);
        });
        
    });
</script>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<table width=925px height=377 background="imagens/bgSite.jpg" >
    <tr>
        <td valign=top style="padding-left:12px; padding-top:12px;">
<div class="anythingSlider"><div class="wrapper"><ul><%=fCarregarBigBanners()%></ul></div></div>
        </td>
    </tr>
</table>
