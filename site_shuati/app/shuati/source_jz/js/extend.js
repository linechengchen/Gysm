(function($) {
	$.fn.extend({
		star: function(width, height) {
			var num = $(this).attr("data-num");
			for(var i = 0; i < 5; i++) {
				$(this).append("<img src='https://7xlnm9.com2.z0.glb.qiniucdn.com/20160409-weixinstart00@3x.png'>");
			}
			var array = num.split(".");
			$(this).find("img").each(function(index) {
				if(index < array[0]) {
					$(this).attr("src", "https://7xlnm9.com2.z0.glb.qiniucdn.com/20160409-weixinstart10@3x.png");
				}
				if(index == array[0]) {
					$(this).attr("src", "https://7xlnm9.com2.z0.glb.qiniucdn.com/20160409-weixinstart0" + array[1] + "@3x.png");
				}
			});
			$(this).append('<span>' + num + '分</span>');
		},
		stars: function(width, height) {
			var num = $(this).attr("data-num");

			for(var i = 0; i < 5; i++) {
				$(this).append("<img src='https://7xlnm9.com2.z0.glb.qiniucdn.com/20160409-weixinstart00@3x.png'>");
			}
			var array = num.split(".");
			$(this).find("img").each(function(index) {
				if(index < array[0]) {
					$(this).attr("src", "https://7xlnm9.com2.z0.glb.qiniucdn.com/20160409-weixinstart10@3x.png");
				}
				if(index == array[0]) {
					$(this).attr("src", "https://7xlnm9.com2.z0.glb.qiniucdn.com/20160409-weixinstart0" + array[1] + "@3x.png");
				}
			});
		},
		
		companyStars: function(width, height) {//公司评价页头部
		    var num = $(this).attr("data-num");
			for(var i = 0; i < 5; i++) {
				$(this).append("<img src='../source_7niu//2016090618px-shoucang@3x.png'>");
			}
			if (num) {
			    var array = num.split(".");
			    $(this).find("img").each(function (index) {
			        if (index < array[0]) {
			            $(this).attr("src", "../../../source_7niu//2016090618px-yeschou-2@3x.png");
			        }
			        if (index == array[0]) {
			            $(this).attr("src", "../../../source_7niu//2016090618px-yeschou-2@3x.png");
			        }
			    });
			}
		},
		
	});
})(jQuery);

$("#star ul li").on("click", function() {
	if($(this).attr("data-star-selected-font") == 1) { //综合评分
		$("#pic1").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic2").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic3").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic4").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic5").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#zonghe').val($(this).attr("data-star-selected-font"));
	}
	if($(this).attr("data-star-selected-font") == "2") {
		$("#pic1").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic2").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic3").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic4").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic5").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#zonghe').val($(this).attr("data-star-selected-font"));
	}
	if($(this).attr("data-star-selected-font") == "3") {
		$("#pic1").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic2").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic3").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic4").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic5").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#zonghe').val($(this).attr("data-star-selected-font"));
	}
	if($(this).attr("data-star-selected-font") == "4") {
		$("#pic1").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic2").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic3").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic4").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic5").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#zonghe').val($(this).attr("data-star-selected-font"));
	}
	if($(this).attr("data-star-selected-font") == "5") {
		$("#pic1").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic2").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic3").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic4").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic5").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$('#zonghe').val($(this).attr("data-star-selected-font"));
	}
	if($('#zonghe').val() != '') {
		$('.sendPing').css('background', '#1AD46E');
	}
});
$("#stars ul li").on("click", function() { //工作环境
	if($(this).attr("data-star-font") == 1) {
		$("#pic6").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic7").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic8").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic9").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic10").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#gongzuo').val($(this).attr("data-star-font"));
	}
	if($(this).attr("data-star-font") == "2") {
		$("#pic6").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic7").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic8").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic9").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic10").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#gongzuo').val($(this).attr("data-star-font"));
	}
	if($(this).attr("data-star-font") == "3") {
		$("#pic6").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic7").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic8").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic9").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic10").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#gongzuo').val($(this).attr("data-star-font"));
	}
	if($(this).attr("data-star-font") == "4") {
		$("#pic6").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic7").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic8").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic9").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic10").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#gongzuo').val($(this).attr("data-star-font"));
	}
	if($(this).attr("data-star-font") == "5") {
		$("#pic6").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic7").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic8").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic9").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic10").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$('#gongzuo').val($(this).attr("data-star-font"));
	}
	if($('#gongzuo').val() != '') {
		$('.sendPing').css('background', '#1AD46E');
	}
});
$("#starss ul li").on("click", function() { //描述相符
	if($(this).attr("data-selected-font") == 1) {
		$("#pic11").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic12").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic13").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic14").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic15").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#neirong').val($(this).attr("data-selected-font"));
	}
	if($(this).attr("data-selected-font") == "2") {
		$("#pic11").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic12").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic13").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic14").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic15").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#neirong').val($(this).attr("data-selected-font"));
	}
	if($(this).attr("data-selected-font") == "3") {
		$("#pic11").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic12").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic13").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic14").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic15").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#neirong').val($(this).attr("data-selected-font"));
	}
	if($(this).attr("data-selected-font") == "4") {
		$("#pic11").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic12").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic13").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic14").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic15").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#neirong').val($(this).attr("data-selected-font"));
	}
	if($(this).attr("data-selected-font") == "5") {
		$("#pic11").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic12").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic13").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic14").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic15").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$('#neirong').val($(this).attr("data-selected-font"));
	}
	if($('#neirong').val() != '') {
		$('.sendPing').css('background', '#1AD46E');
	}
});
$("#starsss ul li").on("click", function() { //结算效率
	if($(this).attr("data-star-selected") == 1) {
		$("#pic16").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic17").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic18").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic19").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic20").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#jiesuan').val($(this).attr("data-star-selected"));
	}
	if($(this).attr("data-star-selected") == "2") {
		$("#pic16").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic17").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic18").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic19").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic20").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#jiesuan').val($(this).attr("data-star-selected"));
	}
	if($(this).attr("data-star-selected") == "3") {
		$("#pic16").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic17").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic18").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic19").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$("#pic20").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#jiesuan').val($(this).attr("data-star-selected"));
	}
	if($(this).attr("data-star-selected") == "4") {
		$("#pic16").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic17").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic18").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic19").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic20").attr("src", "../../../source_7niu//2016092318px-xingh@3x.png");
		$('#jiesuan').val($(this).attr("data-star-selected"));
	}
	if($(this).attr("data-star-selected") == "5") {
		$("#pic16").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic17").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic18").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic19").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$("#pic20").attr("src", "../../../source_7niu//2016092318px-xingl@3x.png");
		$('#jiesuan').val($(this).attr("data-star-selected"));
	}
	if($('#jiesuan').val() != '') {
		$('.sendPing').css('background', '#1AD46E');
	}
});