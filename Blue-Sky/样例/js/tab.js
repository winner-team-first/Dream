/*var i, j,
	navLis = document.getElementById( "nav" )
			.getElementsByTagName( "li" ),
	cont = document.getElementById( "cont" );
			
for( i = 0; i < navLis.length; i++ ){
	navLis[i].index = i;
	navLis[i].onmouseover = function(){
		this.className = "select";
		cont.style.top = -105 * this.index + "px";
	};
	navLis[i].onmouseout = function(){
		this.className = "";
	};
}*/

$( document ).ready(function(e) {
    $( "#nav li" ).mouseover(function(){
		var index = $( this ).index();
		$( this ).addClass( "select" ).siblings().removeClass( "select" );
		//$( "#cont ul" ).eq( index ).show().siblings().hide();
		/*$( "#cont" ).css({ 
			"top": -105 * index,
			"left": -20 * index
		});*/
		$( "#cont" ).stop().animate( {"top": -105 * index, "left": -20 * index }, 500 );
	});
});