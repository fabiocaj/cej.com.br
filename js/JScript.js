
$(document).ready(function(){

	var Playlist = function(instance, playlist, options) {
		var self = this;

		this.instance = instance; // String: To associate specific HTML with this playlist
		this.playlist = playlist; // Array of Objects: The playlist
		this.options = options; // Object: The jPlayer constructor options for this playlist

		this.current = 0;

		this.cssId = {
			jPlayer: "jquery_jplayer_",
			interface: "jp_interface_",
			playlist: "jp_playlist_"
		};
		this.cssSelector = {};

		$.each(this.cssId, function(entity, id) {
			self.cssSelector[entity] = "#" + id + self.instance;
		});

		if(!this.options.cssSelectorAncestor) {
			this.options.cssSelectorAncestor = this.cssSelector.interface;
		}

		$(this.cssSelector.jPlayer).jPlayer(this.options);

		$(this.cssSelector.interface + " .jp-previous").click(function() {
			self.playlistPrev();
			$(this).blur();
			return false;
		});

		$(this.cssSelector.interface + " .jp-next").click(function() {
			self.playlistNext();
			$(this).blur();
			return false;
		});
	};

	Playlist.prototype = {
		displayPlaylist: function() {
			var self = this;
			$(this.cssSelector.playlist + " ul").empty();
			for (i="0"; i < this.playlist.length; i++) {
				var listItem = (i === this.playlist.length-1) ? "<li class='jp-playlist-last'>" : "<li>";
				listItem += "<a href='#' id='" + this.cssId.playlist + this.instance + "_item_" + i +"' tabindex='1'>"+ this.playlist[i].name +"</a>";

				// Create links to free media
				if(this.playlist[i].free) {
					var first = true;
					listItem += "<div class='jp-free-media'>(";
					$.each(this.playlist[i], function(property,value) {
						if($.jPlayer.prototype.format[property]) { // Check property is a media format.
							if(first) {
								first = false;
							} else {
								listItem += " | ";
							}
							listItem += "<a id='" + self.cssId.playlist + self.instance + "_item_" + i + "_" + property + "' href='" + value + "' tabindex='1'>" + property + "</a>";
						}
					});
					listItem += ")</span>";
				}

				listItem += "</li>";

				// Associate playlist items with their media
				$(this.cssSelector.playlist + " ul").append(listItem);
				$(this.cssSelector.playlist + "_item_" + i).data("index", i).click(function() {
					var index = $(this).data("index");
					if(self.current !== index) {
						self.playlistChange(index);
					} else {
						$(self.cssSelector.jPlayer).jPlayer("play");
					}
					$(this).blur();
					return false;
				});

				// Disable free media links to force access via right click
				if(this.playlist[i].free) {
					$.each(this.playlist[i], function(property,value) {
						if($.jPlayer.prototype.format[property]) { // Check property is a media format.
							$(self.cssSelector.playlist + "_item_" + i + "_" + property).data("index", i).click(function() {
								var index = $(this).data("index");
								$(self.cssSelector.playlist + "_item_" + index).click();
								$(this).blur();
								return false;
							});
						}
					});
				}
			}
		},
		playlistInit: function(autoplay) {
			if(autoplay) {
				this.playlistChange(this.current);
			} else {
				this.playlistConfig(this.current);
			}
		},
		playlistConfig: function(index) {
			$(this.cssSelector.playlist + "_item_" + this.current).removeClass("jp-playlist-current").parent().removeClass("jp-playlist-current");
			$(this.cssSelector.playlist + "_item_" + index).addClass("jp-playlist-current").parent().addClass("jp-playlist-current");
			this.current = index;
			$(this.cssSelector.jPlayer).jPlayer("setMedia", this.playlist[this.current]);
		},
		playlistChange: function(index) {
			this.playlistConfig(index);
			$(this.cssSelector.jPlayer).jPlayer("play");
		},
		playlistNext: function() {
			var index = (this.current + 1 < this.playlist.length) ? this.current + 1 : 0;
			this.playlistChange(index);
		},
		playlistPrev: function() {
			var index = (this.current - 1 >= 0) ? this.current - 1 : this.playlist.length - 1;
			this.playlistChange(index);
		}
	};

	var videoPlaylist = new Playlist("1", [
		{
			name:"Big Buck Bunny Trailer",
			free:true,
			m4v:"http://www.jplayer.org/video/m4v/Big_Buck_Bunny_Trailer_480x270_h264aac.m4v",
			ogv:"http://www.jplayer.org/video/ogv/Big_Buck_Bunny_Trailer_480x270.ogv",
			poster:"http://www.jplayer.org/video/poster/Big_Buck_Bunny_Trailer_480x270.png"
		},
		{
			name:"Finding Nemo Teaser",
			m4v: "http://www.jplayer.org/video/m4v/Finding_Nemo_Teaser_640x352_h264aac.m4v",
			ogv: "http://www.jplayer.org/video/ogv/Finding_Nemo_Teaser_640x352.ogv",
			poster: "http://www.jplayer.org/video/poster/Finding_Nemo_Teaser_640x352.png"
		},
		{
			name:"Incredibles Teaser",
			m4v: "http://www.jplayer.org/video/m4v/Incredibles_Teaser_640x272_h264aac.m4v",
			ogv: "http://www.jplayer.org/video/ogv/Incredibles_Teaser_640x272.ogv",
			poster: "http://www.jplayer.org/video/poster/Incredibles_Teaser_640x272.png"
		}
	], {
		ready: function() {
			videoPlaylist.displayPlaylist();
			videoPlaylist.playlistInit(false); // Parameter is a boolean for autoplay.
		},
		ended: function() {
			videoPlaylist.playlistNext();
		},
		play: function() {
			$(this).jPlayer("pauseOthers");
		},
		swfPath: "js",
		supplied: "ogv, m4v"
	});

	var audioPlaylist = new Playlist("2", [
		{
			name:"1) Até o fim (oficial)",
						mp3:"http://dotnet20.cej.com.br/jairbloch.com.br/mp3/Ate-o-fim.mp3",
			oga:"http://dotnet20.cej.com.br/jairbloch.com.br/mp3/Ate-o-fim.ogg" 
									
		},
		{
			name:"2) Olhar pra tras",
			mp3:"mp3/2)-Olhar-pra-tras(oficial).mp3",
			oga:"mp3/2)-Olhar-pra-tras(oficial).ogg"
			
		},
		{
			name:"3) Ninguém sabe o que é ser",
			mp3:"mp3/3)-Ninguem-sabe-o-que-e-ser-(oficial).mp3",
			oga:"mp3/3)-Ninguem-sabe-o-que-e-ser-(oficial).ogg"
			
		},
		{
			name:"4) Filhos e sementes",
			mp3:"mp3/4)-Filhos-e-sementes(master).mp3",
			oga:"mp3/4)-Filhos-e-sementes(master).ogg"
			
		},
		{
			name:"5) Fora do ar",
			mp3:"mp3/5)-Fora-do-ar-(master).mp3",
			oga:"mp3/5)-Fora-do-ar-(master).ogg"
			
		},
		{
			name:"6) Acidente",
			mp3:"mp3/6)-Acidente-(oficial).mp3",
			oga:"mp3/6)-Acidente-(oficial).ogg"
			
		},
		{
			name:"7) Do pecado ao perdão",
			mp3:"mp3/7)-Do-pecado-ao-perdao-(master).mp3",
			oga:"mp3/7)-Do-pecado-ao-perdao-(master).ogg"
			
		},
		{
			name:"8) O Fim",
			mp3:"mp3/8)-O-Fim(mp3).mp3",
			oga:"mp3/8)-O-Fim(mp3).ogg"
			
		},
		{
			name:"9) Todos estamos no mesmo lugar",
			mp3:"mp3/9)-Todos-estamos-no-mesmo-lugar.mp3",
			oga:"mp3/9)-Todos-estamos-no-mesmo-lugar.ogg"
			
		},
		{
			name:"10) Viver e Morrer",
			mp3:"mp3/10)-Viver-e-Morrer-(master).mp3",
			oga:"mp3/10)-Viver-e-Morrer-(master).ogg"
			
		},
		{
			name:"11) Idade",
			mp3:"mp3/11)-Idade-(master).mp3",
			oga:"mp3/10)-Viver-e-Morrer-(master).ogg"
			
		},
		{
			name:"12) Até o fim (versão-2)",
			mp3:"mp3/12)-Até-o-fim-(versão-2).mp3",
			oga:"mp3/10)-Viver-e-Morrer-(master).ogg"
			
		},
		{
			name:"13) Olhar pra trás (versão acústica)",
			mp3:"mp3/13)-Olhar-pra-trás-(versão-acústica).mp3",
			oga:"mp3/10)-Viver-e-Morrer-(master).ogg"
			
		},
		{
			name:"14) Ninguém sabe o que é ser (versão-2)",
			mp3:"mp3/14)-Ninguém-sabe-o-que-é-ser-(versão-2).mp3",
			oga:"mp3/10)-Viver-e-Morrer-(master).ogg"
			
		},
		{
			name:"15) Até o fim (acustica) Bônus",
			mp3:"mp3/Ate-o-fim-(acustica).mp3",
			oga:"mp3/10)-Viver-e-Morrer-(master).ogg"
			
		}

	], {
		ready: function() {
			audioPlaylist.displayPlaylist();
			audioPlaylist.playlistInit(false); // Parameter is a boolean for autoplay.
		},
		ended: function() {
			audioPlaylist.playlistNext();
		},
		play: function() {
			$(this).jPlayer("pauseOthers");
		},
		swfPath: "js",
		supplied: "mp3"
	});
});
