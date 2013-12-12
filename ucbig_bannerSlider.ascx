<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucbig_banner.ascx.vb" Inherits="ucbig_banner" %>

		<script type="text/javascript" src="jquery/Slider/jquery-1.3.2.min.js"></script>
		<script type="text/javascript" src="jquery/Slider/jquery-mousewheel/jquery.mousewheel.min.js"></script>
		<link rel="stylesheet" type="text/css" href="jquery/Slider/slidedeck.skin.css" media="screen" />
 <script type='text/javascript' src='http://www.slidedeck.com/wp-content/plugins/slidedeck/lib/slidedeck.jquery.js?ver=1.3.6'></script>

   		
   		  <style type="text/css">
            #slidedeck_frame {
                width: 901px;
                height: 300px;
            }        
          
        </style>
        
        
<table class="style1">
    <tr>
        <td>
           
<div id="slidedeck_frame" class="skin-slidedeck">
			<dl class="slidedeck">
			<%=fCarregarBigBanners()%>
			</dl>
			
		</div><img alt="" src="jquery/Slider/sombra.jpg" style="width: 923px; height: 57px" />
		<script type="text/javascript">
			$('.slidedeck').slidedeck({
                autoPlay: true,
                cycle: true, 
                autoPlayInterval: 5000 
            });
		</script>
	    <!-- Help support SlideDeck! Place this noscript tag on your page when you deploy a SlideDeck to provide a link back! -->
		</td>
    </tr>
    <tr>
        <td valign=top>
            </td>
    </tr>
</table>

        
        
