colorBoxz = function() {
	$('.sin_modal').colorbox({
		rel:'sin_modal',
		transition:'fade',
		maxWidth: '75%'
	});
};

menulateralResponsivo = function() {
	$(".mostrarMenu").click(function() {
            $(this).fadeOut(700), $("#menuLateral").animate({left: "0%"}, 700, "easeInOutCubic", function() {
                $(".ocultarMenu").fadeIn()
            });
       });
	   $(".ocultarMenu").click(function() {
            $(this).fadeOut(700), $("#menuLateral").animate({left: "-100%"}, 700, "easeInOutCubic", function() {
                $(".mostrarMenu").hide().fadeIn(700)
        });
	});
};

inicio = function() {
	colorBoxz();
	menulateralResponsivo();
}